namespace GymMembershipSystem.Forms.Attendance
{
    partial class AttendanceViewControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            flpHeaderActions = new System.Windows.Forms.FlowLayoutPanel();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlTerminal = new System.Windows.Forms.Panel();
            btnCheckOut = new System.Windows.Forms.Button();
            btnCheckIn = new System.Windows.Forms.Button();
            txtMemberSearch = new System.Windows.Forms.TextBox();
            lblTerminalPrompt = new System.Windows.Forms.Label();
            pnlFeedbackBanner = new System.Windows.Forms.Panel();
            lblFeedbackMessage = new System.Windows.Forms.Label();
            lblFeedbackIcon = new System.Windows.Forms.Label();
            pnlMetrics = new System.Windows.Forms.Panel();
            pnlMetricActive = new System.Windows.Forms.Panel();
            lblActiveMembersVal = new System.Windows.Forms.Label();
            lblActiveMembersTitle = new System.Windows.Forms.Label();
            pnlMetricTotal = new System.Windows.Forms.Panel();
            lblTotalVisitsVal = new System.Windows.Forms.Label();
            lblTotalVisitsTitle = new System.Windows.Forms.Label();
            pnlMetricOccupancy = new System.Windows.Forms.Panel();
            lblOccupancyVal = new System.Windows.Forms.Label();
            lblOccupancyTitle = new System.Windows.Forms.Label();
            pnlTableContainer = new System.Windows.Forms.Panel();
            dgvAttendance = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlTableToolbar = new System.Windows.Forms.Panel();
            chkInsideOnly = new System.Windows.Forms.CheckBox();
            btnCheckOutSelected = new System.Windows.Forms.Button();
            lblFilter = new System.Windows.Forms.Label();
            txtLogFilter = new System.Windows.Forms.TextBox();
            pnlHeader.SuspendLayout();
            flpHeaderActions.SuspendLayout();
            pnlTerminal.SuspendLayout();
            pnlFeedbackBanner.SuspendLayout();
            pnlMetrics.SuspendLayout();
            pnlMetricActive.SuspendLayout();
            pnlMetricTotal.SuspendLayout();
            pnlMetricOccupancy.SuspendLayout();
            pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            pnlTableToolbar.SuspendLayout();
            SuspendLayout();
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
            flpHeaderActions.Controls.Add(btnRefresh);
            flpHeaderActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpHeaderActions.Location = new System.Drawing.Point(882, 10);
            flpHeaderActions.Name = "flpHeaderActions";
            flpHeaderActions.Size = new System.Drawing.Size(150, 45);
            flpHeaderActions.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new System.Drawing.Point(51, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(96, 34);
            btnRefresh.TabIndex = 0;
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
            lblSubtitle.Size = new System.Drawing.Size(465, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Record member check-in & check-out with automatic active membership verification";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(277, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Daily Attendance Terminal";
            // 
            // pnlTerminal
            // 
            pnlTerminal.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlTerminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlTerminal.Controls.Add(btnCheckOut);
            pnlTerminal.Controls.Add(btnCheckIn);
            pnlTerminal.Controls.Add(txtMemberSearch);
            pnlTerminal.Controls.Add(lblTerminalPrompt);
            pnlTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTerminal.Location = new System.Drawing.Point(24, 85);
            pnlTerminal.Name = "pnlTerminal";
            pnlTerminal.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            pnlTerminal.Size = new System.Drawing.Size(1032, 70);
            pnlTerminal.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCheckOut.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnCheckOut.Location = new System.Drawing.Point(886, 20);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(130, 34);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "📤 Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCheckIn.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCheckIn.ForeColor = System.Drawing.Color.White;
            btnCheckIn.Location = new System.Drawing.Point(744, 20);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new System.Drawing.Size(136, 34);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "📥 Check In (↵)";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // txtMemberSearch
            // 
            txtMemberSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMemberSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            txtMemberSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            txtMemberSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMemberSearch.Location = new System.Drawing.Point(212, 23);
            txtMemberSearch.Name = "txtMemberSearch";
            txtMemberSearch.PlaceholderText = "Scan barcode, enter Member ID or type Full Name...";
            txtMemberSearch.Size = new System.Drawing.Size(516, 27);
            txtMemberSearch.TabIndex = 1;
            txtMemberSearch.KeyDown += txtMemberSearch_KeyDown;
            // 
            // lblTerminalPrompt
            // 
            lblTerminalPrompt.AutoSize = true;
            lblTerminalPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTerminalPrompt.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTerminalPrompt.Location = new System.Drawing.Point(14, 27);
            lblTerminalPrompt.Name = "lblTerminalPrompt";
            lblTerminalPrompt.Size = new System.Drawing.Size(186, 19);
            lblTerminalPrompt.TabIndex = 0;
            lblTerminalPrompt.Text = "Front Desk Member Lookup:";
            // 
            // pnlFeedbackBanner
            // 
            pnlFeedbackBanner.BackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            pnlFeedbackBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFeedbackBanner.Controls.Add(lblFeedbackMessage);
            pnlFeedbackBanner.Controls.Add(lblFeedbackIcon);
            pnlFeedbackBanner.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFeedbackBanner.Location = new System.Drawing.Point(24, 155);
            pnlFeedbackBanner.Name = "pnlFeedbackBanner";
            pnlFeedbackBanner.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            pnlFeedbackBanner.Size = new System.Drawing.Size(1032, 44);
            pnlFeedbackBanner.TabIndex = 2;
            pnlFeedbackBanner.Visible = false;
            // 
            // lblFeedbackMessage
            // 
            lblFeedbackMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFeedbackMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFeedbackMessage.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70);
            lblFeedbackMessage.Location = new System.Drawing.Point(40, 9);
            lblFeedbackMessage.Name = "lblFeedbackMessage";
            lblFeedbackMessage.Size = new System.Drawing.Size(975, 23);
            lblFeedbackMessage.TabIndex = 1;
            lblFeedbackMessage.Text = "Check-in approved for Member Name";
            lblFeedbackMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFeedbackIcon
            // 
            lblFeedbackIcon.AutoSize = true;
            lblFeedbackIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFeedbackIcon.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblFeedbackIcon.Location = new System.Drawing.Point(12, 9);
            lblFeedbackIcon.Name = "lblFeedbackIcon";
            lblFeedbackIcon.Size = new System.Drawing.Size(20, 21);
            lblFeedbackIcon.TabIndex = 0;
            lblFeedbackIcon.Text = "✓";
            // 
            // pnlMetrics
            // 
            pnlMetrics.Controls.Add(pnlMetricActive);
            pnlMetrics.Controls.Add(pnlMetricTotal);
            pnlMetrics.Controls.Add(pnlMetricOccupancy);
            pnlMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            pnlMetrics.Location = new System.Drawing.Point(24, 199);
            pnlMetrics.Name = "pnlMetrics";
            pnlMetrics.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            pnlMetrics.Size = new System.Drawing.Size(1032, 86);
            pnlMetrics.TabIndex = 3;
            // 
            // pnlMetricActive
            // 
            pnlMetricActive.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlMetricActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricActive.Controls.Add(lblActiveMembersVal);
            pnlMetricActive.Controls.Add(lblActiveMembersTitle);
            pnlMetricActive.Location = new System.Drawing.Point(460, 10);
            pnlMetricActive.Name = "pnlMetricActive";
            pnlMetricActive.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            pnlMetricActive.Size = new System.Drawing.Size(210, 66);
            pnlMetricActive.TabIndex = 2;
            // 
            // lblActiveMembersVal
            // 
            lblActiveMembersVal.AutoSize = true;
            lblActiveMembersVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActiveMembersVal.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblActiveMembersVal.Location = new System.Drawing.Point(12, 26);
            lblActiveMembersVal.Name = "lblActiveMembersVal";
            lblActiveMembersVal.Size = new System.Drawing.Size(26, 30);
            lblActiveMembersVal.TabIndex = 1;
            lblActiveMembersVal.Text = "0";
            // 
            // lblActiveMembersTitle
            // 
            lblActiveMembersTitle.AutoSize = true;
            lblActiveMembersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActiveMembersTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblActiveMembersTitle.Location = new System.Drawing.Point(14, 8);
            lblActiveMembersTitle.Name = "lblActiveMembersTitle";
            lblActiveMembersTitle.Size = new System.Drawing.Size(126, 15);
            lblActiveMembersTitle.TabIndex = 0;
            lblActiveMembersTitle.Text = "ACTIVE MEMBERSHIPS";
            // 
            // pnlMetricTotal
            // 
            pnlMetricTotal.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            pnlMetricTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricTotal.Controls.Add(lblTotalVisitsVal);
            pnlMetricTotal.Controls.Add(lblTotalVisitsTitle);
            pnlMetricTotal.Location = new System.Drawing.Point(230, 10);
            pnlMetricTotal.Name = "pnlMetricTotal";
            pnlMetricTotal.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            pnlMetricTotal.Size = new System.Drawing.Size(210, 66);
            pnlMetricTotal.TabIndex = 1;
            // 
            // lblTotalVisitsVal
            // 
            lblTotalVisitsVal.AutoSize = true;
            lblTotalVisitsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalVisitsVal.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
            lblTotalVisitsVal.Location = new System.Drawing.Point(12, 26);
            lblTotalVisitsVal.Name = "lblTotalVisitsVal";
            lblTotalVisitsVal.Size = new System.Drawing.Size(26, 30);
            lblTotalVisitsVal.TabIndex = 1;
            lblTotalVisitsVal.Text = "0";
            // 
            // lblTotalVisitsTitle
            // 
            lblTotalVisitsTitle.AutoSize = true;
            lblTotalVisitsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalVisitsTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTotalVisitsTitle.Location = new System.Drawing.Point(14, 8);
            lblTotalVisitsTitle.Name = "lblTotalVisitsTitle";
            lblTotalVisitsTitle.Size = new System.Drawing.Size(128, 15);
            lblTotalVisitsTitle.TabIndex = 0;
            lblTotalVisitsTitle.Text = "TODAY'S TOTAL VISITS";
            // 
            // pnlMetricOccupancy
            // 
            pnlMetricOccupancy.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            pnlMetricOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricOccupancy.Controls.Add(lblOccupancyVal);
            pnlMetricOccupancy.Controls.Add(lblOccupancyTitle);
            pnlMetricOccupancy.Location = new System.Drawing.Point(0, 10);
            pnlMetricOccupancy.Name = "pnlMetricOccupancy";
            pnlMetricOccupancy.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            pnlMetricOccupancy.Size = new System.Drawing.Size(210, 66);
            pnlMetricOccupancy.TabIndex = 0;
            // 
            // lblOccupancyVal
            // 
            lblOccupancyVal.AutoSize = true;
            lblOccupancyVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOccupancyVal.ForeColor = System.Drawing.Color.FromArgb(4, 120, 87);
            lblOccupancyVal.Location = new System.Drawing.Point(12, 26);
            lblOccupancyVal.Name = "lblOccupancyVal";
            lblOccupancyVal.Size = new System.Drawing.Size(26, 30);
            lblOccupancyVal.TabIndex = 1;
            lblOccupancyVal.Text = "0";
            // 
            // lblOccupancyTitle
            // 
            lblOccupancyTitle.AutoSize = true;
            lblOccupancyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOccupancyTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblOccupancyTitle.Location = new System.Drawing.Point(14, 8);
            lblOccupancyTitle.Name = "lblOccupancyTitle";
            lblOccupancyTitle.Size = new System.Drawing.Size(130, 15);
            lblOccupancyTitle.TabIndex = 0;
            lblOccupancyTitle.Text = "CURRENTLY IN FACILITY";
            // 
            // pnlTableContainer
            // 
            pnlTableContainer.Controls.Add(dgvAttendance);
            pnlTableContainer.Controls.Add(pnlTableToolbar);
            pnlTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTableContainer.Location = new System.Drawing.Point(24, 285);
            pnlTableContainer.Name = "pnlTableContainer";
            pnlTableContainer.Size = new System.Drawing.Size(1032, 385);
            pnlTableContainer.TabIndex = 4;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeight = 36;
            dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colMember, colPlan, colCheckIn, colCheckOut, colDuration, colStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvAttendance.Location = new System.Drawing.Point(0, 44);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowTemplate.Height = 36;
            dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new System.Drawing.Size(1032, 341);
            dgvAttendance.TabIndex = 1;
            dgvAttendance.CellDoubleClick += dgvAttendance_CellDoubleClick;
            dgvAttendance.SelectionChanged += dgvAttendance_SelectionChanged;
            // 
            // colId
            // 
            colId.HeaderText = "Log #";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colMember
            // 
            colMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colMember.HeaderText = "Member Name";
            colMember.Name = "colMember";
            colMember.ReadOnly = true;
            // 
            // colPlan
            // 
            colPlan.HeaderText = "Current Plan";
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            colPlan.Width = 160;
            // 
            // colCheckIn
            // 
            colCheckIn.HeaderText = "Check-In Time";
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            colCheckIn.Width = 130;
            // 
            // colCheckOut
            // 
            colCheckOut.HeaderText = "Check-Out Time";
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            colCheckOut.Width = 130;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Duration";
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            colDuration.Width = 100;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 110;
            // 
            // pnlTableToolbar
            // 
            pnlTableToolbar.Controls.Add(chkInsideOnly);
            pnlTableToolbar.Controls.Add(btnCheckOutSelected);
            pnlTableToolbar.Controls.Add(lblFilter);
            pnlTableToolbar.Controls.Add(txtLogFilter);
            pnlTableToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTableToolbar.Location = new System.Drawing.Point(0, 0);
            pnlTableToolbar.Name = "pnlTableToolbar";
            pnlTableToolbar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            pnlTableToolbar.Size = new System.Drawing.Size(1032, 44);
            pnlTableToolbar.TabIndex = 0;
            // 
            // chkInsideOnly
            // 
            chkInsideOnly.AutoSize = true;
            chkInsideOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkInsideOnly.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            chkInsideOnly.Location = new System.Drawing.Point(290, 13);
            chkInsideOnly.Name = "chkInsideOnly";
            chkInsideOnly.Size = new System.Drawing.Size(167, 19);
            chkInsideOnly.TabIndex = 2;
            chkInsideOnly.Text = "Show Currently Inside Only";
            chkInsideOnly.UseVisualStyleBackColor = true;
            chkInsideOnly.CheckedChanged += chkInsideOnly_CheckedChanged;
            // 
            // btnCheckOutSelected
            // 
            btnCheckOutSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCheckOutSelected.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCheckOutSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheckOutSelected.Enabled = false;
            btnCheckOutSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCheckOutSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckOutSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCheckOutSelected.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnCheckOutSelected.Location = new System.Drawing.Point(828, 6);
            btnCheckOutSelected.Name = "btnCheckOutSelected";
            btnCheckOutSelected.Size = new System.Drawing.Size(204, 32);
            btnCheckOutSelected.TabIndex = 3;
            btnCheckOutSelected.Text = "📤 Check Out Selected Attendee";
            btnCheckOutSelected.UseVisualStyleBackColor = false;
            btnCheckOutSelected.Click += btnCheckOutSelected_Click;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblFilter.Location = new System.Drawing.Point(0, 14);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new System.Drawing.Size(65, 15);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter Logs:";
            // 
            // txtLogFilter
            // 
            txtLogFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLogFilter.Location = new System.Drawing.Point(70, 11);
            txtLogFilter.Name = "txtLogFilter";
            txtLogFilter.PlaceholderText = "Search by attendee name or ID...";
            txtLogFilter.Size = new System.Drawing.Size(200, 23);
            txtLogFilter.TabIndex = 1;
            txtLogFilter.TextChanged += txtLogFilter_TextChanged;
            // 
            // AttendanceViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(pnlTableContainer);
            Controls.Add(pnlMetrics);
            Controls.Add(pnlFeedbackBanner);
            Controls.Add(pnlTerminal);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "AttendanceViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1080, 690);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpHeaderActions.ResumeLayout(false);
            pnlTerminal.ResumeLayout(false);
            pnlTerminal.PerformLayout();
            pnlFeedbackBanner.ResumeLayout(false);
            pnlFeedbackBanner.PerformLayout();
            pnlMetrics.ResumeLayout(false);
            pnlMetricActive.ResumeLayout(false);
            pnlMetricActive.PerformLayout();
            pnlMetricTotal.ResumeLayout(false);
            pnlMetricTotal.PerformLayout();
            pnlMetricOccupancy.ResumeLayout(false);
            pnlMetricOccupancy.PerformLayout();
            pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            pnlTableToolbar.ResumeLayout(false);
            pnlTableToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.Label lblTerminalPrompt;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlFeedbackBanner;
        private System.Windows.Forms.Label lblFeedbackIcon;
        private System.Windows.Forms.Label lblFeedbackMessage;
        private System.Windows.Forms.Panel pnlMetrics;
        private System.Windows.Forms.Panel pnlMetricOccupancy;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.Label lblOccupancyVal;
        private System.Windows.Forms.Panel pnlMetricTotal;
        private System.Windows.Forms.Label lblTotalVisitsTitle;
        private System.Windows.Forms.Label lblTotalVisitsVal;
        private System.Windows.Forms.Panel pnlMetricActive;
        private System.Windows.Forms.Label lblActiveMembersTitle;
        private System.Windows.Forms.Label lblActiveMembersVal;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.Panel pnlTableToolbar;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtLogFilter;
        private System.Windows.Forms.CheckBox chkInsideOnly;
        private System.Windows.Forms.Button btnCheckOutSelected;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
