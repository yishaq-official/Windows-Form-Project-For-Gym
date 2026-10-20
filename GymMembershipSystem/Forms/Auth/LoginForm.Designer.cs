namespace GymMembershipSystem.Forms.Auth
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            lblDemoHint = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(440, 95);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubtitle.Location = new System.Drawing.Point(32, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(262, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Administrator Desktop Management Portal";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(326, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblUsername.Location = new System.Drawing.Point(32, 125);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(72, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsername.Location = new System.Drawing.Point(35, 147);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(360, 26);
            txtUsername.TabIndex = 2;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPassword.Location = new System.Drawing.Point(32, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(69, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(35, 212);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(360, 26);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            chkShowPassword.Location = new System.Drawing.Point(35, 248);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new System.Drawing.Size(108, 19);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(35, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(175, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnCancel.Location = new System.Drawing.Point(220, 305);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(175, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new System.Drawing.Point(35, 273);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(360, 24);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.Text = "Invalid username or password.";
            lblErrorMessage.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // lblDemoHint
            // 
            lblDemoHint.AutoSize = true;
            lblDemoHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblDemoHint.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDemoHint.Location = new System.Drawing.Point(35, 360);
            lblDemoHint.Name = "lblDemoHint";
            lblDemoHint.Size = new System.Drawing.Size(189, 13);
            lblDemoHint.TabIndex = 9;
            lblDemoHint.Text = "Demo admin credentials: admin / admin123";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(440, 395);
            Controls.Add(lblDemoHint);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gym Management System - Admin Login";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblDemoHint;
    }
}
