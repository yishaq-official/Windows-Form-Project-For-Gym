using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Users
{
    public partial class UsersViewControl : UserControl
    {
        private readonly IUserService _userService;

        private class RoleFilterItem
        {
            public UserRole? Role { get; }
            public string Name { get; }

            public RoleFilterItem(UserRole? role, string name)
            {
                Role = role;
                Name = name;
            }

            public override string ToString() => Name;
        }

        private class UserListItem
        {
            public User User { get; }
            public int Id => User.Id;
            public string Username => User.Username;
            public string FullName => User.FullName;
            public UserRole Role => User.Role;
            public string StatusDisplay => User.IsActive ? "Active" : "Deactivated";
            public string CreatedAtDisplay => User.CreatedAt.ToLocalTime().ToString("yyyy-MM-dd hh:mm tt");

            public UserListItem(User user)
            {
                User = user;
            }
        }

        public UsersViewControl(IUserService? userService = null)
        {
            InitializeComponent();
            _userService = userService ?? new UserService();

            SubscribeEvents();
            PopulateRoleFilter();
            LoadUsers();
        }

        #region Event Subscriptions & Thread-Safe UI

        private void SubscribeEvents()
        {
            AppEvents.UserChanged += OnUserChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.UserChanged -= OnUserChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnUserChanged(User user, ChangeType changeType) => RunOnUiThread(LoadUsers);
        private void OnDataReset() => RunOnUiThread(LoadUsers);

        private void RunOnUiThread(Action action)
        {
            if (IsDisposed || Disposing) return;
            if (InvokeRequired)
            {
                try { BeginInvoke(action); } catch (ObjectDisposedException) { }
            }
            else
            {
                action();
            }
        }

        #endregion

        #region Filters & Data Loading

        private void PopulateRoleFilter()
        {
            cboRoleFilter.SelectedIndexChanged -= FilterControl_Changed;
            cboRoleFilter.Items.Clear();
            cboRoleFilter.Items.Add(new RoleFilterItem(null, "All Roles"));

            foreach (var role in Enum.GetValues<UserRole>())
            {
                cboRoleFilter.Items.Add(new RoleFilterItem(role, role.ToString()));
            }

            cboRoleFilter.SelectedIndex = 0;
            cboRoleFilter.SelectedIndexChanged += FilterControl_Changed;
        }

        public void LoadUsers()
        {
            var selectedRoleItem = cboRoleFilter.SelectedItem as RoleFilterItem;
            UserRole? roleFilter = selectedRoleItem?.Role;
            string? searchQuery = txtSearch.Text;

            var users = _userService.GetUsers(searchQuery, roleFilter)
                .Select(u => new UserListItem(u))
                .ToList();

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = users;

            // Visual row styling for deactivated accounts
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.DataBoundItem is UserListItem item && !item.User.IsActive)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
                }
            }
        }

        private void FilterControl_Changed(object? sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            if (cboRoleFilter.Items.Count > 0)
            {
                cboRoleFilter.SelectedIndex = 0;
            }
            LoadUsers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        #endregion

        #region User Actions & Modals

        private User? GetSelectedUser()
        {
            if (dgvUsers.SelectedRows.Count == 0) return null;
            var item = dgvUsers.SelectedRows[0].DataBoundItem as UserListItem;
            return item?.User;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            using var dialog = new UserEditDialog(null, _userService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show(
                    "Please select a user account to edit.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using var dialog = new UserEditDialog(user, _userService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show(
                    "Please select a user account to reset password.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using var dialog = new UserEditDialog(user, _userService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show(
                    "Please select a user account to change status.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Self-deactivation prevention check
            if (UserSession.CurrentUser?.Id == user.Id && user.IsActive)
            {
                MessageBox.Show(
                    "You cannot deactivate your own active session account.",
                    "Action Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string actionName = user.IsActive ? "deactivate" : "reactivate";
            var confirm = MessageBox.Show(
                $"Are you sure you want to {actionName} account '{user.Username}' ({user.FullName})?",
                $"Confirm Account {char.ToUpper(actionName[0]) + actionName.Substring(1)}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var result = _userService.ToggleUserActiveState(user.Id);
            if (result.IsFailure)
            {
                MessageBox.Show(result.Error, "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadUsers();
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEditUser_Click(sender, e);
            }
        }

        #endregion
    }
}
