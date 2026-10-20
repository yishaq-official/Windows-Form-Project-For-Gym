# Component 06: Members — Implementation Plan

This plan details the implementation steps for member registration, profile management, and the searchable directory.

---

### Step 1: Implement Member Service & Rule Enforcement
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IMemberService.cs`
  - `GymMembershipSystem/Services/MemberService.cs`
- **Actions**:
  1. Define query and mutation signatures:
     - `IReadOnlyList<Member> GetMembers(string? searchQuery, int? planIdFilter, MembershipStatus? statusFilter)`
     - `Member? GetMemberById(int id)`
     - `Result<Member> RegisterMember(string fullName, Gender gender, DateTime dob, string phone, string email, string address, DateTime joinDate)`
     - `Result UpdateMember(int id, string fullName, Gender gender, DateTime dob, string phone, string email, string address, bool isActive)`
     - `Result DeleteOrDeactivateMember(int id)`
  2. Implement validation:
     - Full name and address must be non-empty.
     - Email must conform to valid email regex format (`^[^@\s]+@[^@\s]+\.[^@\s]+$`).
     - Phone must have at least 7 characters.
     - Date of Birth must be in the past (e.g., minimum age of 12 years).
  3. Implement **Business Rule 8**:
     - Check `InMemoryDataStore.Instance.Subscriptions.Any(s => s.MemberId == id)` and `InMemoryDataStore.Instance.Payments.Any(p => p.MemberId == id)`.
     - If true, forbid hard delete; set `member.IsActive = false` (soft deactivation) and return a friendly status message.
  4. Publish `AppEvents.MemberChanged` on modifications.

---

### Step 2: Implement Member Registration & Edit Dialog
- **Files**:
  - `GymMembershipSystem/Forms/Members/MemberEditDialog.cs`
  - `GymMembershipSystem/Forms/Members/MemberEditDialog.Designer.cs`
- **Actions**:
  1. Design input form with controls:
     - `txtFullName`
     - `cboGender` (populated from `Enum.GetValues<Gender>()`)
     - `dtpDateOfBirth` (Format: Short, MaxDate: DateTime.Today)
     - `txtPhone`
     - `txtEmail`
     - `txtAddress` (Multiline text box)
     - `dtpJoinDate` (Format: Short)
     - `chkIsActive`
  2. Attach `ErrorProvider` for inline validation errors.
  3. Wire input validation on `Validating` events for name, email, phone, and date of birth.
  4. In `btnSave_Click`, execute registration or update logic via `IMemberService`.

---

### Step 3: Implement ListView Column Sorter Helper
- **File**: `GymMembershipSystem/Common/ListViewItemComparer.cs`
- **Actions**:
  1. Implement `IComparer` to enable clicking on `lvwMembers` column headers to sort ascending and descending.

---

### Step 4: Implement Members Directory View Control
- **Files**:
  - `GymMembershipSystem/Forms/Members/MembersViewControl.cs`
  - `GymMembershipSystem/Forms/Members/MembersViewControl.Designer.cs`
- **Actions**:
  1. Add filter controls:
     - `txtSearch` with placeholder "Search by ID or Name..."
     - `cboPlanFilter` populated with "All Plans" + active plans from `IPlanService`.
     - `cboStatusFilter` populated with "All Statuses", "Active", "Expired", "Inactive".
  2. Add `ListView` (`lvwMembers`):
     - View = `View.Details`, `FullRowSelect = true`, `GridLines = true`.
     - Add columns: `ID` (60px), `Full Name` (180px), `Gender` (70px), `Phone` (110px), `Email` (160px), `Current Plan` (120px), `Status` (90px), `Expiry Date` (100px), `Joined` (90px).
  3. Add action buttons: `btnNewMember`, `btnEditMember`, `btnDeleteMember`, `btnRefresh`.

---

### Step 5: Wire ListView Data Population and Filter Events
- **File**: `GymMembershipSystem/Forms/Members/MembersViewControl.cs`
- **Actions**:
  1. Implement `RefreshMemberList()`:
     - Query `IMemberService.GetMembers(searchQuery, selectedPlanId, selectedStatus)`.
     - Populate `ListViewItem` rows with sub-items.
     - Color code rows/status cells (Green for Active, DarkOrange for Expired, Gray for Inactive).
  2. Wire `txtSearch.TextChanged` to invoke `RefreshMemberList()`.
  3. Wire `cboPlanFilter.SelectedIndexChanged` and `cboStatusFilter.SelectedIndexChanged` to invoke `RefreshMemberList()`.
  4. Wire `lvwMembers.ColumnClick` to trigger sorting using `ListViewItemComparer`.
  5. Wire `btnDeleteMember.Click`:
     - Show confirmation dialog (D13: "Are you sure you want to delete or deactivate this member?").
     - Call `_memberService.DeleteOrDeactivateMember(id)`.
     - Display returned result message.

---

### Step 6: Verification and Testing
- **Actions**:
  1. Register a new member with invalid email; verify error provider fires and blocks save.
  2. Type a search query into `txtSearch`; verify the `ListView` filters immediately.
  3. Change the status filter to "Expired"; verify only expired members appear.
  4. Attempt to delete a seeded member with payments; verify soft deactivation is applied per Rule 8.
