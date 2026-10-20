# Component 09: Attendance — Implementation Plan

This plan details the implementation steps for daily check-in, check-out, and active membership verification.

---

### Step 1: Implement Attendance Service & Business Rules
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IAttendanceService.cs`
  - `GymMembershipSystem/Services/AttendanceService.cs`
- **Actions**:
  1. Define signatures:
     - `Result<Attendance> CheckInMember(int memberId)`
     - `Result CheckOutMember(int attendanceId)`
     - `IReadOnlyList<Attendance> GetTodayAttendances()`
     - `int GetCurrentOccupancyCount()`
     - `int GetTodayTotalVisitsCount()`
  2. Implement Business Rules:
     - **Rule 10**: Check `UserSession.CurrentUser?.Role == UserRole.Administrator`. If not admin, return `Result.Fail("Only administrators can record check-ins.")`.
     - Fetch member: verify `member.IsActive == true`.
     - Fetch active subscription: verify member has a subscription where `Status == MembershipStatus.Active` and `ExpiryDate >= DateTime.Today`.
     - **Rule 1**: If no active subscription or expired, return `Result.Fail($"Member '{member.FullName}' has an expired membership ({subscription?.ExpiryDate.ToShortDateString() ?? "No Plan"}). Check-in denied.")`.
     - Prevent double check-in: if the member is already checked in today without a check-out time, return warning ("Member is already currently checked in.").
  3. Create attendance record with `DateTime.Now`, append to store, and publish `AppEvents.AttendanceRecorded(attendance)`.

---

### Step 2: Design Attendance View Control Layout
- **Files**:
  - `GymMembershipSystem/Forms/Attendance/AttendanceViewControl.cs`
  - `GymMembershipSystem/Forms/Attendance/AttendanceViewControl.Designer.cs`
- **Actions**:
  1. Add top check-in input panel:
     - Search label + `txtMemberSearch` (large font, placeholder).
     - Auto-complete source configured with member names and IDs.
     - `btnCheckIn` and `btnCheckOut`.
  2. Add visual status feedback panel (`pnlFeedbackBanner`):
     - `lblFeedbackIcon` (✓ / ✗) + `lblFeedbackMessage`.
     - Color scheme: Green background for approved, Crimson for rejected.
  3. Add metrics strip:
     - Badge 1: "Currently in Gym: [X]"
     - Badge 2: "Today's Total Check-ins: [Y]"
  4. Add `DataGridView` (`gridTodayAttendance`) configured with columns:
     - `ID`, `Member Name`, `Current Plan`, `Check-in Time`, `Check-out Time`, `Duration (Mins)`, `Status`.

---

### Step 3: Implement Check-In Event Logic
- **File**: `GymMembershipSystem/Forms/Attendance/AttendanceViewControl.cs`
- **Actions**:
  1. Wire `txtMemberSearch.KeyDown`:
     - If `e.KeyCode == Keys.Enter`, suppress ding and trigger check-in execution.
  2. Implement `ExecuteCheckIn()`:
     - Parse member ID or find member by full name.
     - Call `_attendanceService.CheckInMember(member.Id)`.
     - If failed:
       - Set `pnlFeedbackBanner.BackColor = Color.LightCoral`.
       - Set `lblFeedbackMessage.Text = result.Error`.
     - If success:
       - Set `pnlFeedbackBanner.BackColor = Color.LightGreen`.
       - Set `lblFeedbackMessage.Text = $"Check-in approved for {member.FullName} at {DateTime.Now:hh:mm tt}".`
     - Refresh today's attendance grid and metrics.
     - Clear and refocus `txtMemberSearch` for next attendee.

---

### Step 4: Implement Check-Out Event Logic
- **File**: `GymMembershipSystem/Forms/Attendance/AttendanceViewControl.cs`
- **Actions**:
  1. Wire `btnCheckOut.Click`:
     - Ensure an attendance record with empty check-out time is selected.
     - Call `_attendanceService.CheckOutMember(selectedAttendance.Id)`.
     - Update record with current timestamp and refresh grid.

---

### Step 5: Verification and Testing
- **Actions**:
  1. Check in an active member: verify green banner displays and row appears in grid.
  2. Attempt to check in an expired member: verify red denial banner displays with expiry date (Rule 1).
  3. Attempt to check in a member already inside: verify duplicate warning.
  4. Select active attendee and click "Check Out": verify check-out timestamp is stamped and occupant count decrements.
