using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Forms.Subscriptions;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Members
{
    public partial class MembersViewControl : UserControl
    {
        private readonly IMemberService _memberService;
        private readonly IPlanService _planService;
        private readonly ISubscriptionService _subscriptionService;
        private readonly ListViewItemComparer _lvwComparer;

        public MembersViewControl(
            IMemberService? memberService = null,
            IPlanService? planService = null,
            ISubscriptionService? subscriptionService = null)
        {
            InitializeComponent();
            _memberService = memberService ?? new MemberService();
            _planService = planService ?? new PlanService();
            _subscriptionService = subscriptionService ?? new SubscriptionService();

            _lvwComparer = new ListViewItemComparer();
            lvwMembers.ListViewItemSorter = _lvwComparer;

            SubscribeEvents();
            LoadFilterDropdowns();
            RefreshMemberList();
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.MemberChanged += OnMemberChanged;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.PlanChanged += OnPlanChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.MemberChanged -= OnMemberChanged;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.PlanChanged -= OnPlanChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnMemberChanged(Member member, ChangeType changeType)
        {
            RunOnUiThread(RefreshMemberList);
        }

        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType)
        {
            RunOnUiThread(RefreshMemberList);
        }

        private void OnPlanChanged(Plan plan, ChangeType changeType)
        {
            RunOnUiThread(() =>
            {
                LoadFilterDropdowns();
                RefreshMemberList();
            });
        }

        private void OnDataReset()
        {
            RunOnUiThread(() =>
            {
                LoadFilterDropdowns();
                RefreshMemberList();
            });
        }

        private void RunOnUiThread(Action action)
        {
            if (IsDisposed || Disposing) return;
            if (InvokeRequired)
            {
                try { BeginInvoke(action); } catch (ObjectDisposedException) { }
            }
            else
            {
                action();
            }
        }

        #endregion

        #region Filters & Data Population

        private void LoadFilterDropdowns()
        {
            // Plan filter
            cboPlanFilter.Items.Clear();
            cboPlanFilter.Items.Add(new FilterItem { Id = 0, Name = "All Plans" });

            var plans = _planService.GetAllPlans(includeInactive: false);
            foreach (var plan in plans)
            {
                cboPlanFilter.Items.Add(new FilterItem { Id = plan.Id, Name = plan.Name });
            }
            cboPlanFilter.SelectedIndex = 0;

            // Status filter
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("All Statuses");
            cboStatusFilter.Items.Add(MembershipStatus.Active.ToString());
            cboStatusFilter.Items.Add(MembershipStatus.Expired.ToString());
            cboStatusFilter.Items.Add(MembershipStatus.Inactive.ToString());
            cboStatusFilter.SelectedIndex = 0;
        }

        public void RefreshMemberList()
        {
            lvwMembers.BeginUpdate();
            lvwMembers.Items.Clear();

            int? planIdFilter = null;
            if (cboPlanFilter.SelectedItem is FilterItem planItem && planItem.Id > 0)
            {
                planIdFilter = planItem.Id;
            }

            MembershipStatus? statusFilter = null;
            if (cboStatusFilter.SelectedItem is string statusStr &&
                Enum.TryParse<MembershipStatus>(statusStr, out var parsedStatus))
            {
                statusFilter = parsedStatus;
            }

            var members = _memberService.GetMembers(txtSearch.Text, planIdFilter, statusFilter);

            foreach (var member in members)
            {
                var sub = _memberService.GetMemberActiveSubscription(member.Id) ??
                          _memberService.GetMemberLatestSubscription(member.Id);

                var status = _memberService.GetMemberStatus(member.Id);
                var plan = _memberService.GetMemberCurrentPlan(member.Id);

                var item = new ListViewItem($"#{member.Id:D4}")
                {
                    Tag = member
                };

                item.SubItems.Add(member.FullName);
                item.SubItems.Add(member.Gender.ToString());
                item.SubItems.Add(member.Age.ToString());
                item.SubItems.Add(member.Phone);
                item.SubItems.Add(member.Email);
                item.SubItems.Add(plan?.Name ?? "None");
                item.SubItems.Add(status.ToString());
                item.SubItems.Add(sub != null ? sub.ExpiryDate.ToString("yyyy-MM-dd") : "—");
                item.SubItems.Add(member.JoinDate.ToString("yyyy-MM-dd"));

                // Color Badging
                switch (status)
                {
                    case MembershipStatus.Active:
                        item.ForeColor = Color.FromArgb(5, 150, 105);
                        break;
                    case MembershipStatus.Expired:
                        item.ForeColor = Color.FromArgb(217, 119, 6);
                        break;
                    case MembershipStatus.Inactive:
                        item.ForeColor = Color.FromArgb(148, 163, 184);
                        item.Font = new Font(lvwMembers.Font, FontStyle.Italic);
                        break;
                }

                lvwMembers.Items.Add(item);
            }

            lvwMembers.EndUpdate();
            UpdateButtonStates();
        }

        private Member? GetSelectedMember()
        {
            if (lvwMembers.SelectedItems.Count == 0) return null;
            return lvwMembers.SelectedItems[0].Tag as Member;
        }

        private void UpdateButtonStates()
        {
            var member = GetSelectedMember();
            bool hasSelection = member != null;

            btnEditMember.Enabled = hasSelection;
            btnAssignPlan.Enabled = hasSelection && member!.IsActive;
            btnToggleActive.Enabled = hasSelection;

            if (member != null)
            {
                if (member.IsActive)
                {
                    btnToggleActive.Text = "⚡ Deactivate";
                    btnToggleActive.ForeColor = Color.FromArgb(220, 38, 38);
                }
                else
                {
                    btnToggleActive.Text = "✅ Reactivate";
                    btnToggleActive.ForeColor = Color.FromArgb(5, 150, 105);
                }
            }
        }

        private void lvwMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void lvwMembers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _lvwComparer.ColumnIndex)
            {
                _lvwComparer.Order = _lvwComparer.Order == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
            }
            else
            {
                _lvwComparer.ColumnIndex = e.Column;
                _lvwComparer.Order = SortOrder.Ascending;
            }

            lvwMembers.Sort();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => RefreshMemberList();
        private void cboPlanFilter_SelectedIndexChanged(object sender, EventArgs e) => RefreshMemberList();
        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => RefreshMemberList();
        private void btnRefresh_Click(object sender, EventArgs e) => RefreshMemberList();

        #endregion

        #region Member Actions

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            using var dialog = new MemberEditDialog(null, _memberService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.SavedMember != null)
            {
                RefreshMemberList();

                var promptPlan = MessageBox.Show(
                    $"Member '{dialog.SavedMember.FullName}' registered successfully!\n\nWould you like to assign a membership plan to this member now?",
                    "Assign Membership Plan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (promptPlan == DialogResult.Yes)
                {
                    using var planDialog = new AssignPlanDialog(dialog.SavedMember, _subscriptionService, _planService);
                    planDialog.ShowDialog(FindForm());
                    RefreshMemberList();
                }
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            var member = GetSelectedMember();
            if (member == null) return;

            using var dialog = new MemberEditDialog(member, _memberService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                RefreshMemberList();
            }
        }

        private void lvwMembers_DoubleClick(object sender, EventArgs e)
        {
            btnEditMember_Click(sender, e);
        }

        private void btnAssignPlan_Click(object sender, EventArgs e)
        {
            var member = GetSelectedMember();
            if (member == null) return;

            using var dialog = new AssignPlanDialog(member, _subscriptionService, _planService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                RefreshMemberList();
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var member = GetSelectedMember();
            if (member == null) return;

            if (member.IsActive)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to deactivate member '{member.FullName}' (#{member.Id:D4})?\n\nPer Business Rule 8, if this member has subscriptions or payments, the account will be soft-deactivated to maintain financial audit integrity.",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var result = _memberService.DeleteOrDeactivateMember(member.Id);
                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RefreshMemberList();
                    }
                }
            }
            else
            {
                var confirm = MessageBox.Show(
                    $"Reactivate member profile for '{member.FullName}'?",
                    "Confirm Reactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var result = _memberService.UpdateMember(
                        member.Id, member.FullName, member.Gender, member.DateOfBirth,
                        member.Phone, member.Email, member.Address, true);

                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RefreshMemberList();
                    }
                }
            }
        }

        #endregion

        private class FilterItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;

            public override string ToString() => Name;
        }
    }
}
