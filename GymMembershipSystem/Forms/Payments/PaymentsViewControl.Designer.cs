namespace GymMembershipSystem.Forms.Payments
{
    partial class PaymentsViewControl
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
            pnlHeader = new System.Windows.Forms.Panel();
            flpHeaderActions = new System.Windows.Forms.FlowLayoutPanel();
            btnRecordPayment = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlMetrics = new System.Windows.Forms.Panel();
            pnlMetricOutstanding = new System.Windows.Forms.Panel();
            lblOutstandingVal = new System.Windows.Forms.Label();
            lblOutstandingTitle = new System.Windows.Forms.Label();
            pnlMetricLifetime = new System.Windows.Forms.Panel();
            lblLifetimeVal = new System.Windows.Forms.Label();
            lblLifetimeTitle = new System.Windows.Forms.Label();
            pnlMetricMonth = new System.Windows.Forms.Panel();
            lblMonthVal = new System.Windows.Forms.Label();
            lblMonthTitle = new System.Windows.Forms.Label();
            pnlFilter = new System.Windows.Forms.Panel();
            btnResetFilters = new System.Windows.Forms.Button();
            cboMethodFilter = new System.Windows.Forms.ComboBox();
            lblMethodFilter = new System.Windows.Forms.Label();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            lblToDate = new System.Windows.Forms.Label();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            chkEnableDateFilter = new System.Windows.Forms.CheckBox();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            pnlGridContainer = new System.Windows.Forms.Panel();
            dgvPayments = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            flpHeaderActions.SuspendLayout();
            pnlMetrics.SuspendLayout();
            pnlMetricOutstanding.SuspendLayout();
            pnlMetricLifetime.SuspendLayout();
            pnlMetricMonth.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
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
            flpHeaderActions.Controls.Add(btnRecordPayment);
            flpHeaderActions.Controls.Add(btnRefresh);
            flpHeaderActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpHeaderActions.Location = new System.Drawing.Point(680, 10);
            flpHeaderActions.Name = "flpHeaderActions";
            flpHeaderActions.Size = new System.Drawing.Size(352, 45);
            flpHeaderActions.TabIndex = 2;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnRecordPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRecordPayment.FlatAppearance.BorderSize = 0;
            btnRecordPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRecordPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRecordPayment.ForeColor = System.Drawing.Color.White;
            btnRecordPayment.Location = new System.Drawing.Point(202, 3);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new System.Drawing.Size(147, 34);
            btnRecordPayment.TabIndex = 0;
            btnRecordPayment.Text = "💳 Record Payment";
            btnRecordPayment.UseVisualStyleBackColor = false;
            btnRecordPayment.Click += btnRecordPayment_Click;
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
            lblSubtitle.Size = new System.Drawing.Size(434, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Record member subscription fees, review billing history, and monitor revenue";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(306, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payments & Financial Ledger";
            // 
            // pnlMetrics
            // 
            pnlMetrics.Controls.Add(pnlMetricOutstanding);
            pnlMetrics.Controls.Add(pnlMetricLifetime);
            pnlMetrics.Controls.Add(pnlMetricMonth);
            pnlMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            pnlMetrics.Location = new System.Drawing.Point(24, 85);
            pnlMetrics.Name = "pnlMetrics";
            pnlMetrics.Padding = new System.Windows.Forms.Padding(0, 4, 0, 12);
            pnlMetrics.Size = new System.Drawing.Size(1032, 86);
            pnlMetrics.TabIndex = 1;
            // 
            // pnlMetricOutstanding
            // 
            pnlMetricOutstanding.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            pnlMetricOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricOutstanding.Controls.Add(lblOutstandingVal);
            pnlMetricOutstanding.Controls.Add(lblOutstandingTitle);
            pnlMetricOutstanding.Location = new System.Drawing.Point(460, 4);
            pnlMetricOutstanding.Name = "pnlMetricOutstanding";
            pnlMetricOutstanding.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            pnlMetricOutstanding.Size = new System.Drawing.Size(210, 68);
            pnlMetricOutstanding.TabIndex = 2;
            // 
            // lblOutstandingVal
            // 
            lblOutstandingVal.AutoSize = true;
            lblOutstandingVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOutstandingVal.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            lblOutstandingVal.Location = new System.Drawing.Point(12, 27);
            lblOutstandingVal.Name = "lblOutstandingVal";
            lblOutstandingVal.Size = new System.Drawing.Size(68, 30);
            lblOutstandingVal.TabIndex = 1;
            lblOutstandingVal.Text = "$0.00";
            // 
            // lblOutstandingTitle
            // 
            lblOutstandingTitle.AutoSize = true;
            lblOutstandingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOutstandingTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblOutstandingTitle.Location = new System.Drawing.Point(14, 8);
            lblOutstandingTitle.Name = "lblOutstandingTitle";
            lblOutstandingTitle.Size = new System.Drawing.Size(139, 15);
            lblOutstandingTitle.TabIndex = 0;
            lblOutstandingTitle.Text = "OUTSTANDING BALANCE";
            // 
            // pnlMetricLifetime
            // 
            pnlMetricLifetime.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            pnlMetricLifetime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricLifetime.Controls.Add(lblLifetimeVal);
            pnlMetricLifetime.Controls.Add(lblLifetimeTitle);
            pnlMetricLifetime.Location = new System.Drawing.Point(230, 4);
            pnlMetricLifetime.Name = "pnlMetricLifetime";
            pnlMetricLifetime.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            pnlMetricLifetime.Size = new System.Drawing.Size(210, 68);
            pnlMetricLifetime.TabIndex = 1;
            // 
            // lblLifetimeVal
            // 
            lblLifetimeVal.AutoSize = true;
            lblLifetimeVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLifetimeVal.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
            lblLifetimeVal.Location = new System.Drawing.Point(12, 27);
            lblLifetimeVal.Name = "lblLifetimeVal";
            lblLifetimeVal.Size = new System.Drawing.Size(68, 30);
            lblLifetimeVal.TabIndex = 1;
            lblLifetimeVal.Text = "$0.00";
            // 
            // lblLifetimeTitle
            // 
            lblLifetimeTitle.AutoSize = true;
            lblLifetimeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLifetimeTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblLifetimeTitle.Location = new System.Drawing.Point(14, 8);
            lblLifetimeTitle.Name = "lblLifetimeTitle";
            lblLifetimeTitle.Size = new System.Drawing.Size(126, 15);
            lblLifetimeTitle.TabIndex = 0;
            lblLifetimeTitle.Text = "LIFETIME REVENUE ($)";
            // 
            // pnlMetricMonth
            // 
            pnlMetricMonth.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            pnlMetricMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMetricMonth.Controls.Add(lblMonthVal);
            pnlMetricMonth.Controls.Add(lblMonthTitle);
            pnlMetricMonth.Location = new System.Drawing.Point(0, 4);
            pnlMetricMonth.Name = "pnlMetricMonth";
            pnlMetricMonth.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            pnlMetricMonth.Size = new System.Drawing.Size(210, 68);
            pnlMetricMonth.TabIndex = 0;
            // 
            // lblMonthVal
            // 
            lblMonthVal.AutoSize = true;
            lblMonthVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMonthVal.ForeColor = System.Drawing.Color.FromArgb(4, 120, 87);
            lblMonthVal.Location = new System.Drawing.Point(12, 27);
            lblMonthVal.Name = "lblMonthVal";
            lblMonthVal.Size = new System.Drawing.Size(68, 30);
            lblMonthVal.TabIndex = 1;
            lblMonthVal.Text = "$0.00";
            // 
            // lblMonthTitle
            // 
            lblMonthTitle.AutoSize = true;
            lblMonthTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMonthTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblMonthTitle.Location = new System.Drawing.Point(14, 8);
            lblMonthTitle.Name = "lblMonthTitle";
            lblMonthTitle.Size = new System.Drawing.Size(139, 15);
            lblMonthTitle.TabIndex = 0;
            lblMonthTitle.Text = "THIS MONTH'S REVENUE";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(btnResetFilters);
            pnlFilter.Controls.Add(cboMethodFilter);
            pnlFilter.Controls.Add(lblMethodFilter);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(lblToDate);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(chkEnableDateFilter);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(24, 171);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            pnlFilter.Size = new System.Drawing.Size(1032, 52);
            pnlFilter.TabIndex = 2;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnResetFilters.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnResetFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnResetFilters.Location = new System.Drawing.Point(945, 12);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new System.Drawing.Size(73, 26);
            btnResetFilters.TabIndex = 8;
            btnResetFilters.Text = "Reset";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // cboMethodFilter
            // 
            cboMethodFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMethodFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboMethodFilter.FormattingEnabled = true;
            cboMethodFilter.Location = new System.Drawing.Point(800, 14);
            cboMethodFilter.Name = "cboMethodFilter";
            cboMethodFilter.Size = new System.Drawing.Size(130, 23);
            cboMethodFilter.TabIndex = 7;
            cboMethodFilter.SelectedIndexChanged += FilterControl_Changed;
            // 
            // lblMethodFilter
            // 
            lblMethodFilter.AutoSize = true;
            lblMethodFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMethodFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblMethodFilter.Location = new System.Drawing.Point(744, 18);
            lblMethodFilter.Name = "lblMethodFilter";
            lblMethodFilter.Size = new System.Drawing.Size(52, 15);
            lblMethodFilter.TabIndex = 6;
            lblMethodFilter.Text = "Method:";
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpTo.Location = new System.Drawing.Point(620, 14);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(105, 23);
            dtpTo.TabIndex = 5;
            dtpTo.ValueChanged += FilterControl_Changed;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblToDate.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblToDate.Location = new System.Drawing.Point(592, 18);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new System.Drawing.Size(23, 15);
            lblToDate.TabIndex = 4;
            lblToDate.Text = "To:";
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFrom.Location = new System.Drawing.Point(475, 14);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(105, 23);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += FilterControl_Changed;
            // 
            // chkEnableDateFilter
            // 
            chkEnableDateFilter.AutoSize = true;
            chkEnableDateFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkEnableDateFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            chkEnableDateFilter.Location = new System.Drawing.Point(380, 16);
            chkEnableDateFilter.Name = "chkEnableDateFilter";
            chkEnableDateFilter.Size = new System.Drawing.Size(92, 19);
            chkEnableDateFilter.TabIndex = 2;
            chkEnableDateFilter.Text = "Date Range:";
            chkEnableDateFilter.UseVisualStyleBackColor = true;
            chkEnableDateFilter.CheckedChanged += chkEnableDateFilter_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(62, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search receipt #, member name or notes...";
            txtSearch.Size = new System.Drawing.Size(295, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterControl_Changed;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblSearch.Location = new System.Drawing.Point(12, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(46, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvPayments);
            pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGridContainer.Location = new System.Drawing.Point(24, 223);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            pnlGridContainer.Size = new System.Drawing.Size(1032, 447);
            pnlGridContainer.TabIndex = 3;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.BackgroundColor = System.Drawing.Color.White;
            dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.ColumnHeadersHeight = 36;
            dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colDate, colMember, colAmount, colMethod, colNotes });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvPayments.Location = new System.Drawing.Point(0, 12);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowTemplate.Height = 36;
            dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new System.Drawing.Size(1032, 435);
            dgvPayments.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Receipt #";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 80;
            // 
            // colDate
            // 
            colDate.HeaderText = "Payment Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 110;
            // 
            // colMember
            // 
            colMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colMember.HeaderText = "Member Name";
            colMember.Name = "colMember";
            colMember.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colAmount.DefaultCellStyle = dataGridViewCellStyle3;
            colAmount.HeaderText = "Amount Paid";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 120;
            // 
            // colMethod
            // 
            colMethod.HeaderText = "Method";
            colMethod.Name = "colMethod";
            colMethod.ReadOnly = true;
            colMethod.Width = 130;
            // 
            // colNotes
            // 
            colNotes.HeaderText = "Notes / Memo";
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            colNotes.Width = 250;
            // 
            // PaymentsViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlFilter);
            Controls.Add(pnlMetrics);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "PaymentsViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1080, 690);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpHeaderActions.ResumeLayout(false);
            pnlMetrics.ResumeLayout(false);
            pnlMetricOutstanding.ResumeLayout(false);
            pnlMetricOutstanding.PerformLayout();
            pnlMetricLifetime.ResumeLayout(false);
            pnlMetricLifetime.PerformLayout();
            pnlMetricMonth.ResumeLayout(false);
            pnlMetricMonth.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderActions;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlMetrics;
        private System.Windows.Forms.Panel pnlMetricMonth;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Label lblMonthVal;
        private System.Windows.Forms.Panel pnlMetricLifetime;
        private System.Windows.Forms.Label lblLifetimeTitle;
        private System.Windows.Forms.Label lblLifetimeVal;
        private System.Windows.Forms.Panel pnlMetricOutstanding;
        private System.Windows.Forms.Label lblOutstandingTitle;
        private System.Windows.Forms.Label lblOutstandingVal;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkEnableDateFilter;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblMethodFilter;
        private System.Windows.Forms.ComboBox cboMethodFilter;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}
