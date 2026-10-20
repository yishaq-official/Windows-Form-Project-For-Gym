using System;
using System.ComponentModel;
using System.Windows.Forms;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;

        public LoginForm(IAuthService? authService = null)
        {
            InitializeComponent();
            _authService = authService ?? new AuthService();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username is required.");
            }
            else
            {
                errorProvider.SetError(txtUsername, string.Empty);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required.");
            }
            else
            {
                errorProvider.SetError(txtPassword, string.Empty);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            // Trigger field validations
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            var result = _authService.Authenticate(username, password);

            if (result.IsFailure)
            {
                lblErrorMessage.Text = result.Error;
                lblErrorMessage.Visible = true;
                txtPassword.Focus();
                txtPassword.SelectAll();
                return;
            }

            // Authentication succeeded, session is set
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
