# Component 12: System User Management

## 1. Conceptual Overview
The User Management component satisfies Requirement **D15** ("Manage user accounts: add, edit, deactivate, assign role: Administrator, Trainer, or Member") and Requirement **D12** / **D13** (Input validation, status messages, confirmation dialogs).

### Primary Responsibilities:
- Managing login accounts that access the system across all tiers (Administrator, Trainer, Member).
- Role assignment and permission scoping (`UserRole.Administrator`, `UserRole.Trainer`, `UserRole.Member`).
- Secure creation: username uniqueness check, minimum password strength validation.
- Deactivating accounts (toggling active status) to revoke access without deleting relational audit history.
- Self-deactivation prevention: an active administrator cannot deactivate their own currently logged-in account.

---

## 2. Event-Driven Patterns
- **`UserChanged` Event**: Broadcasts when a user is modified or deactivated.
- **Form Input Validation Events**: Real-time password confirmation match check (`txtPassword` vs `txtConfirmPassword`).
- **Role Selection Event**: When role is changed to `Trainer` or `Member`, dynamically enables linking to an existing Trainer or Member entity.

---

## 3. UI/UX Design Specification
- **View**: `UsersViewControl` (UserControl).
- **Controls & Components**:
  - Filter Bar: `txtSearchUser`, `cboRoleFilter` (All, Administrator, Trainer, Member), `btnNewUser`, `btnRefresh`.
  - Main Grid: `DataGridView` with columns:
    - `User ID`, `Username`, `Full Name`, `Role`, `Status` (Active/Deactivated), `Created Date`.
  - Action Buttons: `btnEditUser`, `btnToggleActive`, `btnResetPassword`.
- **Dialog**: `UserEditDialog` (Modal):
  - `txtUsername`: Unique username field.
  - `txtFullName`: Real name.
  - `txtPassword`: Password (masked, enabled for new users or password reset).
  - `txtConfirmPassword`: Confirm password field.
  - `cboRole`: Dropdown for role (`Administrator`, `Trainer`, `Member`).
  - `chkIsActive`: Active account flag.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IUserService.cs` | Contract for user account management. |
| `GymMembershipSystem/Services/UserService.cs` | In-memory implementation of user account logic and role validation. |
| `GymMembershipSystem/Forms/Users/UsersViewControl.cs` | Main view for browsing and managing user accounts. |
| `GymMembershipSystem/Forms/Users/UsersViewControl.Designer.cs` | Designer for user accounts view. |
| `GymMembershipSystem/Forms/Users/UserEditDialog.cs` | Modal dialog for creating and updating system accounts. |
| `GymMembershipSystem/Forms/Users/UserEditDialog.Designer.cs` | Designer for user edit modal. |
