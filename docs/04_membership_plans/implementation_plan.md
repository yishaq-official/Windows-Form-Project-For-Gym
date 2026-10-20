# Component 04: Membership Plans — Implementation Plan

This plan outlines the step-by-step implementation for managing gym membership plans.

---

### Step 1: Define Plan Service Interface and Implementation
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IPlanService.cs`
  - `GymMembershipSystem/Services/PlanService.cs`
- **Actions**:
  1. Define methods:
     - `IReadOnlyList<Plan> GetAllPlans(bool includeInactive = false)`
     - `Plan? GetPlanById(int planId)`
     - `Result<Plan> CreatePlan(string name, int durationDays, decimal price)`
     - `Result UpdatePlan(int planId, string name, int durationDays, decimal price, bool isActive)`
     - `Result DeleteOrDeactivatePlan(int planId)`
  2. Implement business rules:
     - Validate name is not empty and not duplicate.
     - Validate `durationDays > 0` and `price > 0` (D12).
     - If active subscriptions reference `planId`, do not delete; set `plan.IsActive = false` instead.
  3. Publish `AppEvents.PlanChanged` upon state changes.

---

### Step 2: Create Plan Edit Dialog Form
- **Files**:
  - `GymMembershipSystem/Forms/Plans/PlanEditDialog.cs`
  - `GymMembershipSystem/Forms/Plans/PlanEditDialog.Designer.cs`
- **Actions**:
  1. Design modal dialog with fields:
     - `txtPlanName`
     - `numDuration` (NumericUpDown, Min: 1, Max: 730, Default: 30)
     - `numPrice` (NumericUpDown, DecimalPlaces: 2, Min: 0.01, Max: 100000)
     - `chkIsActive` (Default: true)
     - `btnSave` and `btnCancel`
  2. Add `ErrorProvider` for field validations.
  3. Provide parameterized constructor `PlanEditDialog(Plan? existingPlan = null)`.
  4. In `btnSave_Click`, run validations; if valid, call `_planService.CreatePlan` or `_planService.UpdatePlan`, then set `DialogResult = DialogResult.OK`.

---

### Step 3: Implement Plans View UserControl
- **Files**:
  - `GymMembershipSystem/Forms/Plans/PlansViewControl.cs`
  - `GymMembershipSystem/Forms/Plans/PlansViewControl.Designer.cs`
- **Actions**:
  1. Add top header bar: Title "Membership Plans", `btnAddPlan` button, `btnRefresh` button.
  2. Add `DataGridView` or `ListView` with columns:
     - `ID`, `Plan Name`, `Duration (Days)`, `Price`, `Status` (Active/Inactive), `Active Subscriptions Count`.
  3. Style grid with row alternating colors and full-row selection.
  4. Add context actions: "Edit Plan" and "Deactivate Plan".

---

### Step 4: Wire View Events & Grid Population
- **File**: `GymMembershipSystem/Forms/Plans/PlansViewControl.cs`
- **Actions**:
  1. Implement `LoadPlans()` to fetch plans from `IPlanService` and bind to the grid.
  2. Wire `btnAddPlan.Click`:
     - Open `PlanEditDialog` as `ShowDialog(this)`.
     - If `DialogResult.OK`, re-invoke `LoadPlans()`.
  3. Wire double-click or "Edit" button:
     - Retrieve selected plan.
     - Open `PlanEditDialog(selectedPlan)`.
     - If `DialogResult.OK`, re-invoke `LoadPlans()`.
  4. Wire "Deactivate/Delete" button:
     - Prompt confirmation dialog (D13: "Are you sure you want to deactivate this plan?").
     - Call `_planService.DeleteOrDeactivatePlan(id)`.
     - Display status notification.

---

### Step 5: Verification and Testing
- **Actions**:
  1. Add a new plan (e.g., "Student Semester Pass", 120 days, $100.00).
  2. Try entering price = 0 or negative days: verify error provider prevents save.
  3. Edit an existing plan: verify changes persist in memory and reflect in the grid.
  4. Deactivate a plan and confirm inactive status is reflected.
