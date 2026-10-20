# Component 02: Authentication — Implementation Plan

This plan breaks down the login feature into atomic implementation steps following an event-driven flow.

---

### Step 1: Implement Session Context
- **File**: `GymMembershipSystem/Common/UserSession.cs`
- **Actions**:
  1. Create a thread-safe static holder `UserSession`.
  2. Add properties: `User? CurrentUser`, `bool IsAuthenticated`, `DateTime? LoginTime`.
  3. Add methods: `SignIn(User user)`, `SignOut()`.

---

### Step 2: Define and Implement Authentication Service
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IAuthService.cs`
  - `GymMembershipSystem/Services/AuthService.cs`
- **Actions**:
  1. Declare `Result<User> Authenticate(string username, string password)`.
  2. In `AuthService`, query `InMemoryDataStore.Instance.Users`.
  3. Check:
     - User exists (case-insensitive username comparison).
     - Password matches (or hash matches).
     - User `IsActive == true`.
     - User `Role == UserRole.Administrator` (only admins can log into the WinForms app).
  4. Return `Result.Fail("Invalid username or password.")` or `Result.Fail("Account is deactivated.")`.
  5. On success, populate `UserSession.SignIn(user)`.

---

### Step 3: Implement Login Form Visual Structure
- **Files**:
  - `GymMembershipSystem/Forms/Auth/LoginForm.cs`
  - `GymMembershipSystem/Forms/Auth/LoginForm.Designer.cs`
- **Actions**:
  1. Set Form properties: `FormBorderStyle = FormBorderStyle.FixedDialog`, `StartPosition = FormStartPosition.CenterScreen`, `MaximizeBox = false`.
  2. Add header panel with title "Gym Management System".
  3. Place `txtUsername` and `txtPassword` with descriptive labels.
  4. Place `chkShowPassword` checkbox.
  5. Place `btnLogin` (styled primary button) and `btnCancel`.
  6. Add `ErrorProvider` component.
  7. Add `lblErrorMessage` (ForeColor = Red, initially hidden).

---

### Step 4: Implement Login Form Interaction Logic & Events
- **File**: `GymMembershipSystem/Forms/Auth/LoginForm.cs`
- **Actions**:
  1. Wire `chkShowPassword.CheckedChanged`:
     ```csharp
     txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
     ```
  2. Implement input validation events (`Validating` on text boxes):
     - Trigger `errorProvider.SetError(...)` if fields are empty.
  3. Wire `btnLogin.Click`:
     - Run `ValidateChildren()`. If invalid, abort.
     - Call `_authService.Authenticate(txtUsername.Text.Trim(), txtPassword.Text)`.
     - If failed: display `lblErrorMessage.Text = result.Error`, highlight password field.
     - If success: set `DialogResult = DialogResult.OK` and close form.
  4. Wire `btnCancel.Click`:
     - Set `DialogResult = DialogResult.Cancel` and close form.

---

### Step 5: Wire Application Entry Point
- **File**: `GymMembershipSystem/Program.cs`
- **Actions**:
  1. In `Main()`, seed initial data: `DataSeeder.Seed(InMemoryDataStore.Instance);`
  2. Show `LoginForm`:
     ```csharp
     using var loginForm = new LoginForm();
     if (loginForm.ShowDialog() == DialogResult.OK)
     {
         Application.Run(new MainForm());
     }
     ```
  3. If canceled or closed, application gracefully exits.

---

### Step 6: Verification and Testing
- **Actions**:
  1. Test empty fields: error provider must indicate missing inputs.
  2. Test invalid credentials (e.g., `admin` / `wrongpassword`): error message shown.
  3. Test non-admin account: verify access is denied with proper message.
  4. Test valid admin (`admin` / `admin123`): verify transition to `MainForm`.
