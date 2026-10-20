# Component 07: Subscriptions — Implementation Plan

This plan outlines the atomic implementation steps for assigning membership plans, calculating expiry, and trainer assignments.

---

### Step 1: Implement Subscription Service & Business Logic
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/ISubscriptionService.cs`
  - `GymMembershipSystem/Services/SubscriptionService.cs`
- **Actions**:
  1. Define methods:
     - `Subscription? GetActiveSubscription(int memberId)`
     - `IReadOnlyList<Subscription> GetMemberSubscriptions(int memberId)`
     - `Result<Subscription> AssignPlan(int memberId, int planId, DateTime startDate, int? trainerId)`
  2. Implement Business Rules:
     - Check **Business Rule 2**: Query existing subscriptions for this member where `PlanId == planId` and `ExpiryDate >= startDate`. If found, return `Result.Fail("Member already has an active subscription for this plan.")`.
     - Calculate **Business Rule 7**: `expiryDate = startDate.AddDays(plan.DurationInDays);`
     - Determine status: `status = expiryDate >= DateTime.Today ? MembershipStatus.Active : MembershipStatus.Expired;`
  3. Save to `InMemoryDataStore.Instance.Subscriptions`.
  4. Publish `AppEvents.SubscriptionChanged(subscription)`.

---

### Step 2: Design Assign Plan Dialog Layout
- **Files**:
  - `GymMembershipSystem/Forms/Subscriptions/AssignPlanDialog.cs`
  - `GymMembershipSystem/Forms/Subscriptions/AssignPlanDialog.Designer.cs`
- **Actions**:
  1. Create form accepting `Member member` in its constructor.
  2. Place member summary labels (ID, Name, Current Plan, Current Expiry).
  3. Place `cboPlan` (ComboBox, DropDownList).
  4. Place `dtpStartDate` (DateTimePicker).
  5. Place preview labels: `lblCalculatedExpiry` (accent color, bold font) and `lblPrice`.
  6. Place `cboTrainer` (ComboBox, DropDownList).
  7. Place `btnConfirm` and `btnCancel`.

---

### Step 3: Wire Real-Time Expiry Calculation Events
- **File**: `GymMembershipSystem/Forms/Subscriptions/AssignPlanDialog.cs`
- **Actions**:
  1. In `Form_Load`:
     - Load active plans into `cboPlan`.
     - Load active trainers into `cboTrainer` with a first option for `None`.
     - Set `dtpStartDate.Value = DateTime.Today`.
  2. Create helper method `UpdateCalculatedExpiry()`:
     - If a plan is selected, read `selectedPlan.DurationInDays`.
     - Calculate `DateTime expiry = dtpStartDate.Value.Date.AddDays(selectedPlan.DurationInDays)`.
     - Update `lblCalculatedExpiry.Text = expiry.ToShortDateString() + " (" + selectedPlan.DurationInDays + " days)"`.
     - Update `lblPrice.Text = selectedPlan.Price.ToString("C2")`.
  3. Wire `cboPlan.SelectedIndexChanged` to call `UpdateCalculatedExpiry()`.
  4. Wire `dtpStartDate.ValueChanged` to call `UpdateCalculatedExpiry()`.

---

### Step 4: Wire Confirmation and Validation Events
- **File**: `GymMembershipSystem/Forms/Subscriptions/AssignPlanDialog.cs`
- **Actions**:
  1. Wire `btnConfirm.Click`:
     - Verify a valid plan is selected.
     - Call `_subscriptionService.AssignPlan(member.Id, plan.Id, dtpStartDate.Value, trainerId)`.
     - If failed: show MessageBox warning (D13).
     - If success: prompt confirmation asking if the user would like to record payment now, set `DialogResult.OK`, and close dialog.

---

### Step 5: Verification and Testing
- **Actions**:
  1. Select a 30-day plan starting today: verify the calculated expiry label updates immediately to Today + 30 days.
  2. Change start date forward: verify calculated expiry updates dynamically without clicking any submit button.
  3. Attempt to assign the exact same active plan to the same member: verify Rule 2 triggers and displays error.
  4. Verify the member's status in the directory updates to "Active".
