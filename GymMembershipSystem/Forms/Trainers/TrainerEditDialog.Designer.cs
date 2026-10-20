namespace GymMembershipSystem.Forms.Trainers
{
    partial class TrainerEditDialog
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
            components = new System.ComponentModel.Container();
            pnlHeader = new System.Windows.Forms.Panel();
            lblDialogTitle = new System.Windows.Forms.Label();
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblSpecialty = new System.Windows.Forms.Label();
            cboSpecialty = new System.Windows.Forms.ComboBox();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            chkIsActive = new System.Windows.Forms.CheckBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblDialogTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(430, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.AutoSize = true;
            lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDialogTitle.ForeColor = System.Drawing.Color.White;
            lblDialogTitle.Location = new System.Drawing.Point(24, 18);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new System.Drawing.Size(126, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Trainer Profile";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblFullName.Location = new System.Drawing.Point(28, 80);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(64, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullName.Location = new System.Drawing.Point(31, 100);
            txtFullName.MaxLength = 60;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(365, 24);
            txtFullName.TabIndex = 2;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSpecialty.Location = new System.Drawing.Point(28, 140);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new System.Drawing.Size(103, 15);
            lblSpecialty.TabIndex = 3;
            lblSpecialty.Text = "Fitness Specialty:";
            // 
            // cboSpecialty
            // 
            cboSpecialty.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboSpecialty.FormattingEnabled = true;
            cboSpecialty.Items.AddRange(new object[] {
            "Strength & Conditioning",
            "Bodybuilding & Hypertrophy",
            "Cardio & HIIT Conditioning",
            "Yoga & Flexibility",
            "Pilates & Core Rehab",
            "CrossFit & Functional Fitness",
            "Boxing & Martial Arts"});
            cboSpecialty.Location = new System.Drawing.Point(31, 160);
            cboSpecialty.MaxLength = 60;
            cboSpecialty.Name = "cboSpecialty";
            cboSpecialty.Size = new System.Drawing.Size(365, 24);
            cboSpecialty.TabIndex = 4;
            cboSpecialty.Validating += cboSpecialty_Validating;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPhone.Location = new System.Drawing.Point(28, 200);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(91, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Location = new System.Drawing.Point(31, 220);
            txtPhone.MaxLength = 30;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(365, 24);
            txtPhone.TabIndex = 6;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            chkIsActive.Location = new System.Drawing.Point(31, 260);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(207, 19);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "Active (available for assignments)";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(180, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(110, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Trainer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnCancel.Location = new System.Drawing.Point(296, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new System.Drawing.Point(31, 286);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(365, 23);
            lblErrorMessage.TabIndex = 10;
            lblErrorMessage.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // TrainerEditDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(430, 370);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(cboSpecialty);
            Controls.Add(lblSpecialty);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerEditDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Trainer Details";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.ComboBox cboSpecialty;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
