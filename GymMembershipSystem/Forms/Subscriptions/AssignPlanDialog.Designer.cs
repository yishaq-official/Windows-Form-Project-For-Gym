namespace GymMembershipSystem.Forms.Subscriptions
{
    partial class AssignPlanDialog
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblDialogTitle = new System.Windows.Forms.Label();
            pnlMemberInfo = new System.Windows.Forms.Panel();
            lblCurrentStatus = new System.Windows.Forms.Label();
            lblMemberName = new System.Windows.Forms.Label();
            lblSelectPlan = new System.Windows.Forms.Label();
            cboPlan = new System.Windows.Forms.ComboBox();
            lblStartDate = new System.Windows.Forms.Label();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            pnlPreview = new System.Windows.Forms.Panel();
            lblPrice = new System.Windows.Forms.Label();
            lblCalculatedExpiry = new System.Windows.Forms.Label();
            lblTrainer = new System.Windows.Forms.Label();
            cboTrainer = new System.Windows.Forms.ComboBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlMemberInfo.SuspendLayout();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblDialogTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(460, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.AutoSize = true;
            lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDialogTitle.ForeColor = System.Drawing.Color.White;
            lblDialogTitle.Location = new System.Drawing.Point(24, 18);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new System.Drawing.Size(225, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Assign Membership Plan";
            // 
            // pnlMemberInfo
            // 
            pnlMemberInfo.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            pnlMemberInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMemberInfo.Controls.Add(lblCurrentStatus);
            pnlMemberInfo.Controls.Add(lblMemberName);
            pnlMemberInfo.Location = new System.Drawing.Point(28, 75);
            pnlMemberInfo.Name = "pnlMemberInfo";
            pnlMemberInfo.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            pnlMemberInfo.Size = new System.Drawing.Size(404, 60);
            pnlMemberInfo.TabIndex = 1;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblCurrentStatus.Location = new System.Drawing.Point(12, 33);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new System.Drawing.Size(127, 15);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status: No Plan";
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMemberName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblMemberName.Location = new System.Drawing.Point(12, 10);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new System.Drawing.Size(104, 19);
            lblMemberName.TabIndex = 0;
            lblMemberName.Text = "Member Name";
            // 
            // lblSelectPlan
            // 
            lblSelectPlan.AutoSize = true;
            lblSelectPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSelectPlan.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSelectPlan.Location = new System.Drawing.Point(28, 150);
            lblSelectPlan.Name = "lblSelectPlan";
            lblSelectPlan.Size = new System.Drawing.Size(142, 15);
            lblSelectPlan.TabIndex = 2;
            lblSelectPlan.Text = "Select Membership Plan:";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPlan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new System.Drawing.Point(28, 170);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new System.Drawing.Size(404, 24);
            cboPlan.TabIndex = 3;
            cboPlan.SelectedIndexChanged += cboPlan_SelectedIndexChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStartDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblStartDate.Location = new System.Drawing.Point(28, 205);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(63, 15);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpStartDate.Location = new System.Drawing.Point(28, 225);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(190, 24);
            dtpStartDate.TabIndex = 5;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // pnlPreview
            // 
            pnlPreview.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlPreview.Controls.Add(lblPrice);
            pnlPreview.Controls.Add(lblCalculatedExpiry);
            pnlPreview.Location = new System.Drawing.Point(28, 262);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            pnlPreview.Size = new System.Drawing.Size(404, 60);
            pnlPreview.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrice.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            lblPrice.Location = new System.Drawing.Point(12, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(89, 17);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price: $0.00";
            // 
            // lblCalculatedExpiry
            // 
            lblCalculatedExpiry.AutoSize = true;
            lblCalculatedExpiry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCalculatedExpiry.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
            lblCalculatedExpiry.Location = new System.Drawing.Point(12, 10);
            lblCalculatedExpiry.Name = "lblCalculatedExpiry";
            lblCalculatedExpiry.Size = new System.Drawing.Size(161, 19);
            lblCalculatedExpiry.TabIndex = 0;
            lblCalculatedExpiry.Text = "Calculated Expiry Date:";
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTrainer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTrainer.Location = new System.Drawing.Point(28, 335);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new System.Drawing.Size(183, 15);
            lblTrainer.TabIndex = 7;
            lblTrainer.Text = "Assign Personal Trainer (Optional):";
            // 
            // cboTrainer
            // 
            cboTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTrainer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTrainer.FormattingEnabled = true;
            cboTrainer.Location = new System.Drawing.Point(28, 355);
            cboTrainer.Name = "cboTrainer";
            cboTrainer.Size = new System.Drawing.Size(404, 24);
            cboTrainer.TabIndex = 8;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirm.ForeColor = System.Drawing.Color.White;
            btnConfirm.Location = new System.Drawing.Point(171, 425);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(155, 36);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm Subscription";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnCancel.Location = new System.Drawing.Point(332, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new System.Drawing.Point(28, 390);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(404, 30);
            lblErrorMessage.TabIndex = 11;
            lblErrorMessage.Visible = false;
            // 
            // AssignPlanDialog
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(460, 480);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cboTrainer);
            Controls.Add(lblTrainer);
            Controls.Add(pnlPreview);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(cboPlan);
            Controls.Add(lblSelectPlan);
            Controls.Add(pnlMemberInfo);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AssignPlanDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Assign Membership Plan";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMemberInfo.ResumeLayout(false);
            pnlMemberInfo.PerformLayout();
            pnlPreview.ResumeLayout(false);
            pnlPreview.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Panel pnlMemberInfo;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblSelectPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblCalculatedExpiry;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.ComboBox cboTrainer;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}
