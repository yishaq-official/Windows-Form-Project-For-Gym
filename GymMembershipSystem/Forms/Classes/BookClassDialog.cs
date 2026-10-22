using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Classes
{
    public partial class BookClassDialog : Form
    {
        private readonly GymClass _targetClass;
        private readonly IClassService _classService;
        private readonly IMemberService _memberService;
        private readonly ITrainerService _trainerService;
        private readonly ISubscriptionService _subscriptionService;

        private class MemberComboItem
        {
            public Member Member { get; }
            public MembershipStatus Status { get; }

            public MemberComboItem(Member member, MembershipStatus status)
            {
                Member = member;
                Status = status;
            }

            public override string ToString() => $"{Member.FullName} (#{Member.Id}) - [{Status}]";
        }

        public BookClassDialog(
            GymClass targetClass,
            IClassService? classService = null,
            IMemberService? memberService = null,
            ITrainerService? trainerService = null,
            ISubscriptionService? subscriptionService = null)
        {
            InitializeComponent();
            _targetClass = targetClass;
            _classService = classService ?? new ClassService();
            _memberService = memberService ?? new MemberService();
            _trainerService = trainerService ?? new TrainerService();
            _subscriptionService = subscriptionService ?? new SubscriptionService();

            PopulateClassCard();
            PopulateMembers();
        }

        private void PopulateClassCard()
        {
            lblClassName.Text = _targetClass.Name;

            var trainer = _trainerService.GetTrainerById(_targetClass.TrainerId);
            var trainerName = trainer != null ? trainer.FullName : "Unassigned";

            var timeStr = DateTime.Today.Add(_targetClass.StartTime).ToString("hh:mm tt");
            lblClassSchedule.Text = $"{_targetClass.DayOfWeek} at {timeStr} ({_targetClass.DurationMinutes} mins) • Trainer: {trainerName}";

            int activeBookings = _classService.GetActiveBookingCount(_targetClass.Id);
            int availableSpots = Math.Max(0, _targetClass.Capacity - activeBookings);

            if (availableSpots <= 0)
            {
                lblSpotsRemaining.Text = $"FULL ({activeBookings}/{_targetClass.Capacity})";
                lblSpotsRemaining.ForeColor = Color.FromArgb(220, 38, 38);
            }
            else
            {
                lblSpotsRemaining.Text = $"{activeBookings}/{_targetClass.Capacity} Booked ({availableSpots} spots left)";
                lblSpotsRemaining.ForeColor = Color.FromArgb(5, 150, 105);
            }
        }

        private void PopulateMembers()
        {
            cboMember.Items.Clear();
            var members = _memberService.GetMembers();

            foreach (var member in members)
            {
                var status = _memberService.GetMemberStatus(member.Id);
                cboMember.Items.Add(new MemberComboItem(member, status));
            }

            if (cboMember.Items.Count > 0)
            {
                cboMember.SelectedIndex = 0;
            }
            else
            {
                pnlMemberPreview.Visible = false;
                btnConfirmBook.Enabled = false;
                lblErrorMessage.Text = "No active members found in the database.";
                lblErrorMessage.Visible = true;
            }
        }

        private void cboMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (cboMember.SelectedItem is not MemberComboItem item)
            {
                pnlMemberPreview.Visible = false;
                btnConfirmBook.Enabled = false;
                return;
            }

            pnlMemberPreview.Visible = true;
            var member = item.Member;
            var status = item.Status;

            lblMemberName.Text = $"{member.FullName} (ID: #{member.Id})";
            lblMemberPhone.Text = $"Phone: {member.Phone} • Email: {member.Email}";

            // Style status badge
            lblMemberStatusBadge.Text = status.ToString().ToUpper();
            switch (status)
            {
                case MembershipStatus.Active:
                    lblMemberStatusBadge.BackColor = Color.FromArgb(209, 250, 229);
                    lblMemberStatusBadge.ForeColor = Color.FromArgb(5, 150, 105);
                    break;
                case MembershipStatus.Expired:
                    lblMemberStatusBadge.BackColor = Color.FromArgb(254, 226, 226);
                    lblMemberStatusBadge.ForeColor = Color.FromArgb(220, 38, 38);
                    break;
                default:
                    lblMemberStatusBadge.BackColor = Color.FromArgb(241, 245, 249);
                    lblMemberStatusBadge.ForeColor = Color.FromArgb(100, 116, 139);
                    break;
            }

            // Subscriptions info
            var activeSub = _subscriptionService.GetActiveSubscription(member.Id);
            if (activeSub != null)
            {
                lblMemberPlanExpiry.Text = $"Subscription active until: {activeSub.ExpiryDate:yyyy-MM-dd}";
            }
            else
            {
                var latestSub = _subscriptionService.GetLatestSubscription(member.Id);
                lblMemberPlanExpiry.Text = latestSub != null
                    ? $"Subscription expired on: {latestSub.ExpiryDate:yyyy-MM-dd}"
                    : "No membership subscription record";
            }

            // Real-time eligibility evaluation
            int activeBookings = _classService.GetActiveBookingCount(_targetClass.Id);
            bool isFull = activeBookings >= _targetClass.Capacity;
            bool isMemberActive = status == MembershipStatus.Active;
            var bookedMembers = _classService.GetBookedMembers(_targetClass.Id);
            bool alreadyBooked = bookedMembers.Any(m => m.Id == member.Id);

            if (isFull)
            {
                lblValidationNotice.Text = "⚠️ Class is full. Capacity has been reached (Business Rule 3).";
                lblValidationNotice.ForeColor = Color.FromArgb(220, 38, 38);
                btnConfirmBook.Enabled = false;
            }
            else if (!isMemberActive)
            {
                lblValidationNotice.Text = "⚠️ Only active members can book classes (Business Rule 1).";
                lblValidationNotice.ForeColor = Color.FromArgb(220, 38, 38);
                btnConfirmBook.Enabled = false;
            }
            else if (alreadyBooked)
            {
                lblValidationNotice.Text = "⚠️ Member is already booked in this class (Business Rule 4).";
                lblValidationNotice.ForeColor = Color.FromArgb(220, 38, 38);
                btnConfirmBook.Enabled = false;
            }
            else
            {
                lblValidationNotice.Text = "✅ Member is eligible to book this class spot.";
                lblValidationNotice.ForeColor = Color.FromArgb(5, 150, 105);
                btnConfirmBook.Enabled = true;
            }
        }

        private void btnConfirmBook_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (cboMember.SelectedItem is not MemberComboItem item)
            {
                lblErrorMessage.Text = "Please select a member to book.";
                lblErrorMessage.Visible = true;
                return;
            }

            var result = _classService.BookMember(_targetClass.Id, item.Member.Id);
            if (result.IsFailure)
            {
                lblErrorMessage.Text = result.Error;
                lblErrorMessage.Visible = true;
                return;
            }

            MessageBox.Show(
                $"Successfully booked {item.Member.FullName} into '{_targetClass.Name}'!",
                "Booking Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
