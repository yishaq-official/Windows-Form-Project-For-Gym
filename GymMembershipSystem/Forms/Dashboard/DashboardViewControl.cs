using System;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Data;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Forms.Dashboard
{
    public partial class DashboardViewControl : UserControl
    {
        private readonly InMemoryDataStore _dataStore;

        public DashboardViewControl(InMemoryDataStore? dataStore = null)
        {
            InitializeComponent();
            _dataStore = dataStore ?? InMemoryDataStore.Instance;

            SubscribeEvents();
            RefreshMetrics();
            LogActivity("Dashboard initialized. Listening to domain events.");
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.MemberChanged += OnMemberChanged;
            AppEvents.AttendanceRecorded += OnAttendanceRecorded;
            AppEvents.PaymentReceived += OnPaymentReceived;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.GymClassChanged += OnGymClassChanged;
            AppEvents.BookingChanged += OnBookingChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.MemberChanged -= OnMemberChanged;
            AppEvents.AttendanceRecorded -= OnAttendanceRecorded;
            AppEvents.PaymentReceived -= OnPaymentReceived;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.GymClassChanged -= OnGymClassChanged;
            AppEvents.BookingChanged -= OnBookingChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnMemberChanged(Member member, ChangeType changeType)
        {
            RunOnUiThread(() =>
            {
                RefreshMetrics();
                LogActivity($"[EVENT] Member '{member.FullName}' was {changeType.ToString().ToLower()}.");
            });
        }

        private void OnAttendanceRecorded(Attendance attendance)
        {
            RunOnUiThread(() =>
            {
                RefreshMetrics();
                var member = _dataStore.FindMember(attendance.MemberId);
                var memberName = member?.FullName ?? $"Member #{attendance.MemberId}";
                var action = attendance.IsCurrentlyInside ? "checked in" : "checked out";
                LogActivity($"[EVENT] Attendance: {memberName} {action} at {DateTime.Now:hh:mm:ss tt}.");
            });
        }

        private void OnPaymentReceived(Payment payment)
        {
            RunOnUiThread(() =>
            {
                RefreshMetrics();
                var member = _dataStore.FindMember(payment.MemberId);
                var memberName = member?.FullName ?? $"Member #{payment.MemberId}";
                LogActivity($"[EVENT] Payment: Received ${payment.Amount:F2} via {payment.PaymentMethod} from {memberName}.");
            });
        }

        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType)
        {
            RunOnUiThread(() =>
            {
                RefreshMetrics();
                var member = _dataStore.FindMember(subscription.MemberId);
                var plan = _dataStore.FindPlan(subscription.PlanId);
                LogActivity($"[EVENT] Subscription: '{plan?.Name ?? "Plan"}' for {member?.FullName ?? "Member"} was {changeType.ToString().ToLower()}.");
            });
        }

        private void OnGymClassChanged(GymClass gymClass, ChangeType changeType)
        {
            RunOnUiThread(() =>
            {
                LogActivity($"[EVENT] Class: '{gymClass.Name}' was {changeType.ToString().ToLower()}.");
            });
        }

        private void OnBookingChanged(Booking booking, ChangeType changeType)
        {
            RunOnUiThread(() =>
            {
                var action = booking.IsCancelled ? "cancelled" : "confirmed";
                LogActivity($"[EVENT] Booking: Class #{booking.ClassId} booking for Member #{booking.MemberId} was {action}.");
            });
        }

        private void OnDataReset()
        {
            RunOnUiThread(() =>
            {
                RefreshMetrics();
                LogActivity("[EVENT] In-memory repository was reset / re-seeded.");
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

        #region Metrics Calculation

        public void RefreshMetrics()
        {
            int totalMembers;
            int activeMembers;
            int todayAttendance;
            decimal totalRevenue;

            lock (_dataStore.SyncRoot)
            {
                totalMembers = _dataStore.Members.Count;
                var today = DateTime.Today;

                // Active members: have an active subscription expiring on/after today and are active
                var activeMemberIds = _dataStore.Subscriptions
                    .Where(s => s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today)
                    .Select(s => s.MemberId)
                    .Distinct()
                    .ToHashSet();

                activeMembers = _dataStore.Members.Count(m => m.IsActive && activeMemberIds.Contains(m.Id));
                todayAttendance = _dataStore.Attendances.Count(a => a.CheckInTime.Date == today);
                totalRevenue = _dataStore.Payments.Sum(p => p.Amount);
            }

            lblTotalMembersValue.Text = totalMembers.ToString();
            lblActiveMembersValue.Text = activeMembers.ToString();
            lblTodayAttendanceValue.Text = todayAttendance.ToString();
            lblTotalRevenueValue.Text = $"${totalRevenue:N2}";
        }

        private void LogActivity(string message)
        {
            var item = $"{DateTime.Now:HH:mm:ss} - {message}";
            lstActivity.Items.Insert(0, item);

            // Keep maximum 100 log entries
            while (lstActivity.Items.Count > 100)
            {
                lstActivity.Items.RemoveAt(lstActivity.Items.Count - 1);
            }
        }

        private void btnQuickRefresh_Click(object sender, EventArgs e)
        {
            RefreshMetrics();
            LogActivity("Manual metrics refresh requested.");
        }

        #endregion
    }
}
