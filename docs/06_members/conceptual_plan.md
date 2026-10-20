# Component 06: Members Management & Directory

## 1. Conceptual Overview
The Members component fulfills Requirements **D3** ("Add, edit, and delete members: ID, full name, gender, date of birth, phone, email, address, join date"), **D6** ("Display members in a ListView with search and filter: by name, ID, plan, status"), **D12** (Input validation), **D13** (Status messages and confirmation dialogs), and Business Rule **8** ("A member with existing subscriptions or payments cannot be deleted; the member must be deactivated instead").

### Primary Responsibilities:
- Presentation of the member directory in a customized WinForms `ListView` with Details view, including search and multi-facet filtering (Name, ID, Plan, Status: Active/Expired/Inactive).
- Comprehensive member registration dialog with thorough validation (email format, phone regex, valid birth dates, required names and addresses).
- Editing existing member profiles.
- Enforcing Business Rule 8: If a member has active/historical subscriptions or payment records, block permanent deletion and enforce soft deactivation.

---

## 2. Event-Driven Patterns
- **`MemberListView` Column Click Event**: Sort members ascending/descending by clicking on column headers (e.g., Name, Join Date, Status).
- **`TextChanged` & `SelectedIndexChanged` Filter Events**: Combine text search (`txtSearch`) with combo boxes (`cboPlanFilter`, `cboStatusFilter`) to dynamically filter the `ListView` items on each keystroke or dropdown selection.
- **`MemberChanged` Event**: Broadcasts member lifecycle changes to keep the Dashboard and Attendance counters synchronized.

---

## 3. UI/UX Design Specification
- **View**: `MembersViewControl` (UserControl).
- **Controls & Components**:
  - Filter Bar:
    - `txtSearch`: Text box searching by Member ID or Name.
    - `cboPlanFilter`: Dropdown of plans (All, Monthly, Annual, No Plan, etc.).
    - `cboStatusFilter`: Dropdown of statuses (All, Active, Expired, Inactive).
    - `btnNewMember`: Styled primary button opening `MemberEditDialog`.
  - Main Display:
    - `ListView` (`lvwMembers`): View set to `Details`, `FullRowSelect = true`, `GridLines = true`.
    - Columns: `ID`, `Full Name`, `Gender`, `Phone`, `Email`, `Plan`, `Status`, `Expiry Date`, `Join Date`.
    - Visual Color Badging: Green text/icon for Active, Orange for Expired, Gray for Inactive.
  - Action Panel:
    - `btnEditMember`: Open edit profile.
    - `btnAssignPlan`: Jump directly to subscription assignment.
    - `btnRecordPayment`: Jump directly to payment recording for the selected member.
    - `btnDeactivate`: Soft-delete or toggle active state.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IMemberService.cs` | Member repository and query contract. |
| `GymMembershipSystem/Services/MemberService.cs` | Member business rules, validation, and in-memory operations. |
| `GymMembershipSystem/Forms/Members/MembersViewControl.cs` | ListView directory with search and multi-parameter filters. |
| `GymMembershipSystem/Forms/Members/MembersViewControl.Designer.cs` | Designer for members directory view. |
| `GymMembershipSystem/Forms/Members/MemberEditDialog.cs` | Modal dialog for member registration and profile updates. |
| `GymMembershipSystem/Forms/Members/MemberEditDialog.Designer.cs` | Designer for member edit modal. |
| `GymMembershipSystem/Common/ListViewItemComparer.cs` | Helper for sorting WinForms ListView columns on click. |
