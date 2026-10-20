# Component 09: Attendance & Daily Check-In/Check-Out

## 1. Conceptual Overview
The Attendance component satisfies Requirement **D10** ("Record member check-in and check-out (attendance) for the day"), Requirement **D13** (Status messages and confirmation dialogs), and business rules:
- **Business Rule 1**: A member can check in only if the membership is Active (not expired).
- **Business Rule 10**: Only an Administrator can record payments and check-ins.

### Primary Responsibilities:
- Rapid front-desk check-in terminal: scan or type Member ID / Name.
- Instant validation of member subscription status:
  - If member has an `Active` subscription: check-in is logged with current timestamp.
  - If member has an `Expired` subscription or `No Subscription`: check-in is strictly blocked, and a renewal alert dialog is presented.
  - If member has an `Inactive` account: check-in is blocked.
- Recording check-out timestamp when the member departs.
- Live view of members currently inside the gym and today's total visit count.

---

## 2. Event-Driven Patterns
- **`MemberCheckInAttempted` & `AttendanceRecorded` Events**:
  - Emitted when a member checks in.
  - Updates the active occupant count on the main dashboard in real time.
- **`KeyPress` / `EnterKey` Event**: The admin types a member ID or scans a barcode and hits `Enter` $\rightarrow$ automatically triggers check-in lookup without mouse clicks.

---

## 3. UI/UX Design Specification
- **View**: `AttendanceViewControl` (UserControl).
- **Controls & Components**:
  - **Top Action Bar (Front Desk Terminal)**:
    - `txtSearchMember`: Large font input ("Enter Member ID or Name, press Enter...").
    - `btnCheckIn`: Primary check-in button.
    - `btnCheckOut`: Records check-out for the selected attendee.
  - **Quick Feedback Banner**:
    - Large color-coded alert panel that turns Green on success ("✓ Check-in Approved: John Doe (Active - VIP Plan)") or Red on failure ("✗ Check-in Denied: Membership Expired on 12/05/2026").
  - **Today's Attendance Grid**:
    - `DataGridView` displaying: `Record ID`, `Member Name`, `Current Plan`, `Check-In Time`, `Check-Out Time`, `Duration`, `Status` (In Gym / Checked Out).
  - **Summary Metrics**:
    - `lblCurrentlyInGym`: Count of members with no check-out time yet.
    - `lblTotalToday`: Total visits recorded today.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IAttendanceService.cs` | Service contract for check-in/out operations and daily logs. |
| `GymMembershipSystem/Services/AttendanceService.cs` | Business rules implementation enforcing Rule 1 and Rule 10. |
| `GymMembershipSystem/Forms/Attendance/AttendanceViewControl.cs` | Front desk terminal and today's attendance log. |
| `GymMembershipSystem/Forms/Attendance/AttendanceViewControl.Designer.cs` | Designer for attendance view. |
