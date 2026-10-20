namespace GymMembershipSystem.Forms.Dashboard
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTopBar = new System.Windows.Forms.Panel();
            lblClock = new System.Windows.Forms.Label();
            lblCurrentUser = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            lblAppSubtitle = new System.Windows.Forms.Label();
            lblAppTitle = new System.Windows.Forms.Label();
            pnlSidebar = new System.Windows.Forms.Panel();
            pnlNavMenu = new System.Windows.Forms.Panel();
            btnNavUsers = new System.Windows.Forms.Button();
            btnNavReports = new System.Windows.Forms.Button();
            btnNavPayments = new System.Windows.Forms.Button();
            btnNavAttendance = new System.Windows.Forms.Button();
            btnNavClasses = new System.Windows.Forms.Button();
            btnNavTrainers = new System.Windows.Forms.Button();
            btnNavPlans = new System.Windows.Forms.Button();
            btnNavMembers = new System.Windows.Forms.Button();
            btnNavDashboard = new System.Windows.Forms.Button();
            pnlSidebarHeader = new System.Windows.Forms.Panel();
            lblNavHeader = new System.Windows.Forms.Label();
            pnlContentHost = new System.Windows.Forms.Panel();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblStatusReady = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusSpring = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusMode = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusSession = new System.Windows.Forms.ToolStripStatusLabel();
            clockTimer = new System.Windows.Forms.Timer(components);
            pnlTopBar.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlNavMenu.SuspendLayout();
            pnlSidebarHeader.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlTopBar.Controls.Add(lblClock);
            pnlTopBar.Controls.Add(lblCurrentUser);
            pnlTopBar.Controls.Add(btnLogout);
            pnlTopBar.Controls.Add(lblAppSubtitle);
            pnlTopBar.Controls.Add(lblAppTitle);
            pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopBar.Location = new System.Drawing.Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new System.Drawing.Size(1200, 65);
            pnlTopBar.TabIndex = 0;
            // 
            // lblClock
            // 
            lblClock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblClock.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClock.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblClock.Location = new System.Drawing.Point(740, 36);
            lblClock.Name = "lblClock";
            lblClock.Size = new System.Drawing.Size(320, 18);
            lblClock.TabIndex = 4;
            lblClock.Text = "System Clock";
            lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCurrentUser.ForeColor = System.Drawing.Color.White;
            lblCurrentUser.Location = new System.Drawing.Point(740, 14);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new System.Drawing.Size(320, 20);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "👤 Administrator";
            lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLogout.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(1075, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(105, 33);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "🚪 Sign Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblAppSubtitle.Location = new System.Drawing.Point(24, 38);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new System.Drawing.Size(222, 15);
            lblAppSubtitle.TabIndex = 1;
            lblAppSubtitle.Text = "Desktop Administrator Operations Shell";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAppTitle.ForeColor = System.Drawing.Color.White;
            lblAppTitle.Location = new System.Drawing.Point(22, 12);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new System.Drawing.Size(280, 25);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlSidebar.Controls.Add(pnlNavMenu);
            pnlSidebar.Controls.Add(pnlSidebarHeader);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 65);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(240, 655);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlNavMenu
            // 
            pnlNavMenu.AutoScroll = true;
            pnlNavMenu.Controls.Add(btnNavUsers);
            pnlNavMenu.Controls.Add(btnNavReports);
            pnlNavMenu.Controls.Add(btnNavPayments);
            pnlNavMenu.Controls.Add(btnNavAttendance);
            pnlNavMenu.Controls.Add(btnNavClasses);
            pnlNavMenu.Controls.Add(btnNavTrainers);
            pnlNavMenu.Controls.Add(btnNavPlans);
            pnlNavMenu.Controls.Add(btnNavMembers);
            pnlNavMenu.Controls.Add(btnNavDashboard);
            pnlNavMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlNavMenu.Location = new System.Drawing.Point(0, 40);
            pnlNavMenu.Name = "pnlNavMenu";
            pnlNavMenu.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            pnlNavMenu.Size = new System.Drawing.Size(240, 615);
            pnlNavMenu.TabIndex = 1;
            // 
            // btnNavUsers
            // 
            btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavUsers.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavUsers.FlatAppearance.BorderSize = 0;
            btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavUsers.Location = new System.Drawing.Point(10, 370);
            btnNavUsers.Name = "btnNavUsers";
            btnNavUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavUsers.Size = new System.Drawing.Size(220, 45);
            btnNavUsers.TabIndex = 8;
            btnNavUsers.Text = "🔐  User Accounts";
            btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavUsers.UseVisualStyleBackColor = true;
            btnNavUsers.Click += btnNavUsers_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavReports.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavReports.FlatAppearance.BorderSize = 0;
            btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavReports.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavReports.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavReports.Location = new System.Drawing.Point(10, 325);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavReports.Size = new System.Drawing.Size(220, 45);
            btnNavReports.TabIndex = 7;
            btnNavReports.Text = "📈  Reports & Analytics";
            btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavReports.UseVisualStyleBackColor = true;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // btnNavPayments
            // 
            btnNavPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavPayments.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavPayments.FlatAppearance.BorderSize = 0;
            btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavPayments.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavPayments.Location = new System.Drawing.Point(10, 280);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavPayments.Size = new System.Drawing.Size(220, 45);
            btnNavPayments.TabIndex = 6;
            btnNavPayments.Text = "💳  Payments & Billing";
            btnNavPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavPayments.UseVisualStyleBackColor = true;
            btnNavPayments.Click += btnNavPayments_Click;
            // 
            // btnNavAttendance
            // 
            btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavAttendance.FlatAppearance.BorderSize = 0;
            btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavAttendance.Location = new System.Drawing.Point(10, 235);
            btnNavAttendance.Name = "btnNavAttendance";
            btnNavAttendance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavAttendance.Size = new System.Drawing.Size(220, 45);
            btnNavAttendance.TabIndex = 5;
            btnNavAttendance.Text = "⏱️  Daily Attendance";
            btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavAttendance.UseVisualStyleBackColor = true;
            btnNavAttendance.Click += btnNavAttendance_Click;
            // 
            // btnNavClasses
            // 
            btnNavClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavClasses.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavClasses.FlatAppearance.BorderSize = 0;
            btnNavClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavClasses.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavClasses.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavClasses.Location = new System.Drawing.Point(10, 190);
            btnNavClasses.Name = "btnNavClasses";
            btnNavClasses.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavClasses.Size = new System.Drawing.Size(220, 45);
            btnNavClasses.TabIndex = 4;
            btnNavClasses.Text = "📅  Classes & Bookings";
            btnNavClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavClasses.UseVisualStyleBackColor = true;
            btnNavClasses.Click += btnNavClasses_Click;
            // 
            // btnNavTrainers
            // 
            btnNavTrainers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavTrainers.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavTrainers.FlatAppearance.BorderSize = 0;
            btnNavTrainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavTrainers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavTrainers.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavTrainers.Location = new System.Drawing.Point(10, 145);
            btnNavTrainers.Name = "btnNavTrainers";
            btnNavTrainers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavTrainers.Size = new System.Drawing.Size(220, 45);
            btnNavTrainers.TabIndex = 3;
            btnNavTrainers.Text = "🏋️  Trainers Catalog";
            btnNavTrainers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavTrainers.UseVisualStyleBackColor = true;
            btnNavTrainers.Click += btnNavTrainers_Click;
            // 
            // btnNavPlans
            // 
            btnNavPlans.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavPlans.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavPlans.FlatAppearance.BorderSize = 0;
            btnNavPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavPlans.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavPlans.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavPlans.Location = new System.Drawing.Point(10, 100);
            btnNavPlans.Name = "btnNavPlans";
            btnNavPlans.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavPlans.Size = new System.Drawing.Size(220, 45);
            btnNavPlans.TabIndex = 2;
            btnNavPlans.Text = "📋  Membership Plans";
            btnNavPlans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavPlans.UseVisualStyleBackColor = true;
            btnNavPlans.Click += btnNavPlans_Click;
            // 
            // btnNavMembers
            // 
            btnNavMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavMembers.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavMembers.FlatAppearance.BorderSize = 0;
            btnNavMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavMembers.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavMembers.Location = new System.Drawing.Point(10, 55);
            btnNavMembers.Name = "btnNavMembers";
            btnNavMembers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavMembers.Size = new System.Drawing.Size(220, 45);
            btnNavMembers.TabIndex = 1;
            btnNavMembers.Text = "👥  Members Directory";
            btnNavMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavMembers.UseVisualStyleBackColor = true;
            btnNavMembers.Click += btnNavMembers_Click;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNavDashboard.ForeColor = System.Drawing.Color.White;
            btnNavDashboard.Location = new System.Drawing.Point(10, 10);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavDashboard.Size = new System.Drawing.Size(220, 45);
            btnNavDashboard.TabIndex = 0;
            btnNavDashboard.Text = "📊  Dashboard";
            btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = true;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // pnlSidebarHeader
            // 
            pnlSidebarHeader.Controls.Add(lblNavHeader);
            pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            pnlSidebarHeader.Name = "pnlSidebarHeader";
            pnlSidebarHeader.Padding = new System.Windows.Forms.Padding(18, 14, 0, 0);
            pnlSidebarHeader.Size = new System.Drawing.Size(240, 40);
            pnlSidebarHeader.TabIndex = 0;
            // 
            // lblNavHeader
            // 
            lblNavHeader.AutoSize = true;
            lblNavHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNavHeader.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblNavHeader.Location = new System.Drawing.Point(16, 14);
            lblNavHeader.Name = "lblNavHeader";
            lblNavHeader.Size = new System.Drawing.Size(77, 13);
            lblNavHeader.TabIndex = 0;
            lblNavHeader.Text = "NAVIGATION";
            // 
            // pnlContentHost
            // 
            pnlContentHost.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlContentHost.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContentHost.Location = new System.Drawing.Point(240, 65);
            pnlContentHost.Name = "pnlContentHost";
            pnlContentHost.Size = new System.Drawing.Size(960, 633);
            pnlContentHost.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.Color.White;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatusReady, lblStatusSpring, lblStatusMode, lblStatusSession });
            statusStrip.Location = new System.Drawing.Point(240, 698);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(960, 22);
            statusStrip.TabIndex = 3;
            // 
            // lblStatusReady
            // 
            lblStatusReady.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblStatusReady.Name = "lblStatusReady";
            lblStatusReady.Size = new System.Drawing.Size(39, 17);
            lblStatusReady.Text = "Ready";
            // 
            // lblStatusSpring
            // 
            lblStatusSpring.Name = "lblStatusSpring";
            lblStatusSpring.Size = new System.Drawing.Size(657, 17);
            lblStatusSpring.Spring = true;
            // 
            // lblStatusMode
            // 
            lblStatusMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStatusMode.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblStatusMode.Name = "lblStatusMode";
            lblStatusMode.Size = new System.Drawing.Size(209, 17);
            lblStatusMode.Text = "Storage: Phase 1 (In-Memory Store)";
            // 
            // lblStatusSession
            // 
            lblStatusSession.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblStatusSession.Name = "lblStatusSession";
            lblStatusSession.Size = new System.Drawing.Size(40, 17);
            lblStatusSession.Text = "Online";
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlContentHost);
            Controls.Add(statusStrip);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlTopBar);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MinimumSize = new System.Drawing.Size(1100, 700);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gym Management System - Administrator Portal";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlNavMenu.ResumeLayout(false);
            pnlSidebarHeader.ResumeLayout(false);
            pnlSidebarHeader.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblNavHeader;
        private System.Windows.Forms.Panel pnlNavMenu;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavMembers;
        private System.Windows.Forms.Button btnNavPlans;
        private System.Windows.Forms.Button btnNavTrainers;
        private System.Windows.Forms.Button btnNavClasses;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavPayments;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Panel pnlContentHost;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusReady;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSpring;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMode;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSession;
        private System.Windows.Forms.Timer clockTimer;
    }
}
