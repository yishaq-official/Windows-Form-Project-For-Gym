# Component 07: Subscriptions & Plan Assignment

## 1. Conceptual Overview
The Subscriptions component fulfills Requirement **D5** ("Assign a plan to a member; the system calculates start date, expiry date, and status (Active/Expired)"), Requirement **D7** ("assign a trainer to a member"), and business rules:
- **Business Rule 1**: A member can check in only if the membership is Active (not expired).
- **Business Rule 2**: A member cannot hold two active subscriptions of the same plan at the same time.
- **Business Rule 7**: A membership expiry date is the start date plus the duration of the plan.

### Primary Responsibilities:
- Assigning a selected `Plan` to a `Member`.
- Automated calculation of subscription dates:
  $$\text{Expiry Date} = \text{Start Date} + \text{Plan.DurationInDays}$$
- Dynamic evaluation of status: if $\text{Expiry Date} \ge \text{Today}$, status is `Active`; otherwise `Expired`.
- Optional assignment of a personal `Trainer` to the member.
- Blocking duplicate active subscriptions for the same plan (Rule 2).

---

## 2. Event-Driven Patterns
- **`PlanSelectedIndexChanged` Event**: When selecting a plan from the dropdown, the form immediately fetches the plan's duration and updates the calculated Expiry Date label in real time before saving.
- **`SubscriptionCreated` / `SubscriptionRenewed` Domain Event**: Notifies other components (Attendance, Dashboard, Payments) that member status has changed.

---

## 3. UI/UX Design Specification
- **Dialog**: `AssignPlanDialog` (Modal, centered, launched from Member view or Dashboard).
- **Controls & Components**:
  - Member Info Panel (Read-only): `lblMemberName`, `lblCurrentStatus`, `lblCurrentExpiry`.
  - Subscription Settings:
    - `cboPlan`: Dropdown listing active plans with price and duration formatted.
    - `dtpStartDate`: DateTimePicker for subscription start (defaults to Today or existing expiry date for renewals).
    - `lblCalculatedExpiry`: Bold text label showing calculated end date automatically updated when plan or start date changes.
    - `lblPlanPrice`: Displays the fee that will be billed.
    - `cboTrainer`: Dropdown to optionally assign a personal trainer (lists all active trainers + "(None)").
  - Action Buttons: `btnConfirmSubscription`, `btnCancel`.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/ISubscriptionService.cs` | Contract for assigning, renewing, and querying subscriptions. |
| `GymMembershipSystem/Services/SubscriptionService.cs` | Implementation enforcing Business Rules 2 & 7. |
| `GymMembershipSystem/Forms/Subscriptions/AssignPlanDialog.cs` | Modal dialog for plan assignment and trainer linking. |
| `GymMembershipSystem/Forms/Subscriptions/AssignPlanDialog.Designer.cs` | WinForms layout designer for subscription assignment. |
