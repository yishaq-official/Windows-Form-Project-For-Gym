using System;
using System.Drawing;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Forms.Attendance;
using GymMembershipSystem.Forms.Classes;
using GymMembershipSystem.Forms.Members;
using GymMembershipSystem.Forms.Plans;
using GymMembershipSystem.Forms.Trainers;

namespace GymMembershipSystem.Forms.Dashboard
{
    public partial class MainForm : Form
    {
        private readonly NavigationService _navigationService;
        private DashboardViewControl? _dashboardView;
        private MembersViewControl? _membersView;
        private PlansViewControl? _plansView;
        private TrainersViewControl? _trainersView;
        private ClassesViewControl? _classesView;
        private AttendanceViewControl? _attendanceView;
        private Button? _currentActiveButton;

        // Visual theme tokens
        private readonly Color _activeButtonColor = Color.FromArgb(37, 99, 235);
        private readonly Color _activeTextColor = Color.White;
        private readonly Color _inactiveButtonColor = Color.Transparent;
        private readonly Color _inactiveTextColor = Color.FromArgb(148, 163, 184);

        public MainForm()
        {
            InitializeComponent();
            _navigationService = new NavigationService(pnlContentHost);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate current authenticated admin
            var user = UserSession.CurrentUser;
            lblCurrentUser.Text = user != null ? $"👤 {user.FullName} ({user.Role})" : "👤 Administrator";

            // Start live system clock
            UpdateClock();
            clockTimer.Start();

            // Default landing view: Dashboard
            ShowDashboard();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy  hh:mm:ss tt");
        }

        private void SetActiveButton(Button selectedButton)
        {
            // Reset previous button style
            if (_currentActiveButton != null)
            {
                _currentActiveButton.BackColor = _inactiveButtonColor;
                _currentActiveButton.ForeColor = _inactiveTextColor;
            }

            // Apply active button style
            _currentActiveButton = selectedButton;
            _currentActiveButton.BackColor = _activeButtonColor;
            _currentActiveButton.ForeColor = _activeTextColor;
        }

        #region Navigation Handlers

        public void ShowDashboard()
        {
            SetActiveButton(btnNavDashboard);
            _dashboardView ??= new DashboardViewControl();

            // Wire dashboard quick actions to navigation
            _dashboardView.btnQuickCheckIn.Click -= OnQuickCheckInClick;
            _dashboardView.btnQuickCheckIn.Click += OnQuickCheckInClick;

            _dashboardView.btnQuickNewMember.Click -= OnQuickNewMemberClick;
            _dashboardView.btnQuickNewMember.Click += OnQuickNewMemberClick;

            _dashboardView.btnQuickPayment.Click -= OnQuickPaymentClick;
            _dashboardView.btnQuickPayment.Click += OnQuickPaymentClick;

            _navigationService.NavigateTo(_dashboardView);
            lblStatusReady.Text = "Dashboard active";
        }

        private void OnQuickCheckInClick(object? sender, EventArgs e) => btnNavAttendance.PerformClick();
        private void OnQuickNewMemberClick(object? sender, EventArgs e) => btnNavMembers.PerformClick();
        private void OnQuickPaymentClick(object? sender, EventArgs e) => btnNavPayments.PerformClick();

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnNavMembers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavMembers);
            _membersView ??= new MembersViewControl();
            _navigationService.NavigateTo(_membersView);
            lblStatusReady.Text = "Members Directory active";
        }

        private void btnNavPlans_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavPlans);
            _plansView ??= new PlansViewControl();
            _navigationService.NavigateTo(_plansView);
            lblStatusReady.Text = "Membership Plans active";
        }

        private void btnNavTrainers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavTrainers);
            _trainersView ??= new TrainersViewControl();
            _navigationService.NavigateTo(_trainersView);
            lblStatusReady.Text = "Trainers Catalog active";
        }

        private void btnNavClasses_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavClasses);
            _classesView ??= new ClassesViewControl();
            _navigationService.NavigateTo(_classesView);
            lblStatusReady.Text = "Classes & Bookings active";
        }

        private void btnNavAttendance_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavAttendance);
            _attendanceView ??= new AttendanceViewControl();
            _navigationService.NavigateTo(_attendanceView);
            lblStatusReady.Text = "Daily Attendance Terminal active";
        }

        private void btnNavPayments_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavPayments);
            ShowPlaceholderView("Payments & Billing", "Process subscription fees and review member account balances (Component 10).");
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavReports);
            ShowPlaceholderView("Reports & Analytics", "Financial summaries, membership metrics, and attendance analysis (Component 11).");
        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavUsers);
            ShowPlaceholderView("User Management", "Administrator account credentials and role assignments (Component 12).");
        }

        private void ShowPlaceholderView(string title, string description)
        {
            var pnl = new UserControl
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(32, 24),
                AutoSize = true
            };

            var lblDesc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(34, 60),
                AutoSize = true
            };

            var pnlBox = new Panel
            {
                Location = new Point(34, 100),
                Size = new Size(700, 180),
                BackColor = Color.FromArgb(248, 250, 252),
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblNotice = new Label
            {
                Text = $"ℹ️  {title} module is ready for next development phase.\n\nAll domain models, event brokers, and in-memory data store pipelines are already fully configured in the core architecture.",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(51, 65, 85),
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            pnlBox.Controls.Add(lblNotice);
            pnl.Controls.Add(pnlBox);
            pnl.Controls.Add(lblDesc);
            pnl.Controls.Add(lblTitle);

            _navigationService.NavigateTo(pnl);
            lblStatusReady.Text = $"{title} loaded";
        }

        #endregion

        #region Logout & Form Closing Flow

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to sign out of the administrator portal?",
                "Confirm Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                UserSession.SignOut();
                DialogResult = DialogResult.Retry; // Signals Program.cs to loop back to login form
                Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Retry && e.CloseReason == CloseReason.UserClosing)
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to exit Gym Management System?",
                    "Exit Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion
    }
}
