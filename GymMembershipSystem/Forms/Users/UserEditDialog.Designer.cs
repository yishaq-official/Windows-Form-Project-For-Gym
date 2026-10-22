namespace GymMembershipSystem.Forms.Users
{
    partial class UserEditDialog
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
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblRole = new System.Windows.Forms.Label();
            cboRole = new System.Windows.Forms.ComboBox();
            chkIsActive = new System.Windows.Forms.CheckBox();
            chkChangePassword = new System.Windows.Forms.CheckBox();
            pnlPasswordFields = new System.Windows.Forms.Panel();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblErrorMessage = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlPasswordFields.SuspendLayout();
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
            lblDialogTitle.Size = new System.Drawing.Size(187, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Create User Account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblUsername.Location = new System.Drawing.Point(28, 76);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(63, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsername.Location = new System.Drawing.Point(31, 96);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(395, 24);
            txtUsername.TabIndex = 2;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblFullName.Location = new System.Drawing.Point(28, 134);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(64, 15);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullName.Location = new System.Drawing.Point(31, 154);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(395, 24);
            txtFullName.TabIndex = 4;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblRole.Location = new System.Drawing.Point(28, 192);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(109, 15);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role / Access Level:";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboRole.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboRole.FormattingEnabled = true;
            cboRole.Location = new System.Drawing.Point(31, 212);
            cboRole.Name = "cboRole";
            cboRole.Size = new System.Drawing.Size(240, 24);
            cboRole.TabIndex = 6;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            chkIsActive.Location = new System.Drawing.Point(290, 214);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(117, 19);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "Account is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // chkChangePassword
            // 
            chkChangePassword.AutoSize = true;
            chkChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkChangePassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            chkChangePassword.Location = new System.Drawing.Point(31, 252);
            chkChangePassword.Name = "chkChangePassword";
            chkChangePassword.Size = new System.Drawing.Size(143, 19);
            chkChangePassword.TabIndex = 8;
            chkChangePassword.Text = "Set / Reset Password";
            chkChangePassword.UseVisualStyleBackColor = true;
            chkChangePassword.CheckedChanged += chkChangePassword_CheckedChanged;
            // 
            // pnlPasswordFields
            // 
            pnlPasswordFields.Controls.Add(txtConfirmPassword);
            pnlPasswordFields.Controls.Add(lblConfirmPassword);
            pnlPasswordFields.Controls.Add(txtPassword);
            pnlPasswordFields.Controls.Add(lblPassword);
            pnlPasswordFields.Location = new System.Drawing.Point(26, 276);
            pnlPasswordFields.Name = "pnlPasswordFields";
            pnlPasswordFields.Size = new System.Drawing.Size(410, 116);
            pnlPasswordFields.TabIndex = 9;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfirmPassword.Location = new System.Drawing.Point(5, 80);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(395, 24);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblConfirmPassword.Location = new System.Drawing.Point(2, 60);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(107, 15);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(5, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(395, 24);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPassword.Location = new System.Drawing.Point(2, 5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(60, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new System.Drawing.Point(31, 400);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(84, 15);
            lblErrorMessage.TabIndex = 10;
            lblErrorMessage.Text = "[ErrorMessage]";
            lblErrorMessage.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(306, 426);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(120, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save Account";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnCancel.Location = new System.Drawing.Point(200, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // UserEditDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(460, 484);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlPasswordFields);
            Controls.Add(chkChangePassword);
            Controls.Add(chkIsActive);
            Controls.Add(cboRole);
            Controls.Add(lblRole);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEditDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "User Account Editor";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlPasswordFields.ResumeLayout(false);
            pnlPasswordFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.CheckBox chkChangePassword;
        private System.Windows.Forms.Panel pnlPasswordFields;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
