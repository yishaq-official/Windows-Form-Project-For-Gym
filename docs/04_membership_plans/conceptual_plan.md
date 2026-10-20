# Component 04: Membership Plans Management

## 1. Conceptual Overview
The Membership Plans component satisfies Requirement **D4** ("Manage membership plans: name, duration, price") and Business Rule **7** ("A membership expiry date is the start date plus the duration of the plan"). Plans define the membership tiers (e.g., Monthly, Quarterly, Annual, VIP) that members can subscribe to.

### Primary Responsibilities:
- CRUD operations for membership plans (`Create`, `Read`, `Update`, `Delete`/Deactivate).
- Enforcing plan constraints:
  - Plan name must be unique and non-empty.
  - Duration must be greater than 0 days (e.g., 30 days for 1 month, 365 days for 1 year).
  - Price must be greater than 0 (D12).
- Protecting plans from hard deletion if active member subscriptions reference them (soft-delete / toggle active status).

---

## 2. Event-Driven Patterns
- **`PlanChanged` Domain Event**: When a plan is created or modified, fires `AppEvents.PlanChanged(plan, changeType)` so the Member subscription dropdown automatically updates.
- **Form Control Events**:
  - `Validating` on `txtPlanName`, `numDurationDays`, and `numPrice` using `ErrorProvider`.
  - `SelectionChanged` / `SelectedIndexChanged` on the plans list to populate edit fields.

---

## 3. UI/UX Design Specification
- **View**: `PlansViewControl` (UserControl hosted in Main Shell).
- **Layout Zones**:
  - **Left Section**: Table or ListView showing all existing plans (`Id`, `Name`, `Duration (Days)`, `Price ($)`, `Status`).
  - **Right Section (or Modal Dialog `PlanEditDialog`)**: Input fields:
    - `txtPlanName`: Text box for plan title.
    - `numDurationDays`: NumericUpDown for duration in days (min: 1, max: 1000).
    - `numPrice`: NumericUpDown with 2 decimal places for price in currency (min: 0.01).
    - `chkIsActive`: CheckBox to toggle plan availability for new subscriptions.
  - **Toolbar / Action Buttons**:
    - `btnNewPlan`: Clears input for adding a new plan.
    - `btnSavePlan`: Validates and commits plan.
    - `btnDeletePlan`: Prompts confirmation (D13) and disables/deletes plan.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IPlanService.cs` | Service contract for plan management operations. |
| `GymMembershipSystem/Services/PlanService.cs` | Plan business logic, validation, and in-memory operations. |
| `GymMembershipSystem/Forms/Plans/PlansViewControl.cs` | Main view control for listing and selecting plans. |
| `GymMembershipSystem/Forms/Plans/PlansViewControl.Designer.cs` | WinForms designer for plans management. |
| `GymMembershipSystem/Forms/Plans/PlanEditDialog.cs` | Modal dialog for creating/editing a membership plan. |
| `GymMembershipSystem/Forms/Plans/PlanEditDialog.Designer.cs` | Designer for plan edit modal. |
