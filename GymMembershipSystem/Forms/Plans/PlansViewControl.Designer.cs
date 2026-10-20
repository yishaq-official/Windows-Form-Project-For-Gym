namespace GymMembershipSystem.Forms.Plans
{
    partial class PlansViewControl
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
            btnAddPlan = new System.Windows.Forms.Button();
            btnEditPlan = new System.Windows.Forms.Button();
            btnToggleActive = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            chkIncludeInactive = new System.Windows.Forms.CheckBox();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            dgvPlans = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colActiveSubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            flpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(952, 90);
            pnlHeader.TabIndex = 0;
            // 
            // flpActions
            // 
            flpActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            flpActions.Controls.Add(btnAddPlan);
            flpActions.Controls.Add(btnEditPlan);
            flpActions.Controls.Add(btnToggleActive);
            flpActions.Controls.Add(btnRefresh);
            flpActions.Controls.Add(chkIncludeInactive);
            flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpActions.Location = new System.Drawing.Point(352, 10);
            flpActions.Name = "flpActions";
            flpActions.Size = new System.Drawing.Size(600, 75);
            flpActions.TabIndex = 2;
            // 
            // btnAddPlan
            // 
            btnAddPlan.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAddPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddPlan.FlatAppearance.BorderSize = 0;
            btnAddPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddPlan.ForeColor = System.Drawing.Color.White;
            btnAddPlan.Location = new System.Drawing.Point(475, 3);
            btnAddPlan.Name = "btnAddPlan";
            btnAddPlan.Size = new System.Drawing.Size(122, 34);
            btnAddPlan.TabIndex = 0;
            btnAddPlan.Text = "➕ New Plan";
            btnAddPlan.UseVisualStyleBackColor = false;
            btnAddPlan.Click += btnAddPlan_Click;
            // 
            // btnEditPlan
            // 
            btnEditPlan.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnEditPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnEditPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditPlan.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnEditPlan.Location = new System.Drawing.Point(369, 3);
            btnEditPlan.Name = "btnEditPlan";
            btnEditPlan.Size = new System.Drawing.Size(100, 34);
            btnEditPlan.TabIndex = 1;
            btnEditPlan.Text = "✏️ Edit Plan";
            btnEditPlan.UseVisualStyleBackColor = false;
            btnEditPlan.Click += btnEditPlan_Click;
            // 
            // btnToggleActive
            // 
            btnToggleActive.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnToggleActive.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnToggleActive.Location = new System.Drawing.Point(234, 3);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new System.Drawing.Size(129, 34);
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
            btnRefresh.Location = new System.Drawing.Point(138, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(90, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // chkIncludeInactive
            // 
            chkIncludeInactive.AutoSize = true;
            chkIncludeInactive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkIncludeInactive.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            chkIncludeInactive.Location = new System.Drawing.Point(448, 43);
            chkIncludeInactive.Margin = new System.Windows.Forms.Padding(0, 3, 5, 0);
            chkIncludeInactive.Name = "chkIncludeInactive";
            chkIncludeInactive.Size = new System.Drawing.Size(147, 19);
            chkIncludeInactive.TabIndex = 4;
            chkIncludeInactive.Text = "Show Deactivated Plans";
            chkIncludeInactive.UseVisualStyleBackColor = true;
            chkIncludeInactive.CheckedChanged += chkIncludeInactive_CheckedChanged;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new System.Drawing.Point(0, 34);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(350, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Configure membership tiers, duration periods, and pricing.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(228, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Membership Plans";
            // 
            // dgvPlans
            // 
            dgvPlans.AllowUserToAddRows = false;
            dgvPlans.AllowUserToDeleteRows = false;
            dgvPlans.AllowUserToResizeRows = false;
            dgvPlans.BackgroundColor = System.Drawing.Color.White;
            dgvPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPlans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPlans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colDuration, colPrice, colActiveSubs, colStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPlans.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPlans.EnableHeadersVisualStyles = false;
            dgvPlans.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvPlans.Location = new System.Drawing.Point(24, 110);
            dgvPlans.MultiSelect = false;
            dgvPlans.Name = "dgvPlans";
            dgvPlans.ReadOnly = true;
            dgvPlans.RowHeadersVisible = false;
            dgvPlans.RowTemplate.Height = 40;
            dgvPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPlans.Size = new System.Drawing.Size(952, 450);
            dgvPlans.TabIndex = 1;
            dgvPlans.CellDoubleClick += dgvPlans_CellDoubleClick;
            dgvPlans.SelectionChanged += dgvPlans_SelectionChanged;
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
            colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Plan Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Duration (Days)";
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            colDuration.Width = 140;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price ($)";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 120;
            // 
            // colActiveSubs
            // 
            colActiveSubs.HeaderText = "Active Subscribers";
            colActiveSubs.Name = "colActiveSubs";
            colActiveSubs.ReadOnly = true;
            colActiveSubs.Width = 160;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 110;
            // 
            // PlansViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dgvPlans);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "PlansViewControl";
            Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            Size = new System.Drawing.Size(1000, 580);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpActions.ResumeLayout(false);
            flpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnEditPlan;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkIncludeInactive;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveSubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
