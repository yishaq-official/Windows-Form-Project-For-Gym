namespace GymMembershipSystem.Forms.Members
{
    partial class MemberEditDialog
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
            lblGender = new System.Windows.Forms.Label();
            cboGender = new System.Windows.Forms.ComboBox();
            lblDob = new System.Windows.Forms.Label();
            dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            lblJoinDate = new System.Windows.Forms.Label();
            dtpJoinDate = new System.Windows.Forms.DateTimePicker();
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
            lblDialogTitle.Size = new System.Drawing.Size(185, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Member Registration";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblFullName.Location = new System.Drawing.Point(28, 75);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(64, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullName.Location = new System.Drawing.Point(31, 95);
            txtFullName.MaxLength = 80;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(395, 24);
            txtFullName.TabIndex = 2;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGender.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblGender.Location = new System.Drawing.Point(28, 130);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(48, 15);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGender.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboGender.FormattingEnabled = true;
            cboGender.Location = new System.Drawing.Point(31, 150);
            cboGender.Name = "cboGender";
            cboGender.Size = new System.Drawing.Size(185, 24);
            cboGender.TabIndex = 4;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDob.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDob.Location = new System.Drawing.Point(238, 130);
            lblDob.Name = "lblDob";
            lblDob.Size = new System.Drawing.Size(77, 15);
            lblDob.TabIndex = 5;
            lblDob.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new System.Drawing.Point(241, 150);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new System.Drawing.Size(185, 24);
            dtpDateOfBirth.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPhone.Location = new System.Drawing.Point(28, 185);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(91, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Location = new System.Drawing.Point(31, 205);
            txtPhone.MaxLength = 30;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(185, 24);
            txtPhone.TabIndex = 8;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblEmail.Location = new System.Drawing.Point(238, 185);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(84, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(241, 205);
            txtEmail.MaxLength = 80;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(185, 24);
            txtEmail.TabIndex = 10;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblAddress.Location = new System.Drawing.Point(28, 240);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(117, 15);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Residential Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAddress.Location = new System.Drawing.Point(31, 260);
            txtAddress.MaxLength = 200;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(395, 50);
            txtAddress.TabIndex = 12;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblJoinDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblJoinDate.Location = new System.Drawing.Point(28, 320);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new System.Drawing.Size(59, 15);
            lblJoinDate.TabIndex = 13;
            lblJoinDate.Text = "Join Date:";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpJoinDate.Location = new System.Drawing.Point(31, 340);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new System.Drawing.Size(185, 24);
            dtpJoinDate.TabIndex = 14;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            chkIsActive.Location = new System.Drawing.Point(241, 343);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(139, 19);
            chkIsActive.TabIndex = 15;
            chkIsActive.Text = "Active Member Profile";
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
            btnSave.Location = new System.Drawing.Point(201, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(115, 34);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save Member";
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
            btnCancel.Location = new System.Drawing.Point(322, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(104, 34);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new System.Drawing.Point(31, 372);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(395, 23);
            lblErrorMessage.TabIndex = 18;
            lblErrorMessage.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // MemberEditDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(460, 455);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(dtpJoinDate);
            Controls.Add(lblJoinDate);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDob);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemberEditDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Member Details";
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
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
