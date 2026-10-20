namespace GymMembershipSystem.Forms.Trainers
{
    partial class TrainersViewControl
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
            flpActions = new System.Windows.Forms.FlowLayoutPanel();
            btnAddTrainer = new System.Windows.Forms.Button();
            btnEditTrainer = new System.Windows.Forms.Button();
            btnToggleActive = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlFilter = new System.Windows.Forms.Panel();
            chkIncludeInactive = new System.Windows.Forms.CheckBox();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            dgvTrainers = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAssignedMembers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colClasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            flpActions.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpActions);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(24, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(952, 65);
            pnlHeader.TabIndex = 0;
            // 
            // flpActions
            // 
            flpActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            flpActions.Controls.Add(btnAddTrainer);
            flpActions.Controls.Add(btnEditTrainer);
            flpActions.Controls.Add(btnToggleActive);
            flpActions.Controls.Add(btnRefresh);
            flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpActions.Location = new System.Drawing.Point(412, 10);
            flpActions.Name = "flpActions";
            flpActions.Size = new System.Drawing.Size(540, 45);
            flpActions.TabIndex = 2;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAddTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddTrainer.FlatAppearance.BorderSize = 0;
            btnAddTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddTrainer.ForeColor = System.Drawing.Color.White;
            btnAddTrainer.Location = new System.Drawing.Point(408, 3);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new System.Drawing.Size(129, 34);
            btnAddTrainer.TabIndex = 0;
            btnAddTrainer.Text = "➕ New Trainer";
            btnAddTrainer.UseVisualStyleBackColor = false;
            btnAddTrainer.Click += btnAddTrainer_Click;
            // 
            // btnEditTrainer
            // 
            btnEditTrainer.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnEditTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditTrainer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnEditTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditTrainer.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnEditTrainer.Location = new System.Drawing.Point(292, 3);
            btnEditTrainer.Name = "btnEditTrainer";
            btnEditTrainer.Size = new System.Drawing.Size(110, 34);
            btnEditTrainer.TabIndex = 1;
            btnEditTrainer.Text = "✏️ Edit Details";
            btnEditTrainer.UseVisualStyleBackColor = false;
            btnEditTrainer.Click += btnEditTrainer_Click;
            // 
            // btnToggleActive
            // 
            btnToggleActive.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnToggleActive.Location = new System.Drawing.Point(167, 3);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new System.Drawing.Size(119, 34);
            btnToggleActive.TabIndex = 2;
            btnToggleActive.Text = "⚡ Deactivate";
            btnToggleActive.UseVisualStyleBackColor = false;
            btnToggleActive.Click += btnToggleActive_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new System.Drawing.Point(71, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(90, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new System.Drawing.Point(0, 34);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(378, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage certified personal trainers, specialties, and assignments.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(201, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Trainers Catalog";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(chkIncludeInactive);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(24, 85);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            pnlFilter.Size = new System.Drawing.Size(952, 45);
            pnlFilter.TabIndex = 1;
            // 
            // chkIncludeInactive
            // 
            chkIncludeInactive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkIncludeInactive.AutoSize = true;
            chkIncludeInactive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkIncludeInactive.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            chkIncludeInactive.Location = new System.Drawing.Point(785, 13);
            chkIncludeInactive.Name = "chkIncludeInactive";
            chkIncludeInactive.Size = new System.Drawing.Size(161, 19);
            chkIncludeInactive.TabIndex = 2;
            chkIncludeInactive.Text = "Show Deactivated Trainers";
            chkIncludeInactive.UseVisualStyleBackColor = true;
            chkIncludeInactive.CheckedChanged += chkIncludeInactive_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(62, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by trainer name, specialty, or phone...";
            txtSearch.Size = new System.Drawing.Size(350, 24);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSearch.Location = new System.Drawing.Point(0, 13);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(51, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // dgvTrainers
            // 
            dgvTrainers.AllowUserToAddRows = false;
            dgvTrainers.AllowUserToDeleteRows = false;
            dgvTrainers.AllowUserToResizeRows = false;
            dgvTrainers.BackgroundColor = System.Drawing.Color.White;
            dgvTrainers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTrainers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTrainers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colSpecialty, colPhone, colAssignedMembers, colClasses, colStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvTrainers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTrainers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTrainers.EnableHeadersVisualStyles = false;
            dgvTrainers.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvTrainers.Location = new System.Drawing.Point(24, 130);
            dgvTrainers.MultiSelect = false;
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.ReadOnly = true;
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.RowTemplate.Height = 40;
            dgvTrainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new System.Drawing.Size(952, 430);
            dgvTrainers.TabIndex = 2;
            dgvTrainers.CellDoubleClick += dgvTrainers_CellDoubleClick;
            dgvTrainers.SelectionChanged += dgvTrainers_SelectionChanged;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colName
            // 
            colName.HeaderText = "Trainer Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 200;
            // 
            // colSpecialty
            // 
            colSpecialty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colSpecialty.HeaderText = "Specialty";
            colSpecialty.Name = "colSpecialty";
            colSpecialty.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 150;
            // 
            // colAssignedMembers
            // 
            colAssignedMembers.HeaderText = "Assigned Members";
            colAssignedMembers.Name = "colAssignedMembers";
            colAssignedMembers.ReadOnly = true;
            colAssignedMembers.Width = 140;
            // 
            // colClasses
            // 
            colClasses.HeaderText = "Classes Scheduled";
            colClasses.Name = "colClasses";
            colClasses.ReadOnly = true;
            colClasses.Width = 140;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 100;
            // 
            // TrainersViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dgvTrainers);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "TrainersViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1000, 580);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpActions.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnAddTrainer;
        private System.Windows.Forms.Button btnEditTrainer;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkIncludeInactive;
        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
