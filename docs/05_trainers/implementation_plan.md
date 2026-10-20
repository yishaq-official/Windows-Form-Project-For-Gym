# Component 05: Trainers — Implementation Plan

This plan outlines the atomic implementation steps for trainer management.

---

### Step 1: Define Trainer Service Interface and Logic
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/ITrainerService.cs`
  - `GymMembershipSystem/Services/TrainerService.cs`
- **Actions**:
  1. Define methods:
     - `IReadOnlyList<Trainer> GetAllTrainers(bool includeInactive = false)`
     - `Trainer? GetTrainerById(int trainerId)`
     - `Result<Trainer> CreateTrainer(string name, string specialty, string phone)`
     - `Result UpdateTrainer(int trainerId, string name, string specialty, string phone, bool isActive)`
     - `Result DeleteOrDeactivateTrainer(int trainerId)`
  2. Implement business rules:
     - Validate `name` and `specialty` are not blank.
     - Validate `phone` contains only valid phone characters (digits, dashes, plus sign) and minimum length.
     - Check if the trainer is assigned to scheduled classes or active subscriptions; if so, prevent deletion and deactivate instead.
  3. Publish `AppEvents.TrainerChanged` on modification.

---

### Step 2: Implement Trainer Edit Dialog
- **Files**:
  - `GymMembershipSystem/Forms/Trainers/TrainerEditDialog.cs`
  - `GymMembershipSystem/Forms/Trainers/TrainerEditDialog.Designer.cs`
- **Actions**:
  1. Construct dialog with `txtFullName`, `cboSpecialty` (pre-fill with items: "Strength & Conditioning", "Cardio & HIIT", "Yoga & Pilates", "Martial Arts", "CrossFit"), `txtPhone`, and `chkIsActive`.
  2. Attach `ErrorProvider` to inputs.
  3. Support constructor injection of `Trainer? existingTrainer`.
  4. Implement `Validating` handlers to check required fields and phone format.
  5. On `btnSave_Click`, execute creation/update via `ITrainerService` and set `DialogResult.OK`.

---

### Step 3: Implement Trainers View Control Layout
- **Files**:
  - `GymMembershipSystem/Forms/Trainers/TrainersViewControl.cs`
  - `GymMembershipSystem/Forms/Trainers/TrainersViewControl.Designer.cs`
- **Actions**:
  1. Create search bar with `txtSearchTrainer` and `btnRefresh`.
  2. Place `DataGridView` configured for full-row selection and read-only display.
  3. Place action buttons: `btnAddTrainer`, `btnEditTrainer`, `btnDeleteTrainer`.

---

### Step 4: Wire Real-Time Search and Interaction Events
- **File**: `GymMembershipSystem/Forms/Trainers/TrainersViewControl.cs`
- **Actions**:
  1. Implement `LoadTrainers(string? filter = null)` querying `ITrainerService`.
  2. Wire `txtSearchTrainer.TextChanged`:
     - Filter list in real time by checking if `Name` or `Specialty` contains the search query.
  3. Wire `btnAddTrainer.Click` to show `TrainerEditDialog`.
  4. Wire `btnEditTrainer.Click` to open `TrainerEditDialog(selectedTrainer)`.
  5. Wire `btnDeleteTrainer.Click` to prompt confirmation dialog (D13) and deactivate.

---

### Step 5: Verification and Testing
- **Actions**:
  1. Create a new trainer: verify validation blocks empty fields or invalid phone numbers.
  2. Search for a trainer by specialty: verify list filters instantaneously.
  3. Verify deactivated trainers appear grayed out or hidden according to filter settings.
