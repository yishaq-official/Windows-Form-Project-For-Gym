using System;
using System.ComponentModel;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Users
{
    public partial class UserEditDialog : Form
    {
        private readonly IUserService _userService;
        private readonly User? _existingUser;

        public User? CreatedOrUpdatedUser { get; private set; }

        public UserEditDialog(User? userToEdit = null, IUserService? userService = null)
        {
            InitializeComponent();
            _userService = userService ?? new UserService();
            _existingUser = userToEdit;

            PopulateRoleDropdown();
            ConfigureMode();
        }

        private void PopulateRoleDropdown()
        {
            cboRole.Items.Clear();
            foreach (var role in Enum.GetValues<UserRole>())
            {
                cboRole.Items.Add(role);
            }
            cboRole.SelectedItem = UserRole.Member;
        }

        private void ConfigureMode()
        {
            if (_existingUser == null)
            {
                // Create Mode
                lblDialogTitle.Text = "Create User Account";
                txtUsername.ReadOnly = false;
                chkChangePassword.Visible = false;
                pnlPasswordFields.Visible = true;
                chkIsActive.Checked = true;
                cboRole.SelectedItem = UserRole.Member;
            }
            else
            {
                // Edit Mode
                lblDialogTitle.Text = $"Edit User: {_existingUser.Username}";
                txtUsername.Text = _existingUser.Username;
                txtUsername.ReadOnly = true;
                txtFullName.Text = _existingUser.FullName;
                cboRole.SelectedItem = _existingUser.Role;
                chkIsActive.Checked = _existingUser.IsActive;

                // Self-deactivation / Self-demotion guard
                if (UserSession.CurrentUser?.Id == _existingUser.Id)
                {
                    chkIsActive.Enabled = false;
                    cboRole.Enabled = false;
                }

                chkChangePassword.Visible = true;
                chkChangePassword.Checked = false;
                pnlPasswordFields.Visible = false;
            }
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            pnlPasswordFields.Visible = chkChangePassword.Checked;
            if (!chkChangePassword.Checked)
            {
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                errorProvider.SetError(txtPassword, string.Empty);
                errorProvider.SetError(txtConfirmPassword, string.Empty);
            }
        }

        #region Validation Handlers

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (_existingUser != null) return; // Read-only in edit mode

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username is required.");
                e.Cancel = true;
            }
            else if (txtUsername.Text.Trim().Length < 3)
            {
                errorProvider.SetError(txtUsername, "Username must be at least 3 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, string.Empty);
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Full name is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFullName, string.Empty);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            bool passwordRequired = _existingUser == null || chkChangePassword.Checked;
            if (!passwordRequired)
            {
                errorProvider.SetError(txtPassword, string.Empty);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required.");
                e.Cancel = true;
            }
            else if (txtPassword.Text.Length < 6)
            {
                errorProvider.SetError(txtPassword, "Password must be at least 6 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, string.Empty);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            bool passwordRequired = _existingUser == null || chkChangePassword.Checked;
            if (!passwordRequired)
            {
                errorProvider.SetError(txtConfirmPassword, string.Empty);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, string.Empty);
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (!ValidateChildren())
            {
                return;
            }

            var role = (UserRole)cboRole.SelectedItem!;
            string fullName = txtFullName.Text.Trim();

            if (_existingUser == null)
            {
                // Create user
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                var result = _userService.CreateUser(username, password, fullName, role);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }

                CreatedOrUpdatedUser = result.Value;
            }
            else
            {
                // Update profile & role
                bool isActive = chkIsActive.Checked;
                var updateResult = _userService.UpdateUser(_existingUser.Id, fullName, role, isActive);
                if (updateResult.IsFailure)
                {
                    lblErrorMessage.Text = updateResult.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }

                // Password change if requested
                if (chkChangePassword.Checked)
                {
                    var resetResult = _userService.ResetPassword(_existingUser.Id, txtPassword.Text);
                    if (resetResult.IsFailure)
                    {
                        lblErrorMessage.Text = resetResult.Error;
                        lblErrorMessage.Visible = true;
                        return;
                    }
                }

                CreatedOrUpdatedUser = _userService.GetUserById(_existingUser.Id);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
