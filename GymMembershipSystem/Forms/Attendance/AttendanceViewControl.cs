using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Attendance
{
    public partial class AttendanceViewControl : UserControl
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IMemberService _memberService;
        private readonly ISubscriptionService _subscriptionService;
        private readonly IPlanService _planService;

        public AttendanceViewControl(
            IAttendanceService? attendanceService = null,
            IMemberService? memberService = null,
            ISubscriptionService? subscriptionService = null,
            IPlanService? planService = null)
        {
            InitializeComponent();
            _attendanceService = attendanceService ?? new AttendanceService();
            _memberService = memberService ?? new MemberService();
            _subscriptionService = subscriptionService ?? new SubscriptionService();
            _planService = planService ?? new PlanService();

            SubscribeEvents();
            ConfigureMemberAutocomplete();
            RefreshAll();
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.AttendanceRecorded += OnAttendanceRecorded;
            AppEvents.MemberChanged += OnMemberChanged;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.AttendanceRecorded -= OnAttendanceRecorded;
            AppEvents.MemberChanged -= OnMemberChanged;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnAttendanceRecorded(Models.Attendance attendance) => RunOnUiThread(RefreshAll);
        private void OnMemberChanged(Member member, ChangeType changeType) => RunOnUiThread(() => { ConfigureMemberAutocomplete(); RefreshAll(); });
        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType) => RunOnUiThread(RefreshAll);
        private void OnDataReset() => RunOnUiThread(() => { ConfigureMemberAutocomplete(); RefreshAll(); });

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

        #region Autocomplete & Data Refresh

        private void ConfigureMemberAutocomplete()
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();
            var members = _memberService.GetMembers();

            foreach (var member in members)
            {
                autoCompleteCollection.Add($"{member.Id} - {member.FullName}");
                autoCompleteCollection.Add(member.FullName);
                autoCompleteCollection.Add(member.Id.ToString());
            }

            txtMemberSearch.AutoCompleteCustomSource = autoCompleteCollection;
        }

        public void RefreshAll()
        {
            RefreshMetrics();
            LoadAttendanceLog();
        }

        private void RefreshMetrics()
        {
            int occupancy = _attendanceService.GetCurrentOccupancyCount();
            int totalToday = _attendanceService.GetTodayTotalVisitsCount();
            var activeMembers = _memberService.GetMembers(statusFilter: MembershipStatus.Active).Count;

            lblOccupancyVal.Text = occupancy.ToString();
            lblTotalVisitsVal.Text = totalToday.ToString();
            lblActiveMembersVal.Text = activeMembers.ToString();
        }

        public void LoadAttendanceLog()
        {
            int? selectedId = GetSelectedAttendance()?.Id;

            dgvAttendance.Rows.Clear();
            var logs = _attendanceService.GetTodayAttendances(
                searchQuery: txtLogFilter.Text,
                currentlyInsideOnly: chkInsideOnly.Checked);

            int selectedRowIndex = -1;

            foreach (var log in logs)
            {
                var member = _memberService.GetMemberById(log.MemberId);
                var memberName = member != null ? $"{member.FullName} (#{member.Id})" : $"Member #{log.MemberId}";

                var plan = _memberService.GetMemberCurrentPlan(log.MemberId);
                var planName = plan?.Name ?? "No Plan";

                var checkInStr = log.CheckInTime.ToString("hh:mm:ss tt");
                var checkOutStr = log.CheckOutTime.HasValue ? log.CheckOutTime.Value.ToString("hh:mm:ss tt") : "—";

                string durationStr;
                if (log.CheckOutTime.HasValue)
                {
                    var duration = log.CheckOutTime.Value - log.CheckInTime;
                    durationStr = $"{Math.Max(1, (int)duration.TotalMinutes)} mins";
                }
                else
                {
                    var duration = DateTime.Now - log.CheckInTime;
                    durationStr = $"{(int)duration.TotalMinutes} mins (In)";
                }

                var statusStr = log.IsCurrentlyInside ? "🟢 Inside" : "⚪ Departed";

                int rowIndex = dgvAttendance.Rows.Add(
                    log.Id,
                    memberName,
                    planName,
                    checkInStr,
                    checkOutStr,
                    durationStr,
                    statusStr);

                var row = dgvAttendance.Rows[rowIndex];
                row.Tag = log;

                if (log.IsCurrentlyInside)
                {
                    row.Cells[colStatus.Index].Style.ForeColor = Color.FromArgb(5, 150, 105);
                    row.Cells[colStatus.Index].Style.Font = new Font(dgvAttendance.Font, FontStyle.Bold);
                }
                else
                {
                    row.Cells[colStatus.Index].Style.ForeColor = Color.FromArgb(100, 116, 139);
                }

                if (selectedId.HasValue && log.Id == selectedId.Value)
                {
                    selectedRowIndex = rowIndex;
                }
            }

            if (selectedRowIndex >= 0 && selectedRowIndex < dgvAttendance.Rows.Count)
            {
                dgvAttendance.ClearSelection();
                dgvAttendance.Rows[selectedRowIndex].Selected = true;
            }
            else if (dgvAttendance.Rows.Count > 0)
            {
                dgvAttendance.ClearSelection();
                dgvAttendance.Rows[0].Selected = true;
            }

            UpdateButtonStates();
        }

        private Models.Attendance? GetSelectedAttendance()
        {
            if (dgvAttendance.SelectedRows.Count == 0) return null;
            return dgvAttendance.SelectedRows[0].Tag as Models.Attendance;
        }

        private void UpdateButtonStates()
        {
            var selected = GetSelectedAttendance();
            btnCheckOutSelected.Enabled = selected != null && selected.IsCurrentlyInside;
        }

        private void dgvAttendance_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void dgvAttendance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnCheckOutSelected_Click(sender, EventArgs.Empty);
            }
        }

        #endregion

        #region Front Desk Terminal Check-In & Check-Out Handlers

        private void txtMemberSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents annoying beep ding
                ExecuteCheckIn();
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            ExecuteCheckIn();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ExecuteCheckOutFromSearch();
        }

        private Member? ResolveMemberFromInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            input = input.Trim();

            // 1. Direct ID integer match
            if (int.TryParse(input, out int directId))
            {
                return _memberService.GetMemberById(directId);
            }

            // 2. Format: "101 - John Doe"
            int dashIndex = input.IndexOf('-');
            if (dashIndex > 0)
            {
                var idPart = input.Substring(0, dashIndex).Trim();
                if (int.TryParse(idPart, out int parsedId))
                {
                    var found = _memberService.GetMemberById(parsedId);
                    if (found != null) return found;
                }
            }

            // 3. Match by exact full name
            var allMembers = _memberService.GetMembers();
            var exactName = allMembers.FirstOrDefault(m => string.Equals(m.FullName, input, StringComparison.OrdinalIgnoreCase));
            if (exactName != null) return exactName;

            // 4. Match by name starts with / contains
            return allMembers.FirstOrDefault(m => m.FullName.Contains(input, StringComparison.OrdinalIgnoreCase));
        }

        private void ExecuteCheckIn()
        {
            var rawInput = txtMemberSearch.Text;
            var member = ResolveMemberFromInput(rawInput);

            if (member == null)
            {
                ShowBanner(
                    "✗",
                    $"Member not recognized for search '{rawInput}'. Please verify Member ID or Name.",
                    Color.FromArgb(254, 226, 226),
                    Color.FromArgb(185, 28, 28));
                txtMemberSearch.SelectAll();
                txtMemberSearch.Focus();
                return;
            }

            var result = _attendanceService.CheckInMember(member.Id);
            if (result.IsFailure)
            {
                ShowBanner(
                    "✗",
                    result.Error,
                    Color.FromArgb(254, 226, 226),
                    Color.FromArgb(185, 28, 28));
                txtMemberSearch.SelectAll();
                txtMemberSearch.Focus();
                return;
            }

            var plan = _memberService.GetMemberCurrentPlan(member.Id);
            var planText = plan != null ? plan.Name : "Active Plan";
            var timeStr = DateTime.Now.ToString("hh:mm tt");

            ShowBanner(
                "✓",
                $"Check-in APPROVED: {member.FullName} (#{member.Id}) at {timeStr} • Plan: {planText}",
                Color.FromArgb(209, 250, 229),
                Color.FromArgb(5, 150, 105));

            txtMemberSearch.Clear();
            txtMemberSearch.Focus();
            RefreshAll();
        }

        private void ExecuteCheckOutFromSearch()
        {
            var rawInput = txtMemberSearch.Text;
            if (string.IsNullOrWhiteSpace(rawInput))
            {
                // Fall back to selected row check-out
                if (btnCheckOutSelected.Enabled)
                {
                    btnCheckOutSelected_Click(btnCheckOutSelected, EventArgs.Empty);
                    return;
                }

                ShowBanner(
                    "ℹ️",
                    "Enter a Member ID/Name or select an attendee from the table below to check out.",
                    Color.FromArgb(239, 246, 255),
                    Color.FromArgb(29, 78, 216));
                txtMemberSearch.Focus();
                return;
            }

            var member = ResolveMemberFromInput(rawInput);
            if (member == null)
            {
                ShowBanner(
                    "✗",
                    $"Member not recognized for search '{rawInput}'.",
                    Color.FromArgb(254, 226, 226),
                    Color.FromArgb(185, 28, 28));
                return;
            }

            var result = _attendanceService.CheckOutMemberById(member.Id);
            if (result.IsFailure)
            {
                ShowBanner(
                    "✗",
                    result.Error,
                    Color.FromArgb(254, 226, 226),
                    Color.FromArgb(185, 28, 28));
                return;
            }

            ShowBanner(
                "📤",
                $"Check-out RECORDED: {member.FullName} (#{member.Id}) departed at {DateTime.Now:hh:mm tt}.",
                Color.FromArgb(241, 245, 249),
                Color.FromArgb(30, 41, 59));

            txtMemberSearch.Clear();
            txtMemberSearch.Focus();
            RefreshAll();
        }

        private void btnCheckOutSelected_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedAttendance();
            if (selected == null || !selected.IsCurrentlyInside) return;

            var member = _memberService.GetMemberById(selected.MemberId);
            var memberName = member != null ? member.FullName : $"Member #{selected.MemberId}";

            var result = _attendanceService.CheckOutMember(selected.Id);
            if (result.IsFailure)
            {
                ShowBanner(
                    "✗",
                    result.Error,
                    Color.FromArgb(254, 226, 226),
                    Color.FromArgb(185, 28, 28));
                return;
            }

            var duration = DateTime.Now - selected.CheckInTime;
            var durationMins = Math.Max(1, (int)duration.TotalMinutes);

            ShowBanner(
                "📤",
                $"Check-out RECORDED: {memberName} checked out at {DateTime.Now:hh:mm tt} (Total Visit: {durationMins} mins).",
                Color.FromArgb(241, 245, 249),
                Color.FromArgb(30, 41, 59));

            RefreshAll();
        }

        private void ShowBanner(string icon, string message, Color backColor, Color foreColor)
        {
            pnlFeedbackBanner.BackColor = backColor;
            lblFeedbackIcon.Text = icon;
            lblFeedbackIcon.ForeColor = foreColor;
            lblFeedbackMessage.Text = message;
            lblFeedbackMessage.ForeColor = foreColor;
            pnlFeedbackBanner.Visible = true;
        }

        #endregion

        #region Table Filtering & Quick Actions

        private void txtLogFilter_TextChanged(object sender, EventArgs e)
        {
            LoadAttendanceLog();
        }

        private void chkInsideOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadAttendanceLog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        #endregion
    }
}
