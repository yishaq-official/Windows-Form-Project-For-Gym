# Component 02: Authentication & Session Context

## 1. Conceptual Overview
The Authentication component fulfills Requirement **D1** ("Login form for administrators with username and password"). It gates access to the desktop application, validates credentials against stored users, verifies that the user has the `Administrator` role, and establishes an ambient `SessionContext` for audit logging throughout the application session.

### Primary Responsibilities:
- Presentation of a login dialog.
- Input validation on form submission (non-empty username, non-empty password, length limits) using WinForms `ErrorProvider` (D12).
- Verification of credentials against `InMemoryDataStore.Users`.
- Enforcement that only active accounts with `UserRole.Administrator` can sign in.
- Maintaining an accessible `UserSession` containing the currently authenticated user's ID, username, and sign-in timestamp.

---

## 2. Event-Driven Patterns
- **`KeyDown` / `AcceptButton` Event**: Pressing `Enter` in the password text box automatically triggers the login submission.
- **`Validating` & `Validated` Events**: WinForms event-based input validation on `txtUsername` and `txtPassword` with `ErrorProvider`.
- **`UserLoggedIn` & `UserLoggedOut` Domain Events**: Fired on successful login and logout to allow audit logging or UI state reset.

---

## 3. UI/UX Design Specification
- **Form**: `LoginForm` (FixedDialog, no maximize button, centered on screen).
- **Controls**:
  - `PictureBox`: Gym branding logo/icon.
  - `Label`: Header ("Gym Management System - Admin Login").
  - `TextBox` (`txtUsername`): Placeholder cue / label for username.
  - `TextBox` (`txtPassword`): Masked password (`UseSystemPasswordChar = true`).
  - `CheckBox` (`chkShowPassword`): Toggle password visibility.
  - `Button` (`btnLogin`): Primary action button, set as `AcceptButton`.
  - `Button` (`btnCancel`): Set as `CancelButton` to exit application.
  - `ErrorProvider` (`errorProvider`): Visual error cues next to inputs.
  - `Label` (`lblErrorMessage`): Red error summary label for invalid credentials.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IAuthService.cs` | Authentication contract (`Login`, `Logout`, `GetCurrentUser`). |
| `GymMembershipSystem/Services/AuthService.cs` | In-memory implementation verifying credentials against `InMemoryDataStore`. |
| `GymMembershipSystem/Common/UserSession.cs` | Ambient session holder tracking the current authenticated admin. |
| `GymMembershipSystem/Forms/Auth/LoginForm.cs` | UI code-behind for administrator login. |
| `GymMembershipSystem/Forms/Auth/LoginForm.Designer.cs` | WinForms designer layout code. |
