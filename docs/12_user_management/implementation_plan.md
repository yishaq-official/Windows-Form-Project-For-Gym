# Component 12: System User Management — Implementation Plan

This plan breaks down the user administration and role management features into step-by-step actions.

---

### Step 1: Implement User Service & Account Rules
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IUserService.cs`
  - `GymMembershipSystem/Services/UserService.cs`
- **Actions**:
  1. Define signatures:
     - `IReadOnlyList<User> GetUsers(string? search = null, UserRole? roleFilter = null)`
     - `User? GetUserById(int userId)`
     - `Result<User> CreateUser(string username, string password, string fullName, UserRole role)`
     - `Result UpdateUser(int userId, string fullName, UserRole role, bool isActive)`
     - `Result ResetPassword(int userId, string newPassword)`
     - `Result ToggleUserActiveState(int userId)`
  2. Implement Business Rules:
     - Check username uniqueness (case-insensitive).
     - Password must be at least 6 characters.
     - Self-deactivation prevention: if `userId == UserSession.CurrentUser?.Id`, block deactivation with `Result.Fail("You cannot deactivate your own active session account.")`.
  3. Publish `AppEvents.UserChanged(user)`.

---

### Step 2: Implement User Edit Dialog
- **Files**:
  - `GymMembershipSystem/Forms/Users/UserEditDialog.cs`
  - `GymMembershipSystem/Forms/Users/UserEditDialog.Designer.cs`
- **Actions**:
  1. Design modal with controls:
     - `txtUsername`
     - `txtFullName`
     - `txtPassword` and `txtConfirmPassword` (Masked with `*`, disabled if editing existing user unless "Change Password" checkbox is checked)
     - `cboRole` (`Administrator`, `Trainer`, `Member`)
     - `chkIsActive`
     - `btnSave` and `btnCancel`
  2. Attach `ErrorProvider` for input validation.
  3. On `btnSave_Click`, execute creation or update via `IUserService`.

---

### Step 3: Implement Users View Control Layout
- **Files**:
  - `GymMembershipSystem/Forms/Users/UsersViewControl.cs`
  - `GymMembershipSystem/Forms/Users/UsersViewControl.Designer.cs`
- **Actions**:
  1. Top filter bar: `txtSearchUser`, `cboRoleFilter`, `btnNewUser`, `btnRefresh`.
  2. `DataGridView` (`gridUsers`):
     - Columns: `User ID`, `Username`, `Full Name`, `Role`, `Active`, `Created Date`.
  3. Action panel: `btnEditUser`, `btnToggleActive`, `btnResetPassword`.

---

### Step 4: Wire View Events & Actions
- **File**: `GymMembershipSystem/Forms/Users/UsersViewControl.cs`
- **Actions**:
  1. Implement `LoadUsers()` querying `IUserService`.
  2. Wire `txtSearchUser.TextChanged` and `cboRoleFilter.SelectedIndexChanged` to filter rows dynamically.
  3. Wire `btnNewUser.Click` to show `UserEditDialog`.
  4. Wire `btnToggleActive.Click`:
     - Show confirmation dialog (D13: "Toggle active state for [User]?").
     - Call `_userService.ToggleUserActiveState(selectedUser.Id)`.
     - Refresh grid.

---

### Step 5: Verification and Testing
- **Actions**:
  1. Create a new user with mismatched passwords: verify error provider prevents creation.
  2. Attempt to create a user with duplicate username: verify error message.
  3. Attempt to deactivate the currently logged in `admin`: verify safety rule prevents deactivation.
  4. Create a new admin account and verify they can log in via `LoginForm`.
