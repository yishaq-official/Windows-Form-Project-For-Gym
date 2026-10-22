namespace GymMembershipSystem.Forms.Classes
{
    partial class ClassesViewControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            flpHeaderActions = new System.Windows.Forms.FlowLayoutPanel();
            btnNewClass = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlFilter = new System.Windows.Forms.Panel();
            chkIncludeInactive = new System.Windows.Forms.CheckBox();
            cboTrainerFilter = new System.Windows.Forms.ComboBox();
            lblTrainerFilter = new System.Windows.Forms.Label();
            cboDayFilter = new System.Windows.Forms.ComboBox();
            lblDayFilter = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            splMain = new System.Windows.Forms.SplitContainer();
            pnlClassesTable = new System.Windows.Forms.Panel();
            dgvClasses = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlClassActions = new System.Windows.Forms.Panel();
            flpClassActions = new System.Windows.Forms.FlowLayoutPanel();
            btnEditClass = new System.Windows.Forms.Button();
            btnToggleActive = new System.Windows.Forms.Button();
            btnDeleteClass = new System.Windows.Forms.Button();
            pnlRoster = new System.Windows.Forms.Panel();
            dgvRoster = new System.Windows.Forms.DataGridView();
            colBookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlRosterActions = new System.Windows.Forms.Panel();
            flpRosterActions = new System.Windows.Forms.FlowLayoutPanel();
            btnBookMember = new System.Windows.Forms.Button();
            btnCancelBooking = new System.Windows.Forms.Button();
            pnlRosterHeader = new System.Windows.Forms.Panel();
            pbrCapacity = new System.Windows.Forms.ProgressBar();
            lblRosterSpots = new System.Windows.Forms.Label();
            lblRosterSchedule = new System.Windows.Forms.Label();
            lblRosterTitle = new System.Windows.Forms.Label();
            lblRosterTag = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            flpHeaderActions.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splMain).BeginInit();
            splMain.Panel1.SuspendLayout();
            splMain.Panel2.SuspendLayout();
            splMain.SuspendLayout();
            pnlClassesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            pnlClassActions.SuspendLayout();
            flpClassActions.SuspendLayout();
            pnlRoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoster).BeginInit();
            pnlRosterActions.SuspendLayout();
            flpRosterActions.SuspendLayout();
            pnlRosterHeader.SuspendLayout();
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
            flpHeaderActions.Controls.Add(btnNewClass);
            flpHeaderActions.Controls.Add(btnRefresh);
            flpHeaderActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpHeaderActions.Location = new System.Drawing.Point(744, 10);
            flpHeaderActions.Name = "flpHeaderActions";
            flpHeaderActions.Size = new System.Drawing.Size(288, 45);
            flpHeaderActions.TabIndex = 2;
            // 
            // btnNewClass
            // 
            btnNewClass.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnNewClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNewClass.FlatAppearance.BorderSize = 0;
            btnNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNewClass.ForeColor = System.Drawing.Color.White;
            btnNewClass.Location = new System.Drawing.Point(156, 3);
            btnNewClass.Name = "btnNewClass";
            btnNewClass.Size = new System.Drawing.Size(129, 34);
            btnNewClass.TabIndex = 0;
            btnNewClass.Text = "➕ New Class";
            btnNewClass.UseVisualStyleBackColor = false;
            btnNewClass.Click += btnNewClass_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new System.Drawing.Point(54, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(96, 34);
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
            lblSubtitle.Size = new System.Drawing.Size(425, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage fitness class schedules, capacity constraints, and member enrollments";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(209, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Classes & Bookings";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(chkIncludeInactive);
            pnlFilter.Controls.Add(cboTrainerFilter);
            pnlFilter.Controls.Add(lblTrainerFilter);
            pnlFilter.Controls.Add(cboDayFilter);
            pnlFilter.Controls.Add(lblDayFilter);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(24, 85);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            pnlFilter.Size = new System.Drawing.Size(1032, 52);
            pnlFilter.TabIndex = 1;
            // 
            // chkIncludeInactive
            // 
            chkIncludeInactive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkIncludeInactive.AutoSize = true;
            chkIncludeInactive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkIncludeInactive.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            chkIncludeInactive.Location = new System.Drawing.Point(908, 15);
            chkIncludeInactive.Name = "chkIncludeInactive";
            chkIncludeInactive.Size = new System.Drawing.Size(110, 19);
            chkIncludeInactive.TabIndex = 6;
            chkIncludeInactive.Text = "Include Inactive";
            chkIncludeInactive.UseVisualStyleBackColor = true;
            chkIncludeInactive.CheckedChanged += FilterControl_Changed;
            // 
            // cboTrainerFilter
            // 
            cboTrainerFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTrainerFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTrainerFilter.FormattingEnabled = true;
            cboTrainerFilter.Location = new System.Drawing.Point(546, 13);
            cboTrainerFilter.Name = "cboTrainerFilter";
            cboTrainerFilter.Size = new System.Drawing.Size(180, 23);
            cboTrainerFilter.TabIndex = 5;
            cboTrainerFilter.SelectedIndexChanged += FilterControl_Changed;
            // 
            // lblTrainerFilter
            // 
            lblTrainerFilter.AutoSize = true;
            lblTrainerFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTrainerFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblTrainerFilter.Location = new System.Drawing.Point(494, 17);
            lblTrainerFilter.Name = "lblTrainerFilter";
            lblTrainerFilter.Size = new System.Drawing.Size(46, 15);
            lblTrainerFilter.TabIndex = 4;
            lblTrainerFilter.Text = "Trainer:";
            // 
            // cboDayFilter
            // 
            cboDayFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDayFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboDayFilter.FormattingEnabled = true;
            cboDayFilter.Location = new System.Drawing.Point(344, 13);
            cboDayFilter.Name = "cboDayFilter";
            cboDayFilter.Size = new System.Drawing.Size(130, 23);
            cboDayFilter.TabIndex = 3;
            cboDayFilter.SelectedIndexChanged += FilterControl_Changed;
            // 
            // lblDayFilter
            // 
            lblDayFilter.AutoSize = true;
            lblDayFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDayFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblDayFilter.Location = new System.Drawing.Point(308, 17);
            lblDayFilter.Name = "lblDayFilter";
            lblDayFilter.Size = new System.Drawing.Size(30, 15);
            lblDayFilter.TabIndex = 2;
            lblDayFilter.Text = "Day:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(64, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by class name...";
            txtSearch.Size = new System.Drawing.Size(220, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterControl_Changed;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblSearch.Location = new System.Drawing.Point(12, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(46, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // splMain
            // 
            splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splMain.Location = new System.Drawing.Point(24, 137);
            splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            splMain.Panel1.Controls.Add(pnlClassesTable);
            splMain.Panel1.Controls.Add(pnlClassActions);
            // 
            // splMain.Panel2
            // 
            splMain.Panel2.Controls.Add(pnlRoster);
            splMain.Panel2.Controls.Add(pnlRosterActions);
            splMain.Panel2.Controls.Add(pnlRosterHeader);
            splMain.Size = new System.Drawing.Size(1032, 533);
            splMain.SplitterDistance = 612;
            splMain.TabIndex = 2;
            // 
            // pnlClassesTable
            // 
            pnlClassesTable.Controls.Add(dgvClasses);
            pnlClassesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlClassesTable.Location = new System.Drawing.Point(0, 0);
            pnlClassesTable.Name = "pnlClassesTable";
            pnlClassesTable.Padding = new System.Windows.Forms.Padding(0, 12, 6, 0);
            pnlClassesTable.Size = new System.Drawing.Size(612, 483);
            pnlClassesTable.TabIndex = 1;
            // 
            // dgvClasses
            // 
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.AllowUserToResizeRows = false;
            dgvClasses.BackgroundColor = System.Drawing.Color.White;
            dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClasses.ColumnHeadersHeight = 36;
            dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colTrainer, colSchedule, colDuration, colCapacity, colBooked, colStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvClasses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvClasses.EnableHeadersVisualStyles = false;
            dgvClasses.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvClasses.Location = new System.Drawing.Point(0, 12);
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.RowTemplate.Height = 36;
            dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new System.Drawing.Size(606, 471);
            dgvClasses.TabIndex = 0;
            dgvClasses.SelectionChanged += dgvClasses_SelectionChanged;
            dgvClasses.CellDoubleClick += dgvClasses_CellDoubleClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 45;
            // 
            // colName
            // 
            colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Class Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colTrainer
            // 
            colTrainer.HeaderText = "Trainer";
            colTrainer.Name = "colTrainer";
            colTrainer.ReadOnly = true;
            colTrainer.Width = 115;
            // 
            // colSchedule
            // 
            colSchedule.HeaderText = "Schedule";
            colSchedule.Name = "colSchedule";
            colSchedule.ReadOnly = true;
            colSchedule.Width = 125;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Mins";
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            colDuration.Width = 50;
            // 
            // colCapacity
            // 
            colCapacity.HeaderText = "Cap";
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            colCapacity.Width = 50;
            // 
            // colBooked
            // 
            colBooked.HeaderText = "Booked";
            colBooked.Name = "colBooked";
            colBooked.ReadOnly = true;
            colBooked.Width = 70;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 65;
            // 
            // pnlClassActions
            // 
            pnlClassActions.Controls.Add(flpClassActions);
            pnlClassActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlClassActions.Location = new System.Drawing.Point(0, 483);
            pnlClassActions.Name = "pnlClassActions";
            pnlClassActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            pnlClassActions.Size = new System.Drawing.Size(612, 50);
            pnlClassActions.TabIndex = 0;
            // 
            // flpClassActions
            // 
            flpClassActions.Controls.Add(btnEditClass);
            flpClassActions.Controls.Add(btnToggleActive);
            flpClassActions.Controls.Add(btnDeleteClass);
            flpClassActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flpClassActions.Location = new System.Drawing.Point(0, 8);
            flpClassActions.Name = "flpClassActions";
            flpClassActions.Size = new System.Drawing.Size(612, 42);
            flpClassActions.TabIndex = 0;
            // 
            // btnEditClass
            // 
            btnEditClass.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnEditClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditClass.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditClass.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnEditClass.Location = new System.Drawing.Point(3, 3);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new System.Drawing.Size(100, 32);
            btnEditClass.TabIndex = 0;
            btnEditClass.Text = "✏️ Edit Class";
            btnEditClass.UseVisualStyleBackColor = false;
            btnEditClass.Click += btnEditClass_Click;
            // 
            // btnToggleActive
            // 
            btnToggleActive.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleActive.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnToggleActive.Location = new System.Drawing.Point(109, 3);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new System.Drawing.Size(115, 32);
            btnToggleActive.TabIndex = 1;
            btnToggleActive.Text = "⚡ Deactivate";
            btnToggleActive.UseVisualStyleBackColor = false;
            btnToggleActive.Click += btnToggleActive_Click;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnDeleteClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteClass.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDeleteClass.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            btnDeleteClass.Location = new System.Drawing.Point(230, 3);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new System.Drawing.Size(100, 32);
            btnDeleteClass.TabIndex = 2;
            btnDeleteClass.Text = "🗑️ Delete";
            btnDeleteClass.UseVisualStyleBackColor = false;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // pnlRoster
            // 
            pnlRoster.Controls.Add(dgvRoster);
            pnlRoster.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRoster.Location = new System.Drawing.Point(0, 110);
            pnlRoster.Name = "pnlRoster";
            pnlRoster.Padding = new System.Windows.Forms.Padding(6, 6, 0, 0);
            pnlRoster.Size = new System.Drawing.Size(416, 373);
            pnlRoster.TabIndex = 2;
            // 
            // dgvRoster
            // 
            dgvRoster.AllowUserToAddRows = false;
            dgvRoster.AllowUserToDeleteRows = false;
            dgvRoster.AllowUserToResizeRows = false;
            dgvRoster.BackgroundColor = System.Drawing.Color.White;
            dgvRoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvRoster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRoster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRoster.ColumnHeadersHeight = 32;
            dgvRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colBookingId, colMemberId, colMemberName, colMemberPhone, colBookingDate });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvRoster.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRoster.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRoster.EnableHeadersVisualStyles = false;
            dgvRoster.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvRoster.Location = new System.Drawing.Point(6, 6);
            dgvRoster.MultiSelect = false;
            dgvRoster.Name = "dgvRoster";
            dgvRoster.ReadOnly = true;
            dgvRoster.RowHeadersVisible = false;
            dgvRoster.RowTemplate.Height = 32;
            dgvRoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRoster.Size = new System.Drawing.Size(410, 367);
            dgvRoster.TabIndex = 0;
            dgvRoster.SelectionChanged += dgvRoster_SelectionChanged;
            // 
            // colBookingId
            // 
            colBookingId.HeaderText = "Book #";
            colBookingId.Name = "colBookingId";
            colBookingId.ReadOnly = true;
            colBookingId.Width = 55;
            // 
            // colMemberId
            // 
            colMemberId.HeaderText = "Mem #";
            colMemberId.Name = "colMemberId";
            colMemberId.ReadOnly = true;
            colMemberId.Width = 55;
            // 
            // colMemberName
            // 
            colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colMemberName.HeaderText = "Member Name";
            colMemberName.Name = "colMemberName";
            colMemberName.ReadOnly = true;
            // 
            // colMemberPhone
            // 
            colMemberPhone.HeaderText = "Phone";
            colMemberPhone.Name = "colMemberPhone";
            colMemberPhone.ReadOnly = true;
            colMemberPhone.Width = 100;
            // 
            // colBookingDate
            // 
            colBookingDate.HeaderText = "Booked";
            colBookingDate.Name = "colBookingDate";
            colBookingDate.ReadOnly = true;
            colBookingDate.Width = 75;
            // 
            // pnlRosterActions
            // 
            pnlRosterActions.Controls.Add(flpRosterActions);
            pnlRosterActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlRosterActions.Location = new System.Drawing.Point(0, 483);
            pnlRosterActions.Name = "pnlRosterActions";
            pnlRosterActions.Padding = new System.Windows.Forms.Padding(6, 8, 0, 0);
            pnlRosterActions.Size = new System.Drawing.Size(416, 50);
            pnlRosterActions.TabIndex = 1;
            // 
            // flpRosterActions
            // 
            flpRosterActions.Controls.Add(btnBookMember);
            flpRosterActions.Controls.Add(btnCancelBooking);
            flpRosterActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flpRosterActions.Location = new System.Drawing.Point(6, 8);
            flpRosterActions.Name = "flpRosterActions";
            flpRosterActions.Size = new System.Drawing.Size(410, 42);
            flpRosterActions.TabIndex = 0;
            // 
            // btnBookMember
            // 
            btnBookMember.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnBookMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBookMember.FlatAppearance.BorderSize = 0;
            btnBookMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBookMember.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBookMember.ForeColor = System.Drawing.Color.White;
            btnBookMember.Location = new System.Drawing.Point(3, 3);
            btnBookMember.Name = "btnBookMember";
            btnBookMember.Size = new System.Drawing.Size(125, 32);
            btnBookMember.TabIndex = 0;
            btnBookMember.Text = "🎟️ Book Member";
            btnBookMember.UseVisualStyleBackColor = false;
            btnBookMember.Click += btnBookMember_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelBooking.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnCancelBooking.Location = new System.Drawing.Point(134, 3);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new System.Drawing.Size(130, 32);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "❌ Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // pnlRosterHeader
            // 
            pnlRosterHeader.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlRosterHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlRosterHeader.Controls.Add(pbrCapacity);
            pnlRosterHeader.Controls.Add(lblRosterSpots);
            pnlRosterHeader.Controls.Add(lblRosterSchedule);
            pnlRosterHeader.Controls.Add(lblRosterTitle);
            pnlRosterHeader.Controls.Add(lblRosterTag);
            pnlRosterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlRosterHeader.Location = new System.Drawing.Point(0, 0);
            pnlRosterHeader.Name = "pnlRosterHeader";
            pnlRosterHeader.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
            pnlRosterHeader.Size = new System.Drawing.Size(416, 110);
            pnlRosterHeader.TabIndex = 0;
            // 
            // pbrCapacity
            // 
            pbrCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbrCapacity.Location = new System.Drawing.Point(12, 80);
            pbrCapacity.Name = "pbrCapacity";
            pbrCapacity.Size = new System.Drawing.Size(390, 14);
            pbrCapacity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            pbrCapacity.TabIndex = 4;
            // 
            // lblRosterSpots
            // 
            lblRosterSpots.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblRosterSpots.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRosterSpots.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblRosterSpots.Location = new System.Drawing.Point(230, 10);
            lblRosterSpots.Name = "lblRosterSpots";
            lblRosterSpots.Size = new System.Drawing.Size(172, 20);
            lblRosterSpots.TabIndex = 3;
            lblRosterSpots.Text = "12/15 Booked (3 spots left)";
            lblRosterSpots.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRosterSchedule
            // 
            lblRosterSchedule.AutoSize = true;
            lblRosterSchedule.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRosterSchedule.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblRosterSchedule.Location = new System.Drawing.Point(12, 56);
            lblRosterSchedule.Name = "lblRosterSchedule";
            lblRosterSchedule.Size = new System.Drawing.Size(222, 15);
            lblRosterSchedule.TabIndex = 2;
            lblRosterSchedule.Text = "Monday at 07:00 AM • Trainer: Sarah Lee";
            // 
            // lblRosterTitle
            // 
            lblRosterTitle.AutoSize = true;
            lblRosterTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRosterTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblRosterTitle.Location = new System.Drawing.Point(12, 32);
            lblRosterTitle.Name = "lblRosterTitle";
            lblRosterTitle.Size = new System.Drawing.Size(147, 20);
            lblRosterTitle.TabIndex = 1;
            lblRosterTitle.Text = "Sunrise Power Yoga";
            // 
            // lblRosterTag
            // 
            lblRosterTag.AutoSize = true;
            lblRosterTag.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRosterTag.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblRosterTag.Location = new System.Drawing.Point(12, 12);
            lblRosterTag.Name = "lblRosterTag";
            lblRosterTag.Size = new System.Drawing.Size(107, 13);
            lblRosterTag.TabIndex = 0;
            lblRosterTag.Text = "ATTENDEE ROSTER";
            // 
            // ClassesViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(splMain);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "ClassesViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1080, 690);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpHeaderActions.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            splMain.Panel1.ResumeLayout(false);
            splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splMain).EndInit();
            splMain.ResumeLayout(false);
            pnlClassesTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            pnlClassActions.ResumeLayout(false);
            flpClassActions.ResumeLayout(false);
            pnlRoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoster).EndInit();
            pnlRosterActions.ResumeLayout(false);
            flpRosterActions.ResumeLayout(false);
            pnlRosterHeader.ResumeLayout(false);
            pnlRosterHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderActions;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDayFilter;
        private System.Windows.Forms.ComboBox cboDayFilter;
        private System.Windows.Forms.Label lblTrainerFilter;
        private System.Windows.Forms.ComboBox cboTrainerFilter;
        private System.Windows.Forms.CheckBox chkIncludeInactive;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.Panel pnlClassesTable;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlClassActions;
        private System.Windows.Forms.FlowLayoutPanel flpClassActions;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Panel pnlRosterHeader;
        private System.Windows.Forms.Label lblRosterTag;
        private System.Windows.Forms.Label lblRosterTitle;
        private System.Windows.Forms.Label lblRosterSchedule;
        private System.Windows.Forms.Label lblRosterSpots;
        private System.Windows.Forms.ProgressBar pbrCapacity;
        private System.Windows.Forms.Panel pnlRoster;
        private System.Windows.Forms.DataGridView dgvRoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookingDate;
        private System.Windows.Forms.Panel pnlRosterActions;
        private System.Windows.Forms.FlowLayoutPanel flpRosterActions;
        private System.Windows.Forms.Button btnBookMember;
        private System.Windows.Forms.Button btnCancelBooking;
    }
}
