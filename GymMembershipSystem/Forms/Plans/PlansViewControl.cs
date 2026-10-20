using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Plans
{
    public partial class PlansViewControl : UserControl
    {
        private readonly IPlanService _planService;

        public PlansViewControl(IPlanService? planService = null)
        {
            InitializeComponent();
            _planService = planService ?? new PlanService();

            SubscribeEvents();
            LoadPlans();
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.PlanChanged += OnPlanChanged;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.PlanChanged -= OnPlanChanged;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnPlanChanged(Plan plan, ChangeType changeType)
        {
            RunOnUiThread(LoadPlans);
        }

        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType)
        {
            RunOnUiThread(LoadPlans);
        }

        private void OnDataReset()
        {
            RunOnUiThread(LoadPlans);
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

        #region Data Population

        public void LoadPlans()
        {
            dgvPlans.Rows.Clear();
            var plans = _planService.GetAllPlans(chkIncludeInactive.Checked);

            foreach (var plan in plans)
            {
                int activeSubs = _planService.GetActiveSubscriptionCount(plan.Id);
                var statusText = plan.IsActive ? "Active" : "Deactivated";

                int rowIndex = dgvPlans.Rows.Add(
                    plan.Id,
                    plan.Name,
                    $"{plan.DurationInDays} days",
                    $"${plan.Price:F2}",
                    activeSubs,
                    statusText);

                var row = dgvPlans.Rows[rowIndex];
                row.Tag = plan;

                if (!plan.IsActive)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                    row.DefaultCellStyle.Font = new Font(dgvPlans.Font, FontStyle.Italic);
                }
            }

            UpdateButtonStates();
        }

        private Plan? GetSelectedPlan()
        {
            if (dgvPlans.SelectedRows.Count == 0) return null;
            return dgvPlans.SelectedRows[0].Tag as Plan;
        }

        private void UpdateButtonStates()
        {
            var plan = GetSelectedPlan();
            bool hasSelection = plan != null;

            btnEditPlan.Enabled = hasSelection;
            btnToggleActive.Enabled = hasSelection;

            if (plan != null)
            {
                if (plan.IsActive)
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

        private void dgvPlans_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        #endregion

        #region Action Handlers

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            using var dialog = new PlanEditDialog(null, _planService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadPlans();
            }
        }

        private void btnEditPlan_Click(object sender, EventArgs e)
        {
            var plan = GetSelectedPlan();
            if (plan == null) return;

            using var dialog = new PlanEditDialog(plan, _planService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadPlans();
            }
        }

        private void dgvPlans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEditPlan_Click(sender, EventArgs.Empty);
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var plan = GetSelectedPlan();
            if (plan == null) return;

            if (plan.IsActive)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to deactivate membership plan '{plan.Name}'?\n\nExisting members will retain their ongoing subscriptions, but this plan will not be available for new enrollments.",
                    "Confirm Plan Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var result = _planService.DeleteOrDeactivatePlan(plan.Id);
                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadPlans();
                    }
                }
            }
            else
            {
                var confirm = MessageBox.Show(
                    $"Reactivate membership plan '{plan.Name}' for new member subscriptions?",
                    "Confirm Reactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var result = _planService.UpdatePlan(plan.Id, plan.Name, plan.DurationInDays, plan.Price, true);
                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadPlans();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPlans();
        }

        private void chkIncludeInactive_CheckedChanged(object sender, EventArgs e)
        {
            LoadPlans();
        }

        #endregion
    }
}
