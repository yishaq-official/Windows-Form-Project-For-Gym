# Component 05: Trainers Management

## 1. Conceptual Overview
The Trainers component fulfills Requirement **D7** ("Add, edit, and delete trainers: name, specialty, phone; and assign a trainer to a member"). Trainers lead classes and can be assigned as personal trainers for members.

### Primary Responsibilities:
- CRUD operations for gym trainers.
- Validating trainer contact details:
  - Full Name must not be blank.
  - Specialty must be specified (e.g., Bodybuilding, Yoga, Cardio, Crossfit, Aerobics).
  - Phone number must follow valid phone formatting rules (D12).
- Protecting trainers from deletion if they have scheduled classes or assigned active members (deactivate instead).
- Providing lookup data for class creation and member profile assignments.

---

## 2. Event-Driven Patterns
- **`TrainerChanged` Event**: Broadcasts when a trainer is added, modified, or deactivated.
- **Search & Filter Events**: Real-time filtering in the trainer list as the user types in the search box.
- **Input Validation Events**: Live validation of phone and required fields with `ErrorProvider`.

---

## 3. UI/UX Design Specification
- **View**: `TrainersViewControl` (UserControl).
- **Controls & Components**:
  - Top Filter Bar: `txtSearch` (filter by name/specialty), `btnNewTrainer`, `btnRefresh`.
  - Main Grid: `DataGridView` with columns (`ID`, `Full Name`, `Specialty`, `Phone`, `Assigned Members Count`, `Status`).
  - Action Panel: "Edit Details", "Toggle Active / Deactivate".
- **Dialog**: `TrainerEditDialog` (Modal):
  - `txtFullName`: Required text box.
  - `cboSpecialty`: ComboBox with pre-populated specialties + ability to type new ones.
  - `txtPhone`: Masked or validated phone number text box.
  - `chkIsActive`: Active status flag.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/ITrainerService.cs` | Service contract for trainer operations. |
| `GymMembershipSystem/Services/TrainerService.cs` | In-memory implementation of trainer business logic and validations. |
| `GymMembershipSystem/Forms/Trainers/TrainersViewControl.cs` | Main view for browsing and searching trainers. |
| `GymMembershipSystem/Forms/Trainers/TrainersViewControl.Designer.cs` | Visual layout designer for trainer listing. |
| `GymMembershipSystem/Forms/Trainers/TrainerEditDialog.cs` | Modal dialog for creating and updating trainer records. |
| `GymMembershipSystem/Forms/Trainers/TrainerEditDialog.Designer.cs` | Modal layout designer. |
