namespace GymMembershipSystem.Forms.Dashboard
{
    partial class DashboardViewControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                UnsubscribeEvents();
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            lblHeader = new System.Windows.Forms.Label();
            tlpCards = new System.Windows.Forms.TableLayoutPanel();
            pnlCard1 = new System.Windows.Forms.Panel();
            lblTotalMembersValue = new System.Windows.Forms.Label();
            lblTotalMembersTitle = new System.Windows.Forms.Label();
            pnlCard2 = new System.Windows.Forms.Panel();
            lblActiveMembersValue = new System.Windows.Forms.Label();
            lblActiveMembersTitle = new System.Windows.Forms.Label();
            pnlCard3 = new System.Windows.Forms.Panel();
            lblTodayAttendanceValue = new System.Windows.Forms.Label();
            lblTodayAttendanceTitle = new System.Windows.Forms.Label();
            pnlCard4 = new System.Windows.Forms.Panel();
            lblTotalRevenueValue = new System.Windows.Forms.Label();
            lblTotalRevenueTitle = new System.Windows.Forms.Label();
            pnlQuickActions = new System.Windows.Forms.Panel();
            lblQuickActions = new System.Windows.Forms.Label();
            flpQuickActions = new System.Windows.Forms.FlowLayoutPanel();
            btnQuickCheckIn = new System.Windows.Forms.Button();
            btnQuickNewMember = new System.Windows.Forms.Button();
            btnQuickPayment = new System.Windows.Forms.Button();
            btnQuickRefresh = new System.Windows.Forms.Button();
            pnlRecentActivity = new System.Windows.Forms.Panel();
            lblActivityTitle = new System.Windows.Forms.Label();
            lstActivity = new System.Windows.Forms.ListBox();
            pnlHeader.SuspendLayout();
            tlpCards.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            pnlQuickActions.SuspendLayout();
            flpQuickActions.SuspendLayout();
            pnlRecentActivity.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(952, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new System.Drawing.Point(2, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(433, 17);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Real-time system overview and live event metrics across the gym network.";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(262, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Operations Dashboard";
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.Controls.Add(pnlCard1, 0, 0);
            tlpCards.Controls.Add(pnlCard2, 1, 0);
            tlpCards.Controls.Add(pnlCard3, 2, 0);
            tlpCards.Controls.Add(pnlCard4, 3, 0);
            tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            tlpCards.Location = new System.Drawing.Point(24, 80);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCards.Size = new System.Drawing.Size(952, 120);
            tlpCards.TabIndex = 1;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(lblTotalMembersValue);
            pnlCard1.Controls.Add(lblTotalMembersTitle);
            pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCard1.Location = new System.Drawing.Point(3, 3);
            pnlCard1.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Padding = new System.Windows.Forms.Padding(16);
            pnlCard1.Size = new System.Drawing.Size(227, 114);
            pnlCard1.TabIndex = 0;
            // 
            // lblTotalMembersValue
            // 
            lblTotalMembersValue.AutoSize = true;
            lblTotalMembersValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalMembersValue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblTotalMembersValue.Location = new System.Drawing.Point(12, 42);
            lblTotalMembersValue.Name = "lblTotalMembersValue";
            lblTotalMembersValue.Size = new System.Drawing.Size(38, 45);
            lblTotalMembersValue.TabIndex = 1;
            lblTotalMembersValue.Text = "0";
            // 
            // lblTotalMembersTitle
            // 
            lblTotalMembersTitle.AutoSize = true;
            lblTotalMembersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalMembersTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            lblTotalMembersTitle.Location = new System.Drawing.Point(14, 14);
            lblTotalMembersTitle.Name = "lblTotalMembersTitle";
            lblTotalMembersTitle.Size = new System.Drawing.Size(117, 17);
            lblTotalMembersTitle.TabIndex = 0;
            lblTotalMembersTitle.Text = "TOTAL MEMBERS";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(lblActiveMembersValue);
            pnlCard2.Controls.Add(lblActiveMembersTitle);
            pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCard2.Location = new System.Drawing.Point(241, 3);
            pnlCard2.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Padding = new System.Windows.Forms.Padding(16);
            pnlCard2.Size = new System.Drawing.Size(227, 114);
            pnlCard2.TabIndex = 1;
            // 
            // lblActiveMembersValue
            // 
            lblActiveMembersValue.AutoSize = true;
            lblActiveMembersValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActiveMembersValue.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblActiveMembersValue.Location = new System.Drawing.Point(12, 42);
            lblActiveMembersValue.Name = "lblActiveMembersValue";
            lblActiveMembersValue.Size = new System.Drawing.Size(38, 45);
            lblActiveMembersValue.TabIndex = 1;
            lblActiveMembersValue.Text = "0";
            // 
            // lblActiveMembersTitle
            // 
            lblActiveMembersTitle.AutoSize = true;
            lblActiveMembersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActiveMembersTitle.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70);
            lblActiveMembersTitle.Location = new System.Drawing.Point(14, 14);
            lblActiveMembersTitle.Name = "lblActiveMembersTitle";
            lblActiveMembersTitle.Size = new System.Drawing.Size(124, 17);
            lblActiveMembersTitle.TabIndex = 0;
            lblActiveMembersTitle.Text = "ACTIVE MEMBERS";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = System.Drawing.Color.FromArgb(254, 243, 199);
            pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(lblTodayAttendanceValue);
            pnlCard3.Controls.Add(lblTodayAttendanceTitle);
            pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCard3.Location = new System.Drawing.Point(479, 3);
            pnlCard3.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Padding = new System.Windows.Forms.Padding(16);
            pnlCard3.Size = new System.Drawing.Size(227, 114);
            pnlCard3.TabIndex = 2;
            // 
            // lblTodayAttendanceValue
            // 
            lblTodayAttendanceValue.AutoSize = true;
            lblTodayAttendanceValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTodayAttendanceValue.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            lblTodayAttendanceValue.Location = new System.Drawing.Point(12, 42);
            lblTodayAttendanceValue.Name = "lblTodayAttendanceValue";
            lblTodayAttendanceValue.Size = new System.Drawing.Size(38, 45);
            lblTodayAttendanceValue.TabIndex = 1;
            lblTodayAttendanceValue.Text = "0";
            // 
            // lblTodayAttendanceTitle
            // 
            lblTodayAttendanceTitle.AutoSize = true;
            lblTodayAttendanceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTodayAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14);
            lblTodayAttendanceTitle.Location = new System.Drawing.Point(14, 14);
            lblTodayAttendanceTitle.Name = "lblTodayAttendanceTitle";
            lblTodayAttendanceTitle.Size = new System.Drawing.Size(148, 17);
            lblTodayAttendanceTitle.TabIndex = 0;
            lblTodayAttendanceTitle.Text = "TODAY'S ATTENDANCE";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = System.Drawing.Color.FromArgb(243, 232, 255);
            pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard4.Controls.Add(lblTotalRevenueValue);
            pnlCard4.Controls.Add(lblTotalRevenueTitle);
            pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCard4.Location = new System.Drawing.Point(717, 3);
            pnlCard4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Padding = new System.Windows.Forms.Padding(16);
            pnlCard4.Size = new System.Drawing.Size(232, 114);
            pnlCard4.TabIndex = 3;
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalRevenueValue.ForeColor = System.Drawing.Color.FromArgb(124, 58, 237);
            lblTotalRevenueValue.Location = new System.Drawing.Point(12, 42);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new System.Drawing.Size(96, 45);
            lblTotalRevenueValue.TabIndex = 1;
            lblTotalRevenueValue.Text = "$0.00";
            // 
            // lblTotalRevenueTitle
            // 
            lblTotalRevenueTitle.AutoSize = true;
            lblTotalRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182);
            lblTotalRevenueTitle.Location = new System.Drawing.Point(14, 14);
            lblTotalRevenueTitle.Name = "lblTotalRevenueTitle";
            lblTotalRevenueTitle.Size = new System.Drawing.Size(117, 17);
            lblTotalRevenueTitle.TabIndex = 0;
            lblTotalRevenueTitle.Text = "TOTAL PAYMENTS";
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.Controls.Add(flpQuickActions);
            pnlQuickActions.Controls.Add(lblQuickActions);
            pnlQuickActions.Dock = System.Windows.Forms.DockStyle.Top;
            pnlQuickActions.Location = new System.Drawing.Point(24, 200);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            pnlQuickActions.Size = new System.Drawing.Size(952, 95);
            pnlQuickActions.TabIndex = 2;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Dock = System.Windows.Forms.DockStyle.Top;
            lblQuickActions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQuickActions.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblQuickActions.Location = new System.Drawing.Point(0, 20);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new System.Drawing.Size(103, 20);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // flpQuickActions
            // 
            flpQuickActions.Controls.Add(btnQuickCheckIn);
            flpQuickActions.Controls.Add(btnQuickNewMember);
            flpQuickActions.Controls.Add(btnQuickPayment);
            flpQuickActions.Controls.Add(btnQuickRefresh);
            flpQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flpQuickActions.Location = new System.Drawing.Point(0, 40);
            flpQuickActions.Name = "flpQuickActions";
            flpQuickActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            flpQuickActions.Size = new System.Drawing.Size(952, 55);
            flpQuickActions.TabIndex = 1;
            // 
            // btnQuickCheckIn
            // 
            btnQuickCheckIn.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnQuickCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuickCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnQuickCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuickCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuickCheckIn.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnQuickCheckIn.Location = new System.Drawing.Point(0, 8);
            btnQuickCheckIn.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            btnQuickCheckIn.Name = "btnQuickCheckIn";
            btnQuickCheckIn.Size = new System.Drawing.Size(160, 36);
            btnQuickCheckIn.TabIndex = 0;
            btnQuickCheckIn.Text = "⚡ Quick Check-in";
            btnQuickCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnQuickNewMember
            // 
            btnQuickNewMember.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnQuickNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuickNewMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnQuickNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuickNewMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuickNewMember.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnQuickNewMember.Location = new System.Drawing.Point(170, 8);
            btnQuickNewMember.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            btnQuickNewMember.Name = "btnQuickNewMember";
            btnQuickNewMember.Size = new System.Drawing.Size(160, 36);
            btnQuickNewMember.TabIndex = 1;
            btnQuickNewMember.Text = "➕ New Member";
            btnQuickNewMember.UseVisualStyleBackColor = false;
            // 
            // btnQuickPayment
            // 
            btnQuickPayment.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnQuickPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuickPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnQuickPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuickPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuickPayment.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnQuickPayment.Location = new System.Drawing.Point(340, 8);
            btnQuickPayment.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            btnQuickPayment.Name = "btnQuickPayment";
            btnQuickPayment.Size = new System.Drawing.Size(160, 36);
            btnQuickPayment.TabIndex = 2;
            btnQuickPayment.Text = "💳 Record Payment";
            btnQuickPayment.UseVisualStyleBackColor = false;
            // 
            // btnQuickRefresh
            // 
            btnQuickRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnQuickRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuickRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnQuickRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuickRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuickRefresh.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnQuickRefresh.Location = new System.Drawing.Point(510, 8);
            btnQuickRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            btnQuickRefresh.Name = "btnQuickRefresh";
            btnQuickRefresh.Size = new System.Drawing.Size(120, 36);
            btnQuickRefresh.TabIndex = 3;
            btnQuickRefresh.Text = "🔄 Refresh";
            btnQuickRefresh.UseVisualStyleBackColor = false;
            btnQuickRefresh.Click += btnQuickRefresh_Click;
            // 
            // pnlRecentActivity
            // 
            pnlRecentActivity.Controls.Add(lstActivity);
            pnlRecentActivity.Controls.Add(lblActivityTitle);
            pnlRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRecentActivity.Location = new System.Drawing.Point(24, 295);
            pnlRecentActivity.Name = "pnlRecentActivity";
            pnlRecentActivity.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            pnlRecentActivity.Size = new System.Drawing.Size(952, 265);
            pnlRecentActivity.TabIndex = 3;
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.AutoSize = true;
            lblActivityTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblActivityTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblActivityTitle.Location = new System.Drawing.Point(0, 16);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new System.Drawing.Size(193, 20);
            lblActivityTitle.TabIndex = 0;
            lblActivityTitle.Text = "Live System Event Activity";
            // 
            // lstActivity
            // 
            lstActivity.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            lstActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            lstActivity.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstActivity.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lstActivity.ItemHeight = 15;
            lstActivity.Location = new System.Drawing.Point(0, 36);
            lstActivity.Name = "lstActivity";
            lstActivity.Size = new System.Drawing.Size(952, 213);
            lstActivity.TabIndex = 1;
            // 
            // DashboardViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(pnlRecentActivity);
            Controls.Add(pnlQuickActions);
            Controls.Add(tlpCards);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "DashboardViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1000, 580);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpCards.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            pnlQuickActions.ResumeLayout(false);
            pnlQuickActions.PerformLayout();
            flpQuickActions.ResumeLayout(false);
            pnlRecentActivity.ResumeLayout(false);
            pnlRecentActivity.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTotalMembersValue;
        private System.Windows.Forms.Label lblTotalMembersTitle;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblActiveMembersValue;
        private System.Windows.Forms.Label lblActiveMembersTitle;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblTodayAttendanceValue;
        private System.Windows.Forms.Label lblTodayAttendanceTitle;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalRevenueTitle;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.FlowLayoutPanel flpQuickActions;
        public System.Windows.Forms.Button btnQuickCheckIn;
        public System.Windows.Forms.Button btnQuickNewMember;
        public System.Windows.Forms.Button btnQuickPayment;
        private System.Windows.Forms.Button btnQuickRefresh;
        private System.Windows.Forms.Panel pnlRecentActivity;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.ListBox lstActivity;
    }
}
