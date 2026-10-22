using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Classes
{
    public partial class ClassesViewControl : UserControl
    {
        private readonly IClassService _classService;
        private readonly ITrainerService _trainerService;
        private readonly IMemberService _memberService;
        private readonly ISubscriptionService _subscriptionService;

        private class FilterTrainerItem
        {
            public int? Id { get; }
            public string Name { get; }

            public FilterTrainerItem(int? id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() => Name;
        }

        private class FilterDayItem
        {
            public DayOfWeek? Day { get; }
            public string Name { get; }

            public FilterDayItem(DayOfWeek? day, string name)
            {
                Day = day;
                Name = name;
            }

            public override string ToString() => Name;
        }

        public ClassesViewControl(
            IClassService? classService = null,
            ITrainerService? trainerService = null,
            IMemberService? memberService = null,
            ISubscriptionService? subscriptionService = null)
        {
            InitializeComponent();
            _classService = classService ?? new ClassService();
            _trainerService = trainerService ?? new TrainerService();
            _memberService = memberService ?? new MemberService();
            _subscriptionService = subscriptionService ?? new SubscriptionService();

            SubscribeEvents();
            PopulateFilterCombos();
            LoadClasses();
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.GymClassChanged += OnGymClassChanged;
            AppEvents.BookingChanged += OnBookingChanged;
            AppEvents.TrainerChanged += OnTrainerChanged;
            AppEvents.MemberChanged += OnMemberChanged;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.GymClassChanged -= OnGymClassChanged;
            AppEvents.BookingChanged -= OnBookingChanged;
            AppEvents.TrainerChanged -= OnTrainerChanged;
            AppEvents.MemberChanged -= OnMemberChanged;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnGymClassChanged(GymClass gymClass, ChangeType changeType) => RunOnUiThread(() => LoadClasses(gymClass.Id));
        private void OnBookingChanged(Booking booking, ChangeType changeType) => RunOnUiThread(() => LoadClasses(booking.ClassId));
        private void OnTrainerChanged(Trainer trainer, ChangeType changeType) => RunOnUiThread(() => { PopulateTrainersFilter(); LoadClasses(); });
        private void OnMemberChanged(Member member, ChangeType changeType) => RunOnUiThread(() => LoadRoster());
        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType) => RunOnUiThread(() => LoadRoster());
        private void OnDataReset() => RunOnUiThread(() => { PopulateFilterCombos(); LoadClasses(); });

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

        #region Filter Setup & Population

        private void PopulateFilterCombos()
        {
            // Day filter
            cboDayFilter.SelectedIndexChanged -= FilterControl_Changed;
            cboDayFilter.Items.Clear();
            cboDayFilter.Items.Add(new FilterDayItem(null, "All Days"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Monday, "Monday"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Tuesday, "Tuesday"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Wednesday, "Wednesday"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Thursday, "Thursday"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Friday, "Friday"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Saturday, "Saturday"));
            cboDayFilter.Items.Add(new FilterDayItem(DayOfWeek.Sunday, "Sunday"));
            cboDayFilter.SelectedIndex = 0;
            cboDayFilter.SelectedIndexChanged += FilterControl_Changed;

            PopulateTrainersFilter();
        }

        private void PopulateTrainersFilter()
        {
            cboTrainerFilter.SelectedIndexChanged -= FilterControl_Changed;
            cboTrainerFilter.Items.Clear();
            cboTrainerFilter.Items.Add(new FilterTrainerItem(null, "All Trainers"));

            var trainers = _trainerService.GetAllTrainers(includeInactive: false);
            foreach (var trainer in trainers)
            {
                cboTrainerFilter.Items.Add(new FilterTrainerItem(trainer.Id, trainer.FullName));
            }

            cboTrainerFilter.SelectedIndex = 0;
            cboTrainerFilter.SelectedIndexChanged += FilterControl_Changed;
        }

        private void FilterControl_Changed(object? sender, EventArgs e)
        {
            LoadClasses();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }

        #endregion

        #region Class Table Loading & Selection

        public void LoadClasses(int? preserveClassId = null)
        {
            int? targetId = preserveClassId ?? GetSelectedClass()?.Id;

            DayOfWeek? dayFilter = (cboDayFilter.SelectedItem as FilterDayItem)?.Day;
            int? trainerIdFilter = (cboTrainerFilter.SelectedItem as FilterTrainerItem)?.Id;

            dgvClasses.Rows.Clear();
            var classes = _classService.GetAllClasses(
                dayFilter: dayFilter,
                trainerIdFilter: trainerIdFilter,
                searchQuery: txtSearch.Text,
                includeInactive: chkIncludeInactive.Checked);

            int selectedRowIndex = -1;

            foreach (var gymClass in classes)
            {
                var trainer = _trainerService.GetTrainerById(gymClass.TrainerId);
                var trainerName = trainer != null ? trainer.FullName : $"Trainer #{gymClass.TrainerId}";
                var timeStr = DateTime.Today.Add(gymClass.StartTime).ToString("hh:mm tt");
                var scheduleStr = $"{gymClass.DayOfWeek} at {timeStr}";

                int activeBookings = _classService.GetActiveBookingCount(gymClass.Id);
                int freeSpots = Math.Max(0, gymClass.Capacity - activeBookings);
                var bookedStr = $"{activeBookings}/{gymClass.Capacity} ({freeSpots} free)";
                var statusStr = !gymClass.IsActive ? "Deactivated" : (freeSpots == 0 ? "Full" : "Available");

                int rowIndex = dgvClasses.Rows.Add(
                    gymClass.Id,
                    gymClass.Name,
                    trainerName,
                    scheduleStr,
                    $"{gymClass.DurationMinutes}m",
                    gymClass.Capacity,
                    bookedStr,
                    statusStr);

                var row = dgvClasses.Rows[rowIndex];
                row.Tag = gymClass;

                if (!gymClass.IsActive)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                    row.DefaultCellStyle.Font = new Font(dgvClasses.Font, FontStyle.Italic);
                }
                else if (freeSpots == 0)
                {
                    row.Cells[colStatus.Index].Style.ForeColor = Color.FromArgb(220, 38, 38);
                    row.Cells[colStatus.Index].Style.Font = new Font(dgvClasses.Font, FontStyle.Bold);
                }
                else
                {
                    row.Cells[colStatus.Index].Style.ForeColor = Color.FromArgb(5, 150, 105);
                }

                if (targetId.HasValue && gymClass.Id == targetId.Value)
                {
                    selectedRowIndex = rowIndex;
                }
            }

            if (selectedRowIndex >= 0 && selectedRowIndex < dgvClasses.Rows.Count)
            {
                dgvClasses.ClearSelection();
                dgvClasses.Rows[selectedRowIndex].Selected = true;
            }
            else if (dgvClasses.Rows.Count > 0)
            {
                dgvClasses.ClearSelection();
                dgvClasses.Rows[0].Selected = true;
            }

            UpdateClassActions();
            LoadRoster();
        }

        private GymClass? GetSelectedClass()
        {
            if (dgvClasses.SelectedRows.Count == 0) return null;
            return dgvClasses.SelectedRows[0].Tag as GymClass;
        }

        private Booking? GetSelectedBooking()
        {
            if (dgvRoster.SelectedRows.Count == 0) return null;
            return dgvRoster.SelectedRows[0].Tag as Booking;
        }

        private void UpdateClassActions()
        {
            var selectedClass = GetSelectedClass();
            bool hasSelection = selectedClass != null;

            btnEditClass.Enabled = hasSelection;
            btnToggleActive.Enabled = hasSelection;
            btnDeleteClass.Enabled = hasSelection;

            if (selectedClass != null)
            {
                if (selectedClass.IsActive)
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

        private void dgvClasses_SelectionChanged(object sender, EventArgs e)
        {
            UpdateClassActions();
            LoadRoster();
        }

        private void dgvClasses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEditClass_Click(sender, EventArgs.Empty);
            }
        }

        #endregion

        #region Roster & Booking Management

        private void LoadRoster()
        {
            dgvRoster.Rows.Clear();
            var gymClass = GetSelectedClass();

            if (gymClass == null)
            {
                lblRosterTitle.Text = "No Class Selected";
                lblRosterSchedule.Text = "Select a class schedule from the left table to inspect enrolled members.";
                lblRosterSpots.Text = "—";
                pbrCapacity.Value = 0;
                btnBookMember.Enabled = false;
                btnCancelBooking.Enabled = false;
                return;
            }

            var trainer = _trainerService.GetTrainerById(gymClass.TrainerId);
            var trainerName = trainer != null ? trainer.FullName : "Unassigned";
            var timeStr = DateTime.Today.Add(gymClass.StartTime).ToString("hh:mm tt");

            lblRosterTitle.Text = gymClass.Name;
            lblRosterSchedule.Text = $"{gymClass.DayOfWeek} at {timeStr} ({gymClass.DurationMinutes} mins) • Trainer: {trainerName}";

            int activeBookings = _classService.GetActiveBookingCount(gymClass.Id);
            int availableSpots = Math.Max(0, gymClass.Capacity - activeBookings);

            pbrCapacity.Maximum = Math.Max(1, gymClass.Capacity);
            pbrCapacity.Value = Math.Clamp(activeBookings, 0, pbrCapacity.Maximum);

            if (availableSpots == 0)
            {
                lblRosterSpots.Text = $"FULL ({activeBookings}/{gymClass.Capacity})";
                lblRosterSpots.ForeColor = Color.FromArgb(220, 38, 38);
            }
            else
            {
                lblRosterSpots.Text = $"{activeBookings}/{gymClass.Capacity} Booked ({availableSpots} spots left)";
                lblRosterSpots.ForeColor = Color.FromArgb(5, 150, 105);
            }

            btnBookMember.Enabled = gymClass.IsActive && availableSpots > 0;

            var bookings = _classService.GetClassBookings(gymClass.Id, includeCancelled: false);
            foreach (var booking in bookings)
            {
                var member = _memberService.GetMemberById(booking.MemberId);
                var memberName = member != null ? member.FullName : $"Member #{booking.MemberId}";
                var memberPhone = member?.Phone ?? "—";

                int rowIndex = dgvRoster.Rows.Add(
                    booking.Id,
                    booking.MemberId,
                    memberName,
                    memberPhone,
                    booking.BookingDate.ToString("yyyy-MM-dd"));

                dgvRoster.Rows[rowIndex].Tag = booking;
            }

            UpdateRosterActions();
        }

        private void UpdateRosterActions()
        {
            var booking = GetSelectedBooking();
            btnCancelBooking.Enabled = booking != null && !booking.IsCancelled;
        }

        private void dgvRoster_SelectionChanged(object sender, EventArgs e)
        {
            UpdateRosterActions();
        }

        #endregion

        #region Action Handlers

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            using var dialog = new ClassEditDialog(null, _classService, _trainerService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadClasses();
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            var selectedClass = GetSelectedClass();
            if (selectedClass == null) return;

            using var dialog = new ClassEditDialog(selectedClass, _classService, _trainerService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadClasses(selectedClass.Id);
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var selectedClass = GetSelectedClass();
            if (selectedClass == null) return;

            if (selectedClass.IsActive)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to deactivate class '{selectedClass.Name}'?\n\nDeactivated classes remain in historical logs but cannot accept new member bookings.",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var result = _classService.UpdateClass(
                        selectedClass.Id,
                        selectedClass.Name,
                        selectedClass.TrainerId,
                        selectedClass.DayOfWeek,
                        selectedClass.StartTime,
                        selectedClass.DurationMinutes,
                        selectedClass.Capacity,
                        false);

                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadClasses(selectedClass.Id);
                    }
                }
            }
            else
            {
                var confirm = MessageBox.Show(
                    $"Reactivate class '{selectedClass.Name}' for bookings and schedule display?",
                    "Confirm Reactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var result = _classService.UpdateClass(
                        selectedClass.Id,
                        selectedClass.Name,
                        selectedClass.TrainerId,
                        selectedClass.DayOfWeek,
                        selectedClass.StartTime,
                        selectedClass.DurationMinutes,
                        selectedClass.Capacity,
                        true);

                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadClasses(selectedClass.Id);
                    }
                }
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            var selectedClass = GetSelectedClass();
            if (selectedClass == null) return;

            int activeBookings = _classService.GetActiveBookingCount(selectedClass.Id);

            var confirm = MessageBox.Show(
                $"Are you sure you want to remove '{selectedClass.Name}'?\n\nActive bookings: {activeBookings}.\n" +
                (activeBookings > 0
                    ? "Because members are currently booked, this class will be safely deactivated rather than deleted to retain booking history."
                    : "No members are currently booked. The class schedule will be permanently deleted."),
                "Confirm Delete / Deactivate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var result = _classService.DeleteOrDeactivateClass(selectedClass.Id);
                if (result.IsFailure)
                {
                    MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadClasses();
                }
            }
        }

        private void btnBookMember_Click(object sender, EventArgs e)
        {
            var selectedClass = GetSelectedClass();
            if (selectedClass == null) return;

            using var dialog = new BookClassDialog(
                selectedClass,
                _classService,
                _memberService,
                _trainerService,
                _subscriptionService);

            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadClasses(selectedClass.Id);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            var selectedClass = GetSelectedClass();
            var selectedBooking = GetSelectedBooking();
            if (selectedClass == null || selectedBooking == null) return;

            var member = _memberService.GetMemberById(selectedBooking.MemberId);
            var memberName = member != null ? member.FullName : $"Member #{selectedBooking.MemberId}";

            // Rule 5: Cancelling a booking frees one place
            var confirm = MessageBox.Show(
                $"Cancel class booking #{selectedBooking.Id} for member '{memberName}' in '{selectedClass.Name}'?\n\nThis will immediately free up one spot for other members (Business Rule 5).",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var result = _classService.CancelBookingById(selectedBooking.Id);
                if (result.IsFailure)
                {
                    MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadClasses(selectedClass.Id);
                }
            }
        }

        #endregion
    }
}
