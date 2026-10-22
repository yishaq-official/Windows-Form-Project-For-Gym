namespace GymMembershipSystem.Forms.Reports
{
    partial class ReportsViewControl
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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();

            pnlHeader = new System.Windows.Forms.Panel();
            flpHeaderActions = new System.Windows.Forms.FlowLayoutPanel();
            btnExportCsv = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();

            pnlMetrics = new System.Windows.Forms.Panel();
            pnlMetricMembers = new System.Windows.Forms.Panel();
            lblMembersSub = new System.Windows.Forms.Label();
            lblMembersVal = new System.Windows.Forms.Label();
            lblMembersTitle = new System.Windows.Forms.Label();

            pnlMetricRevenue = new System.Windows.Forms.Panel();
            lblRevenueSub = new System.Windows.Forms.Label();
            lblRevenueVal = new System.Windows.Forms.Label();
            lblRevenueTitle = new System.Windows.Forms.Label();

            pnlMetricAttendance = new System.Windows.Forms.Panel();
            lblAttendanceSub = new System.Windows.Forms.Label();
            lblAttendanceVal = new System.Windows.Forms.Label();
            lblAttendanceTitle = new System.Windows.Forms.Label();

            pnlMetricOutstanding = new System.Windows.Forms.Panel();
            lblOutstandingSub = new System.Windows.Forms.Label();
            lblOutstandingVal = new System.Windows.Forms.Label();
            lblOutstandingTitle = new System.Windows.Forms.Label();

            tabReports = new System.Windows.Forms.TabControl();
            tabFillRates = new System.Windows.Forms.TabPage();
            dgvClassFillRates = new System.Windows.Forms.DataGridView();
            colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFillRate = new System.Windows.Forms.DataGridViewTextBoxColumn();

            tabMonthlyRevenue = new System.Windows.Forms.TabPage();
            dgvMonthlyRevenue = new System.Windows.Forms.DataGridView();
            colRevYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRevMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRevTransactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRevTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            tabAttendance = new System.Windows.Forms.TabPage();
            dgvAttendance = new System.Windows.Forms.DataGridView();
            colAttDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAttDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAttVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAttUnique = new System.Windows.Forms.DataGridViewTextBoxColumn();

            tabMemberStatus = new System.Windows.Forms.TabPage();
            pnlMemberFilter = new System.Windows.Forms.Panel();
            cboMemberFilter = new System.Windows.Forms.ComboBox();
            lblMemberFilter = new System.Windows.Forms.Label();
            dgvMemberStatus = new System.Windows.Forms.DataGridView();
            colMemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            flpHeaderActions.SuspendLayout();
            pnlMetrics.SuspendLayout();
            pnlMetricMembers.SuspendLayout();
            pnlMetricRevenue.SuspendLayout();
            pnlMetricAttendance.SuspendLayout();
            pnlMetricOutstanding.SuspendLayout();
            tabReports.SuspendLayout();
            tabFillRates.SuspendLayout();
            tabMonthlyRevenue.SuspendLayout();
            tabAttendance.SuspendLayout();
            tabMemberStatus.SuspendLayout();
            pnlMemberFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassFillRates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMemberStatus).BeginInit();
            SuspendLayout();

            //
            // dgv common styles
            //
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            dgvDefaultStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvDefaultStyle.BackColor = System.Drawing.Color.White;
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvDefaultStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvDefaultStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpHeaderActions);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1032, 65);
            pnlHeader.TabIndex = 0;

            // 
            // flpHeaderActions
            // 
            flpHeaderActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            flpHeaderActions.Controls.Add(btnExportCsv);
            flpHeaderActions.Controls.Add(btnRefresh);
            flpHeaderActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpHeaderActions.Location = new System.Drawing.Point(680, 10);
            flpHeaderActions.Name = "flpHeaderActions";
            flpHeaderActions.Size = new System.Drawing.Size(352, 45);
            flpHeaderActions.TabIndex = 2;

            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportCsv.FlatAppearance.BorderSize = 0;
            btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportCsv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExportCsv.ForeColor = System.Drawing.Color.White;
            btnExportCsv.Location = new System.Drawing.Point(212, 3);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new System.Drawing.Size(137, 34);
            btnExportCsv.TabIndex = 0;
            btnExportCsv.Text = "📥 Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;

            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new System.Drawing.Point(100, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(106, 34);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new System.Drawing.Point(0, 36);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(560, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Operational metrics, capacity fill rates, monthly revenue, and footfall attendance analytics";

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(325, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports & Business Analytics";

            // 
            // pnlMetrics
            // 
            pnlMetrics.Controls.Add(pnlMetricOutstanding);
            pnlMetrics.Controls.Add(pnlMetricAttendance);
            pnlMetrics.Controls.Add(pnlMetricRevenue);
            pnlMetrics.Controls.Add(pnlMetricMembers);
            pnlMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            pnlMetrics.Location = new System.Drawing.Point(24, 85);
            pnlMetrics.Name = "pnlMetrics";
            pnlMetrics.Padding = new System.Windows.Forms.Padding(0, 4, 0, 12);
            pnlMetrics.Size = new System.Drawing.Size(1032, 86);
            pnlMetrics.TabIndex = 1;

            // 
            // pnlMetricMembers
            // 
            pnlMetricMembers.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            pnlMetricMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricMembers.Controls.Add(lblMembersSub);
            pnlMetricMembers.Controls.Add(lblMembersVal);
            pnlMetricMembers.Controls.Add(lblMembersTitle);
            pnlMetricMembers.Location = new System.Drawing.Point(0, 4);
            pnlMetricMembers.Name = "pnlMetricMembers";
            pnlMetricMembers.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            pnlMetricMembers.Size = new System.Drawing.Size(240, 72);
            pnlMetricMembers.TabIndex = 0;

            // 
            // lblMembersTitle
            // 
            lblMembersTitle.AutoSize = true;
            lblMembersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMembersTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblMembersTitle.Location = new System.Drawing.Point(10, 6);
            lblMembersTitle.Name = "lblMembersTitle";
            lblMembersTitle.Size = new System.Drawing.Size(97, 13);
            lblMembersTitle.TabIndex = 0;
            lblMembersTitle.Text = "TOTAL MEMBERS";

            // 
            // lblMembersVal
            // 
            lblMembersVal.AutoSize = true;
            lblMembersVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMembersVal.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
            lblMembersVal.Location = new System.Drawing.Point(10, 22);
            lblMembersVal.Name = "lblMembersVal";
            lblMembersVal.Size = new System.Drawing.Size(24, 28);
            lblMembersVal.TabIndex = 1;
            lblMembersVal.Text = "0";

            // 
            // lblMembersSub
            // 
            lblMembersSub.AutoSize = true;
            lblMembersSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMembersSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblMembersSub.Location = new System.Drawing.Point(10, 50);
            lblMembersSub.Name = "lblMembersSub";
            lblMembersSub.Size = new System.Drawing.Size(107, 13);
            lblMembersSub.TabIndex = 2;
            lblMembersSub.Text = "Active: 0 | Expired: 0";

            // 
            // pnlMetricRevenue
            // 
            pnlMetricRevenue.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            pnlMetricRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricRevenue.Controls.Add(lblRevenueSub);
            pnlMetricRevenue.Controls.Add(lblRevenueVal);
            pnlMetricRevenue.Controls.Add(lblRevenueTitle);
            pnlMetricRevenue.Location = new System.Drawing.Point(252, 4);
            pnlMetricRevenue.Name = "pnlMetricRevenue";
            pnlMetricRevenue.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            pnlMetricRevenue.Size = new System.Drawing.Size(240, 72);
            pnlMetricRevenue.TabIndex = 1;

            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblRevenueTitle.Location = new System.Drawing.Point(10, 6);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new System.Drawing.Size(108, 13);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "MONTHLY REVENUE";

            // 
            // lblRevenueVal
            // 
            lblRevenueVal.AutoSize = true;
            lblRevenueVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRevenueVal.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblRevenueVal.Location = new System.Drawing.Point(10, 22);
            lblRevenueVal.Name = "lblRevenueVal";
            lblRevenueVal.Size = new System.Drawing.Size(65, 28);
            lblRevenueVal.TabIndex = 1;
            lblRevenueVal.Text = "$0.00";

            // 
            // lblRevenueSub
            // 
            lblRevenueSub.AutoSize = true;
            lblRevenueSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRevenueSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblRevenueSub.Location = new System.Drawing.Point(10, 50);
            lblRevenueSub.Name = "lblRevenueSub";
            lblRevenueSub.Size = new System.Drawing.Size(126, 13);
            lblRevenueSub.TabIndex = 2;
            lblRevenueSub.Text = "Current calendar month";

            // 
            // pnlMetricAttendance
            // 
            pnlMetricAttendance.BackColor = System.Drawing.Color.FromArgb(255, 251, 235);
            pnlMetricAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricAttendance.Controls.Add(lblAttendanceSub);
            pnlMetricAttendance.Controls.Add(lblAttendanceVal);
            pnlMetricAttendance.Controls.Add(lblAttendanceTitle);
            pnlMetricAttendance.Location = new System.Drawing.Point(504, 4);
            pnlMetricAttendance.Name = "pnlMetricAttendance";
            pnlMetricAttendance.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            pnlMetricAttendance.Size = new System.Drawing.Size(240, 72);
            pnlMetricAttendance.TabIndex = 2;

            // 
            // lblAttendanceTitle
            // 
            lblAttendanceTitle.AutoSize = true;
            lblAttendanceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblAttendanceTitle.Location = new System.Drawing.Point(10, 6);
            lblAttendanceTitle.Name = "lblAttendanceTitle";
            lblAttendanceTitle.Size = new System.Drawing.Size(107, 13);
            lblAttendanceTitle.TabIndex = 0;
            lblAttendanceTitle.Text = "TODAY'S CHECK-INS";

            // 
            // lblAttendanceVal
            // 
            lblAttendanceVal.AutoSize = true;
            lblAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            lblAttendanceVal.Location = new System.Drawing.Point(10, 22);
            lblAttendanceVal.Name = "lblAttendanceVal";
            lblAttendanceVal.Size = new System.Drawing.Size(24, 28);
            lblAttendanceVal.TabIndex = 1;
            lblAttendanceVal.Text = "0";

            // 
            // lblAttendanceSub
            // 
            lblAttendanceSub.AutoSize = true;
            lblAttendanceSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAttendanceSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblAttendanceSub.Location = new System.Drawing.Point(10, 50);
            lblAttendanceSub.Name = "lblAttendanceSub";
            lblAttendanceSub.Size = new System.Drawing.Size(99, 13);
            lblAttendanceSub.TabIndex = 2;
            lblAttendanceSub.Text = "Total visits logged";

            // 
            // pnlMetricOutstanding
            // 
            pnlMetricOutstanding.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            pnlMetricOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricOutstanding.Controls.Add(lblOutstandingSub);
            pnlMetricOutstanding.Controls.Add(lblOutstandingVal);
            pnlMetricOutstanding.Controls.Add(lblOutstandingTitle);
            pnlMetricOutstanding.Location = new System.Drawing.Point(756, 4);
            pnlMetricOutstanding.Name = "pnlMetricOutstanding";
            pnlMetricOutstanding.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            pnlMetricOutstanding.Size = new System.Drawing.Size(240, 72);
            pnlMetricOutstanding.TabIndex = 3;

            // 
            // lblOutstandingTitle
            // 
            lblOutstandingTitle.AutoSize = true;
            lblOutstandingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOutstandingTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblOutstandingTitle.Location = new System.Drawing.Point(10, 6);
            lblOutstandingTitle.Name = "lblOutstandingTitle";
            lblOutstandingTitle.Size = new System.Drawing.Size(147, 13);
            lblOutstandingTitle.TabIndex = 0;
            lblOutstandingTitle.Text = "OUTSTANDING BALANCES";

            // 
            // lblOutstandingVal
            // 
            lblOutstandingVal.AutoSize = true;
            lblOutstandingVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOutstandingVal.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            lblOutstandingVal.Location = new System.Drawing.Point(10, 22);
            lblOutstandingVal.Name = "lblOutstandingVal";
            lblOutstandingVal.Size = new System.Drawing.Size(65, 28);
            lblOutstandingVal.TabIndex = 1;
            lblOutstandingVal.Text = "$0.00";

            // 
            // lblOutstandingSub
            // 
            lblOutstandingSub.AutoSize = true;
            lblOutstandingSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOutstandingSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblOutstandingSub.Location = new System.Drawing.Point(10, 50);
            lblOutstandingSub.Name = "lblOutstandingSub";
            lblOutstandingSub.Size = new System.Drawing.Size(117, 13);
            lblOutstandingSub.TabIndex = 2;
            lblOutstandingSub.Text = "Unpaid subscriptions";

            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabFillRates);
            tabReports.Controls.Add(tabMonthlyRevenue);
            tabReports.Controls.Add(tabAttendance);
            tabReports.Controls.Add(tabMemberStatus);
            tabReports.Dock = System.Windows.Forms.DockStyle.Fill;
            tabReports.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabReports.Location = new System.Drawing.Point(24, 171);
            tabReports.Name = "tabReports";
            tabReports.Padding = new System.Drawing.Point(14, 8);
            tabReports.SelectedIndex = 0;
            tabReports.Size = new System.Drawing.Size(1032, 529);
            tabReports.TabIndex = 2;

            // 
            // tabFillRates
            // 
            tabFillRates.BackColor = System.Drawing.Color.White;
            tabFillRates.Controls.Add(dgvClassFillRates);
            tabFillRates.Location = new System.Drawing.Point(4, 38);
            tabFillRates.Name = "tabFillRates";
            tabFillRates.Padding = new System.Windows.Forms.Padding(12);
            tabFillRates.Size = new System.Drawing.Size(1024, 487);
            tabFillRates.TabIndex = 0;
            tabFillRates.Text = "🏋️ Class Fill Rates";

            // 
            // dgvClassFillRates
            // 
            dgvClassFillRates.AllowUserToAddRows = false;
            dgvClassFillRates.AllowUserToDeleteRows = false;
            dgvClassFillRates.AllowUserToResizeRows = false;
            dgvClassFillRates.BackgroundColor = System.Drawing.Color.White;
            dgvClassFillRates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvClassFillRates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClassFillRates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvClassFillRates.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvClassFillRates.ColumnHeadersHeight = 38;
            dgvClassFillRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClassFillRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colClassName,
                colTrainer,
                colSchedule,
                colCapacity,
                colBooked,
                colAvailable,
                colFillRate
            });
            dgvClassFillRates.DefaultCellStyle = dgvDefaultStyle;
            dgvClassFillRates.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvClassFillRates.EnableHeadersVisualStyles = false;
            dgvClassFillRates.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvClassFillRates.Location = new System.Drawing.Point(12, 12);
            dgvClassFillRates.MultiSelect = false;
            dgvClassFillRates.Name = "dgvClassFillRates";
            dgvClassFillRates.ReadOnly = true;
            dgvClassFillRates.RowHeadersVisible = false;
            dgvClassFillRates.RowTemplate.Height = 36;
            dgvClassFillRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvClassFillRates.Size = new System.Drawing.Size(1000, 463);
            dgvClassFillRates.TabIndex = 0;

            // 
            // colClassName
            // 
            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "Class Name";
            colClassName.MinimumWidth = 140;
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            colClassName.Width = 200;

            // 
            // colTrainer
            // 
            colTrainer.DataPropertyName = "TrainerName";
            colTrainer.HeaderText = "Trainer";
            colTrainer.MinimumWidth = 120;
            colTrainer.Name = "colTrainer";
            colTrainer.ReadOnly = true;
            colTrainer.Width = 180;

            // 
            // colSchedule
            // 
            colSchedule.DataPropertyName = "ScheduleDisplay";
            colSchedule.HeaderText = "Weekly Schedule";
            colSchedule.MinimumWidth = 140;
            colSchedule.Name = "colSchedule";
            colSchedule.ReadOnly = true;
            colSchedule.Width = 180;

            // 
            // colCapacity
            // 
            colCapacity.DataPropertyName = "Capacity";
            colCapacity.HeaderText = "Capacity";
            colCapacity.MinimumWidth = 80;
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            colCapacity.Width = 90;

            // 
            // colBooked
            // 
            colBooked.DataPropertyName = "BookedCount";
            colBooked.HeaderText = "Booked";
            colBooked.MinimumWidth = 80;
            colBooked.Name = "colBooked";
            colBooked.ReadOnly = true;
            colBooked.Width = 90;

            // 
            // colAvailable
            // 
            colAvailable.DataPropertyName = "AvailableSpots";
            colAvailable.HeaderText = "Available";
            colAvailable.MinimumWidth = 80;
            colAvailable.Name = "colAvailable";
            colAvailable.ReadOnly = true;
            colAvailable.Width = 90;

            // 
            // colFillRate
            // 
            colFillRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colFillRate.DataPropertyName = "FillRateDisplay";
            colFillRate.HeaderText = "Fill Rate %";
            colFillRate.MinimumWidth = 100;
            colFillRate.Name = "colFillRate";
            colFillRate.ReadOnly = true;

            // 
            // tabMonthlyRevenue
            // 
            tabMonthlyRevenue.BackColor = System.Drawing.Color.White;
            tabMonthlyRevenue.Controls.Add(dgvMonthlyRevenue);
            tabMonthlyRevenue.Location = new System.Drawing.Point(4, 38);
            tabMonthlyRevenue.Name = "tabMonthlyRevenue";
            tabMonthlyRevenue.Padding = new System.Windows.Forms.Padding(12);
            tabMonthlyRevenue.Size = new System.Drawing.Size(1024, 487);
            tabMonthlyRevenue.TabIndex = 1;
            tabMonthlyRevenue.Text = "💵 Monthly Revenue";

            // 
            // dgvMonthlyRevenue
            // 
            dgvMonthlyRevenue.AllowUserToAddRows = false;
            dgvMonthlyRevenue.AllowUserToDeleteRows = false;
            dgvMonthlyRevenue.AllowUserToResizeRows = false;
            dgvMonthlyRevenue.BackgroundColor = System.Drawing.Color.White;
            dgvMonthlyRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMonthlyRevenue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonthlyRevenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvMonthlyRevenue.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvMonthlyRevenue.ColumnHeadersHeight = 38;
            dgvMonthlyRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMonthlyRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colRevYear,
                colRevMonth,
                colRevTransactions,
                colRevTotal
            });
            dgvMonthlyRevenue.DefaultCellStyle = dgvDefaultStyle;
            dgvMonthlyRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMonthlyRevenue.EnableHeadersVisualStyles = false;
            dgvMonthlyRevenue.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvMonthlyRevenue.Location = new System.Drawing.Point(12, 12);
            dgvMonthlyRevenue.MultiSelect = false;
            dgvMonthlyRevenue.Name = "dgvMonthlyRevenue";
            dgvMonthlyRevenue.ReadOnly = true;
            dgvMonthlyRevenue.RowHeadersVisible = false;
            dgvMonthlyRevenue.RowTemplate.Height = 36;
            dgvMonthlyRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlyRevenue.Size = new System.Drawing.Size(1000, 463);
            dgvMonthlyRevenue.TabIndex = 0;

            // 
            // colRevYear
            // 
            colRevYear.DataPropertyName = "Year";
            colRevYear.HeaderText = "Year";
            colRevYear.MinimumWidth = 80;
            colRevYear.Name = "colRevYear";
            colRevYear.ReadOnly = true;
            colRevYear.Width = 100;

            // 
            // colRevMonth
            // 
            colRevMonth.DataPropertyName = "MonthName";
            colRevMonth.HeaderText = "Calendar Month";
            colRevMonth.MinimumWidth = 160;
            colRevMonth.Name = "colRevMonth";
            colRevMonth.ReadOnly = true;
            colRevMonth.Width = 220;

            // 
            // colRevTransactions
            // 
            colRevTransactions.DataPropertyName = "TransactionCount";
            colRevTransactions.HeaderText = "Recorded Payments";
            colRevTransactions.MinimumWidth = 140;
            colRevTransactions.Name = "colRevTransactions";
            colRevTransactions.ReadOnly = true;
            colRevTransactions.Width = 180;

            // 
            // colRevTotal
            // 
            colRevTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colRevTotal.DataPropertyName = "TotalIncomeDisplay";
            colRevTotal.HeaderText = "Total Revenue ($)";
            colRevTotal.MinimumWidth = 160;
            colRevTotal.Name = "colRevTotal";
            colRevTotal.ReadOnly = true;

            // 
            // tabAttendance
            // 
            tabAttendance.BackColor = System.Drawing.Color.White;
            tabAttendance.Controls.Add(dgvAttendance);
            tabAttendance.Location = new System.Drawing.Point(4, 38);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Padding = new System.Windows.Forms.Padding(12);
            tabAttendance.Size = new System.Drawing.Size(1024, 487);
            tabAttendance.TabIndex = 2;
            tabAttendance.Text = "🕒 Daily Footfall (30 Days)";

            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvAttendance.ColumnHeadersHeight = 38;
            dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colAttDate,
                colAttDay,
                colAttVisits,
                colAttUnique
            });
            dgvAttendance.DefaultCellStyle = dgvDefaultStyle;
            dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvAttendance.Location = new System.Drawing.Point(12, 12);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowTemplate.Height = 36;
            dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new System.Drawing.Size(1000, 463);
            dgvAttendance.TabIndex = 0;

            // 
            // colAttDate
            // 
            colAttDate.DataPropertyName = "DateDisplay";
            colAttDate.HeaderText = "Date";
            colAttDate.MinimumWidth = 120;
            colAttDate.Name = "colAttDate";
            colAttDate.ReadOnly = true;
            colAttDate.Width = 150;

            // 
            // colAttDay
            // 
            colAttDay.DataPropertyName = "DayOfWeek";
            colAttDay.HeaderText = "Day of Week";
            colAttDay.MinimumWidth = 120;
            colAttDay.Name = "colAttDay";
            colAttDay.ReadOnly = true;
            colAttDay.Width = 160;

            // 
            // colAttVisits
            // 
            colAttVisits.DataPropertyName = "TotalVisits";
            colAttVisits.HeaderText = "Total Check-in Visits";
            colAttVisits.MinimumWidth = 140;
            colAttVisits.Name = "colAttVisits";
            colAttVisits.ReadOnly = true;
            colAttVisits.Width = 180;

            // 
            // colAttUnique
            // 
            colAttUnique.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colAttUnique.DataPropertyName = "UniqueMembersCount";
            colAttUnique.HeaderText = "Unique Members";
            colAttUnique.MinimumWidth = 140;
            colAttUnique.Name = "colAttUnique";
            colAttUnique.ReadOnly = true;

            // 
            // tabMemberStatus
            // 
            tabMemberStatus.BackColor = System.Drawing.Color.White;
            tabMemberStatus.Controls.Add(dgvMemberStatus);
            tabMemberStatus.Controls.Add(pnlMemberFilter);
            tabMemberStatus.Location = new System.Drawing.Point(4, 38);
            tabMemberStatus.Name = "tabMemberStatus";
            tabMemberStatus.Padding = new System.Windows.Forms.Padding(12);
            tabMemberStatus.Size = new System.Drawing.Size(1024, 487);
            tabMemberStatus.TabIndex = 3;
            tabMemberStatus.Text = "👥 Membership Status";

            // 
            // pnlMemberFilter
            // 
            pnlMemberFilter.Controls.Add(cboMemberFilter);
            pnlMemberFilter.Controls.Add(lblMemberFilter);
            pnlMemberFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlMemberFilter.Location = new System.Drawing.Point(12, 12);
            pnlMemberFilter.Name = "pnlMemberFilter";
            pnlMemberFilter.Size = new System.Drawing.Size(1000, 42);
            pnlMemberFilter.TabIndex = 0;

            // 
            // lblMemberFilter
            // 
            lblMemberFilter.AutoSize = true;
            lblMemberFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMemberFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblMemberFilter.Location = new System.Drawing.Point(0, 12);
            lblMemberFilter.Name = "lblMemberFilter";
            lblMemberFilter.Size = new System.Drawing.Size(76, 15);
            lblMemberFilter.TabIndex = 0;
            lblMemberFilter.Text = "Filter Status:";

            // 
            // cboMemberFilter
            // 
            cboMemberFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMemberFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboMemberFilter.FormattingEnabled = true;
            cboMemberFilter.Items.AddRange(new object[] {
                "All Members",
                "Active Only",
                "Expired Only",
                "Overdue Balance Only"
            });
            cboMemberFilter.Location = new System.Drawing.Point(86, 9);
            cboMemberFilter.Name = "cboMemberFilter";
            cboMemberFilter.Size = new System.Drawing.Size(200, 23);
            cboMemberFilter.TabIndex = 1;
            cboMemberFilter.SelectedIndexChanged += cboMemberFilter_SelectedIndexChanged;

            // 
            // dgvMemberStatus
            // 
            dgvMemberStatus.AllowUserToAddRows = false;
            dgvMemberStatus.AllowUserToDeleteRows = false;
            dgvMemberStatus.AllowUserToResizeRows = false;
            dgvMemberStatus.BackgroundColor = System.Drawing.Color.White;
            dgvMemberStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMemberStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMemberStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvMemberStatus.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvMemberStatus.ColumnHeadersHeight = 38;
            dgvMemberStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMemberStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colMemId,
                colMemName,
                colMemPhone,
                colMemStatus,
                colMemPlan,
                colMemExpiry,
                colMemBalance
            });
            dgvMemberStatus.DefaultCellStyle = dgvDefaultStyle;
            dgvMemberStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMemberStatus.EnableHeadersVisualStyles = false;
            dgvMemberStatus.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvMemberStatus.Location = new System.Drawing.Point(12, 54);
            dgvMemberStatus.MultiSelect = false;
            dgvMemberStatus.Name = "dgvMemberStatus";
            dgvMemberStatus.ReadOnly = true;
            dgvMemberStatus.RowHeadersVisible = false;
            dgvMemberStatus.RowTemplate.Height = 36;
            dgvMemberStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberStatus.Size = new System.Drawing.Size(1000, 421);
            dgvMemberStatus.TabIndex = 1;

            // 
            // colMemId
            // 
            colMemId.DataPropertyName = "MemberId";
            colMemId.HeaderText = "ID";
            colMemId.MinimumWidth = 50;
            colMemId.Name = "colMemId";
            colMemId.ReadOnly = true;
            colMemId.Width = 60;

            // 
            // colMemName
            // 
            colMemName.DataPropertyName = "FullName";
            colMemName.HeaderText = "Member Name";
            colMemName.MinimumWidth = 140;
            colMemName.Name = "colMemName";
            colMemName.ReadOnly = true;
            colMemName.Width = 180;

            // 
            // colMemPhone
            // 
            colMemPhone.DataPropertyName = "Phone";
            colMemPhone.HeaderText = "Phone";
            colMemPhone.MinimumWidth = 100;
            colMemPhone.Name = "colMemPhone";
            colMemPhone.ReadOnly = true;
            colMemPhone.Width = 120;

            // 
            // colMemStatus
            // 
            colMemStatus.DataPropertyName = "Status";
            colMemStatus.HeaderText = "Subscription Status";
            colMemStatus.MinimumWidth = 120;
            colMemStatus.Name = "colMemStatus";
            colMemStatus.ReadOnly = true;
            colMemStatus.Width = 140;

            // 
            // colMemPlan
            // 
            colMemPlan.DataPropertyName = "PlanName";
            colMemPlan.HeaderText = "Plan";
            colMemPlan.MinimumWidth = 120;
            colMemPlan.Name = "colMemPlan";
            colMemPlan.ReadOnly = true;
            colMemPlan.Width = 160;

            // 
            // colMemExpiry
            // 
            colMemExpiry.DataPropertyName = "ExpiryDateDisplay";
            colMemExpiry.HeaderText = "Expiry Date";
            colMemExpiry.MinimumWidth = 110;
            colMemExpiry.Name = "colMemExpiry";
            colMemExpiry.ReadOnly = true;
            colMemExpiry.Width = 120;

            // 
            // colMemBalance
            // 
            colMemBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colMemBalance.DataPropertyName = "BalanceDisplay";
            colMemBalance.HeaderText = "Balance";
            colMemBalance.MinimumWidth = 100;
            colMemBalance.Name = "colMemBalance";
            colMemBalance.ReadOnly = true;

            // 
            // ReportsViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(tabReports);
            Controls.Add(pnlMetrics);
            Controls.Add(pnlHeader);
            Name = "ReportsViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1080, 720);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpHeaderActions.ResumeLayout(false);
            pnlMetrics.ResumeLayout(false);
            pnlMetricMembers.ResumeLayout(false);
            pnlMetricMembers.PerformLayout();
            pnlMetricRevenue.ResumeLayout(false);
            pnlMetricRevenue.PerformLayout();
            pnlMetricAttendance.ResumeLayout(false);
            pnlMetricAttendance.PerformLayout();
            pnlMetricOutstanding.ResumeLayout(false);
            pnlMetricOutstanding.PerformLayout();
            tabReports.ResumeLayout(false);
            tabFillRates.ResumeLayout(false);
            tabMonthlyRevenue.ResumeLayout(false);
            tabAttendance.ResumeLayout(false);
            tabMemberStatus.ResumeLayout(false);
            pnlMemberFilter.ResumeLayout(false);
            pnlMemberFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassFillRates).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMemberStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderActions;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlMetrics;
        private System.Windows.Forms.Panel pnlMetricMembers;
        private System.Windows.Forms.Label lblMembersTitle;
        private System.Windows.Forms.Label lblMembersVal;
        private System.Windows.Forms.Label lblMembersSub;

        private System.Windows.Forms.Panel pnlMetricRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueVal;
        private System.Windows.Forms.Label lblRevenueSub;

        private System.Windows.Forms.Panel pnlMetricAttendance;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblAttendanceVal;
        private System.Windows.Forms.Label lblAttendanceSub;

        private System.Windows.Forms.Panel pnlMetricOutstanding;
        private System.Windows.Forms.Label lblOutstandingTitle;
        private System.Windows.Forms.Label lblOutstandingVal;
        private System.Windows.Forms.Label lblOutstandingSub;

        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabFillRates;
        private System.Windows.Forms.DataGridView dgvClassFillRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFillRate;

        private System.Windows.Forms.TabPage tabMonthlyRevenue;
        private System.Windows.Forms.DataGridView dgvMonthlyRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevTotal;

        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttUnique;

        private System.Windows.Forms.TabPage tabMemberStatus;
        private System.Windows.Forms.Panel pnlMemberFilter;
        private System.Windows.Forms.Label lblMemberFilter;
        private System.Windows.Forms.ComboBox cboMemberFilter;
        private System.Windows.Forms.DataGridView dgvMemberStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemBalance;
    }
}
