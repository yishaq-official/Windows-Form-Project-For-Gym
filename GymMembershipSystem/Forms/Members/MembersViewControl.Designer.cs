namespace GymMembershipSystem.Forms.Members
{
    partial class MembersViewControl
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
            flpActions = new System.Windows.Forms.FlowLayoutPanel();
            btnNewMember = new System.Windows.Forms.Button();
            btnEditMember = new System.Windows.Forms.Button();
            btnAssignPlan = new System.Windows.Forms.Button();
            btnToggleActive = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlFilter = new System.Windows.Forms.Panel();
            cboStatusFilter = new System.Windows.Forms.ComboBox();
            lblStatusFilter = new System.Windows.Forms.Label();
            cboPlanFilter = new System.Windows.Forms.ComboBox();
            lblPlanFilter = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            lvwMembers = new System.Windows.Forms.ListView();
            colId = new System.Windows.Forms.ColumnHeader();
            colName = new System.Windows.Forms.ColumnHeader();
            colGender = new System.Windows.Forms.ColumnHeader();
            colAge = new System.Windows.Forms.ColumnHeader();
            colPhone = new System.Windows.Forms.ColumnHeader();
            colEmail = new System.Windows.Forms.ColumnHeader();
            colPlan = new System.Windows.Forms.ColumnHeader();
            colStatus = new System.Windows.Forms.ColumnHeader();
            colExpiry = new System.Windows.Forms.ColumnHeader();
            colJoined = new System.Windows.Forms.ColumnHeader();
            pnlHeader.SuspendLayout();
            flpActions.SuspendLayout();
            pnlFilter.SuspendLayout();
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
            flpActions.Controls.Add(btnNewMember);
            flpActions.Controls.Add(btnEditMember);
            flpActions.Controls.Add(btnAssignPlan);
            flpActions.Controls.Add(btnToggleActive);
            flpActions.Controls.Add(btnRefresh);
            flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpActions.Location = new System.Drawing.Point(342, 10);
            flpActions.Name = "flpActions";
            flpActions.Size = new System.Drawing.Size(610, 45);
            flpActions.TabIndex = 2;
            // 
            // btnNewMember
            // 
            btnNewMember.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNewMember.FlatAppearance.BorderSize = 0;
            btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNewMember.ForeColor = System.Drawing.Color.White;
            btnNewMember.Location = new System.Drawing.Point(484, 3);
            btnNewMember.Name = "btnNewMember";
            btnNewMember.Size = new System.Drawing.Size(123, 34);
            btnNewMember.TabIndex = 0;
            btnNewMember.Text = "➕ New Member";
            btnNewMember.UseVisualStyleBackColor = false;
            btnNewMember.Click += btnNewMember_Click;
            // 
            // btnEditMember
            // 
            btnEditMember.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnEditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditMember.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnEditMember.Location = new System.Drawing.Point(378, 3);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new System.Drawing.Size(100, 34);
            btnEditMember.TabIndex = 1;
            btnEditMember.Text = "✏️ Edit Profile";
            btnEditMember.UseVisualStyleBackColor = false;
            btnEditMember.Click += btnEditMember_Click;
            // 
            // btnAssignPlan
            // 
            btnAssignPlan.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnAssignPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAssignPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnAssignPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAssignPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAssignPlan.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            btnAssignPlan.Location = new System.Drawing.Point(267, 3);
            btnAssignPlan.Name = "btnAssignPlan";
            btnAssignPlan.Size = new System.Drawing.Size(105, 34);
            btnAssignPlan.TabIndex = 2;
            btnAssignPlan.Text = "📋 Assign Plan";
            btnAssignPlan.UseVisualStyleBackColor = false;
            btnAssignPlan.Click += btnAssignPlan_Click;
            // 
            // btnToggleActive
            // 
            btnToggleActive.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnToggleActive.Location = new System.Drawing.Point(142, 3);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new System.Drawing.Size(119, 34);
            btnToggleActive.TabIndex = 3;
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
            btnRefresh.Location = new System.Drawing.Point(46, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(90, 34);
            btnRefresh.TabIndex = 4;
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
            lblSubtitle.Size = new System.Drawing.Size(328, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Comprehensive member directory, plans, and profiles.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(236, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Members Directory";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboStatusFilter);
            pnlFilter.Controls.Add(lblStatusFilter);
            pnlFilter.Controls.Add(cboPlanFilter);
            pnlFilter.Controls.Add(lblPlanFilter);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(24, 85);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            pnlFilter.Size = new System.Drawing.Size(952, 45);
            pnlFilter.TabIndex = 1;
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Location = new System.Drawing.Point(690, 10);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new System.Drawing.Size(150, 24);
            cboStatusFilter.TabIndex = 5;
            cboStatusFilter.SelectedIndexChanged += cboStatusFilter_SelectedIndexChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblStatusFilter.Location = new System.Drawing.Point(640, 14);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new System.Drawing.Size(43, 15);
            lblStatusFilter.TabIndex = 4;
            lblStatusFilter.Text = "Status:";
            // 
            // cboPlanFilter
            // 
            cboPlanFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPlanFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboPlanFilter.FormattingEnabled = true;
            cboPlanFilter.Location = new System.Drawing.Point(435, 10);
            cboPlanFilter.Name = "cboPlanFilter";
            cboPlanFilter.Size = new System.Drawing.Size(185, 24);
            cboPlanFilter.TabIndex = 3;
            cboPlanFilter.SelectedIndexChanged += cboPlanFilter_SelectedIndexChanged;
            // 
            // lblPlanFilter
            // 
            lblPlanFilter.AutoSize = true;
            lblPlanFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlanFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPlanFilter.Location = new System.Drawing.Point(395, 14);
            lblPlanFilter.Name = "lblPlanFilter";
            lblPlanFilter.Size = new System.Drawing.Size(33, 15);
            lblPlanFilter.TabIndex = 2;
            lblPlanFilter.Text = "Plan:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(62, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, Name, Phone, or Email...";
            txtSearch.Size = new System.Drawing.Size(310, 24);
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
            // lvwMembers
            // 
            lvwMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colId, colName, colGender, colAge, colPhone, colEmail, colPlan, colStatus, colExpiry, colJoined });
            lvwMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            lvwMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lvwMembers.FullRowSelect = true;
            lvwMembers.GridLines = true;
            lvwMembers.Location = new System.Drawing.Point(24, 130);
            lvwMembers.MultiSelect = false;
            lvwMembers.Name = "lvwMembers";
            lvwMembers.Size = new System.Drawing.Size(952, 430);
            lvwMembers.TabIndex = 2;
            lvwMembers.UseCompatibleStateImageBehavior = false;
            lvwMembers.View = System.Windows.Forms.View.Details;
            lvwMembers.ColumnClick += lvwMembers_ColumnClick;
            lvwMembers.SelectedIndexChanged += lvwMembers_SelectedIndexChanged;
            lvwMembers.DoubleClick += lvwMembers_DoubleClick;
            // 
            // colId
            // 
            colId.Text = "ID";
            // 
            // colName
            // 
            colName.Text = "Full Name";
            colName.Width = 180;
            // 
            // colGender
            // 
            colGender.Text = "Gender";
            colGender.Width = 70;
            // 
            // colAge
            // 
            colAge.Text = "Age";
            colAge.Width = 50;
            // 
            // colPhone
            // 
            colPhone.Text = "Phone";
            colPhone.Width = 120;
            // 
            // colEmail
            // 
            colEmail.Text = "Email Address";
            colEmail.Width = 180;
            // 
            // colPlan
            // 
            colPlan.Text = "Current Plan";
            colPlan.Width = 140;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 90;
            // 
            // colExpiry
            // 
            colExpiry.Text = "Expiry Date";
            colExpiry.Width = 100;
            // 
            // colJoined
            // 
            colJoined.Text = "Joined Date";
            colJoined.Width = 90;
            // 
            // MembersViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(lvwMembers);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "MembersViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1000, 580);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpActions.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAssignPlan;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPlanFilter;
        private System.Windows.Forms.ComboBox cboPlanFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.ListView lvwMembers;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPlan;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colExpiry;
        private System.Windows.Forms.ColumnHeader colJoined;
    }
}
