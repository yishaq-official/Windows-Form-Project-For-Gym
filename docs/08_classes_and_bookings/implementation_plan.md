# Component 08: Classes & Member Bookings — Implementation Plan

This plan breaks down the class schedule and booking management features into atomic implementation steps.

---

### Step 1: Implement Class and Booking Service with Business Rules
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IClassService.cs`
  - `GymMembershipSystem/Services/ClassService.cs`
- **Actions**:
  1. Define signatures:
     - `IReadOnlyList<GymClass> GetAllClasses(DayOfWeek? dayFilter = null, int? trainerIdFilter = null)`
     - `GymClass? GetClassById(int classId)`
     - `int GetActiveBookingCount(int classId)`
     - `IReadOnlyList<Member> GetBookedMembers(int classId)`
     - `Result<GymClass> CreateClass(string name, int trainerId, DayOfWeek day, TimeSpan time, int capacity)`
     - `Result UpdateClass(int classId, string name, int trainerId, DayOfWeek day, TimeSpan time, int capacity)`
     - `Result DeleteClass(int classId)`
     - `Result BookMember(int classId, int memberId)`
     - `Result CancelBooking(int classId, int memberId)`
  2. Implement Business Rules:
     - **Rule 3**: In `BookMember`, check `GetActiveBookingCount(classId) >= class.Capacity`. If true, return `Result.Fail("Class is full.")`.
     - **Rule 4**: Check if `InMemoryDataStore.Instance.Bookings.Any(b => b.ClassId == classId && b.MemberId == memberId && !b.IsCancelled)`. If true, return `Result.Fail("Member is already booked into this class.")`.
     - **Rule 1**: Verify member has `MembershipStatus.Active`. If expired or inactive, return `Result.Fail("Only active members can book classes.")`.
     - **Rule 5**: In `CancelBooking`, set `booking.IsCancelled = true`. The spot is freed immediately.
     - **Rule 6**: In `UpdateClass`, check `if (newCapacity < GetActiveBookingCount(classId))` return `Result.Fail("Capacity cannot be reduced below the current number of bookings.")`.
  3. Publish `AppEvents.ClassBookingChanged(class)` upon booking changes.

---

### Step 2: Implement Class Creation & Edit Dialog
- **Files**:
  - `GymMembershipSystem/Forms/Classes/ClassEditDialog.cs`
  - `GymMembershipSystem/Forms/Classes/ClassEditDialog.Designer.cs`
- **Actions**:
  1. Place inputs:
     - `txtClassName` (Required)
     - `cboTrainer` (Active trainers from `ITrainerService`)
     - `cboDayOfWeek` (Enum values: Monday - Sunday)
     - `dtpTime` (Time picker format `hh:mm tt`)
     - `numCapacity` (NumericUpDown, Min: 1, Max: 100)
     - `btnSave` and `btnCancel`
  2. Attach `ErrorProvider` for validations.
  3. In `btnSave_Click`, execute `IClassService.CreateClass` or `UpdateClass`.

---

### Step 3: Implement Book Member Dialog
- **Files**:
  - `GymMembershipSystem/Forms/Classes/BookClassDialog.cs`
  - `GymMembershipSystem/Forms/Classes/BookClassDialog.Designer.cs`
- **Actions**:
  1. Create modal showing selected class name, trainer, and remaining seats.
  2. Provide a searchable `ComboBox` or list of active members.
  3. On selection, display member status and current bookings.
  4. Wire `btnConfirmBook.Click` to call `_classService.BookMember(classId, selectedMemberId)`.
  5. Show clear confirmation or rejection message (D13).

---

### Step 4: Implement Master-Detail Classes View Control
- **Files**:
  - `GymMembershipSystem/Forms/Classes/ClassesViewControl.cs`
  - `GymMembershipSystem/Forms/Classes/ClassesViewControl.Designer.cs`
- **Actions**:
  1. Construct split container (`SplitContainer`):
     - **Panel 1 (Left)**: Filter controls (`cboDayFilter`, `cboTrainerFilter`), `DataGridView` listing classes (`ID`, `Name`, `Trainer`, `Schedule`, `Booked/Capacity`, `Status`).
     - **Panel 2 (Right)**: Detail header with class title, trainer info, capacity progress bar (`ProgressBar`), and `ListView` listing booked attendees (`Member Name`, `Phone`, `Booking Date`).
  2. Add buttons: `btnNewClass`, `btnEditClass`, `btnDeleteClass`, `btnBookMember`, `btnCancelBooking`.

---

### Step 5: Wire Selection and Real-Time Roster Events
- **File**: `GymMembershipSystem/Forms/Classes/ClassesViewControl.cs`
- **Actions**:
  1. Wire `gridClasses.SelectionChanged`:
     - Load active bookings for the selected class into `lvwBookedMembers`.
     - Update progress bar (`pbrCapacity.Maximum = class.Capacity`, `pbrCapacity.Value = bookedCount`).
     - Update status text (e.g., "Full (20/20)" or "Available (5 spots left)").
  2. Wire `btnBookMember.Click`:
     - Open `BookClassDialog(selectedClass)`.
     - If booked, refresh roster and capacity counters.
  3. Wire `btnCancelBooking.Click`:
     - Get selected member in `lvwBookedMembers`.
     - Prompt confirmation (D13: "Cancel booking for [Member]?").
     - Call `_classService.CancelBooking(classId, memberId)`.
     - Refresh roster and capacity counters.

---

### Step 6: Verification and Testing
- **Actions**:
  1. Create a class with capacity = 2.
  2. Book 2 members: verify capacity progress bar reaches 100%.
  3. Attempt to book a 3rd member: verify "Class is full" rejection is displayed (Rule 3).
  4. Attempt to book the same member twice: verify duplicate booking rejection (Rule 4).
  5. Cancel a booking: verify capacity frees to 1 spot (Rule 5).
  6. Attempt to edit capacity down to 0: verify rejection (Rule 6).
