namespace GymMembershipSystem.Forms.Users
{
    partial class UsersViewControl
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
            btnNewUser = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();

            pnlFilter = new System.Windows.Forms.Panel();
            btnResetFilters = new System.Windows.Forms.Button();
            cboRoleFilter = new System.Windows.Forms.ComboBox();
            lblRoleFilter = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();

            pnlGridContainer = new System.Windows.Forms.Panel();
            dgvUsers = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();

            pnlBottomActions = new System.Windows.Forms.Panel();
            flpBottomActions = new System.Windows.Forms.FlowLayoutPanel();
            btnToggleActive = new System.Windows.Forms.Button();
            btnResetPassword = new System.Windows.Forms.Button();
            btnEditUser = new System.Windows.Forms.Button();

            pnlHeader.SuspendLayout();
            flpHeaderActions.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlBottomActions.SuspendLayout();
            flpBottomActions.SuspendLayout();
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
            flpHeaderActions.Controls.Add(btnNewUser);
            flpHeaderActions.Controls.Add(btnRefresh);
            flpHeaderActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpHeaderActions.Location = new System.Drawing.Point(680, 10);
            flpHeaderActions.Name = "flpHeaderActions";
            flpHeaderActions.Size = new System.Drawing.Size(352, 45);
            flpHeaderActions.TabIndex = 2;

            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNewUser.ForeColor = System.Drawing.Color.White;
            btnNewUser.Location = new System.Drawing.Point(222, 3);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new System.Drawing.Size(127, 34);
            btnNewUser.TabIndex = 0;
            btnNewUser.Text = "➕ Add User";
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;

            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new System.Drawing.Point(120, 3);
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
            lblSubtitle.Size = new System.Drawing.Size(534, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage authenticated system user accounts, login credentials, and permission access levels";

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(206, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Management";

            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(btnResetFilters);
            pnlFilter.Controls.Add(cboRoleFilter);
            pnlFilter.Controls.Add(lblRoleFilter);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(24, 85);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            pnlFilter.Size = new System.Drawing.Size(1032, 54);
            pnlFilter.TabIndex = 1;

            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = System.Drawing.Color.White;
            btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            btnResetFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnResetFilters.Location = new System.Drawing.Point(540, 13);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new System.Drawing.Size(85, 26);
            btnResetFilters.TabIndex = 4;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;

            // 
            // cboRoleFilter
            // 
            cboRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboRoleFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboRoleFilter.FormattingEnabled = true;
            cboRoleFilter.Location = new System.Drawing.Point(360, 15);
            cboRoleFilter.Name = "cboRoleFilter";
            cboRoleFilter.Size = new System.Drawing.Size(160, 23);
            cboRoleFilter.TabIndex = 3;
            cboRoleFilter.SelectedIndexChanged += FilterControl_Changed;

            // 
            // lblRoleFilter
            // 
            lblRoleFilter.AutoSize = true;
            lblRoleFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRoleFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblRoleFilter.Location = new System.Drawing.Point(318, 18);
            lblRoleFilter.Name = "lblRoleFilter";
            lblRoleFilter.Size = new System.Drawing.Size(34, 15);
            lblRoleFilter.TabIndex = 2;
            lblRoleFilter.Text = "Role:";

            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(70, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by username or name...";
            txtSearch.Size = new System.Drawing.Size(225, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterControl_Changed;

            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblSearch.Location = new System.Drawing.Point(14, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(46, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";

            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvUsers);
            pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGridContainer.Location = new System.Drawing.Point(24, 139);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            pnlGridContainer.Size = new System.Drawing.Size(1032, 513);
            pnlGridContainer.TabIndex = 2;

            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 38;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colId,
                colUsername,
                colFullName,
                colRole,
                colStatus,
                colCreatedAt
            });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvUsers.Location = new System.Drawing.Point(0, 12);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 36;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(1032, 489);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;

            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 50;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;

            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 120;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 160;

            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 140;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 220;

            // 
            // colRole
            // 
            colRole.DataPropertyName = "Role";
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 100;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 140;

            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "StatusDisplay";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 100;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 140;

            // 
            // colCreatedAt
            // 
            colCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colCreatedAt.DataPropertyName = "CreatedAtDisplay";
            colCreatedAt.HeaderText = "Account Created";
            colCreatedAt.MinimumWidth = 140;
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;

            // 
            // pnlBottomActions
            // 
            pnlBottomActions.Controls.Add(flpBottomActions);
            pnlBottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottomActions.Location = new System.Drawing.Point(24, 652);
            pnlBottomActions.Name = "pnlBottomActions";
            pnlBottomActions.Size = new System.Drawing.Size(1032, 48);
            pnlBottomActions.TabIndex = 3;

            // 
            // flpBottomActions
            // 
            flpBottomActions.Controls.Add(btnToggleActive);
            flpBottomActions.Controls.Add(btnResetPassword);
            flpBottomActions.Controls.Add(btnEditUser);
            flpBottomActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flpBottomActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpBottomActions.Location = new System.Drawing.Point(0, 0);
            flpBottomActions.Name = "flpBottomActions";
            flpBottomActions.Size = new System.Drawing.Size(1032, 48);
            flpBottomActions.TabIndex = 0;

            // 
            // btnToggleActive
            // 
            btnToggleActive.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnToggleActive.Location = new System.Drawing.Point(862, 3);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new System.Drawing.Size(167, 36);
            btnToggleActive.TabIndex = 2;
            btnToggleActive.Text = "🔄 Toggle Active / Deactivate";
            btnToggleActive.UseVisualStyleBackColor = false;
            btnToggleActive.Click += btnToggleActive_Click;

            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            btnResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnResetPassword.Location = new System.Drawing.Point(715, 3);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new System.Drawing.Size(141, 36);
            btnResetPassword.TabIndex = 1;
            btnResetPassword.Text = "🔑 Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;

            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditUser.ForeColor = System.Drawing.Color.White;
            btnEditUser.Location = new System.Drawing.Point(588, 3);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new System.Drawing.Size(121, 36);
            btnEditUser.TabIndex = 0;
            btnEditUser.Text = "✏️ Edit Account";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;

            // 
            // UsersViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlBottomActions);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Name = "UsersViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1080, 720);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpHeaderActions.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlBottomActions.ResumeLayout(false);
            flpBottomActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderActions;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.ComboBox cboRoleFilter;
        private System.Windows.Forms.Label lblRoleFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;

        private System.Windows.Forms.Panel pnlBottomActions;
        private System.Windows.Forms.FlowLayoutPanel flpBottomActions;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnEditUser;
    }
}
