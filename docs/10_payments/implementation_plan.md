# Component 10: Payments — Implementation Plan

This plan details the implementation steps for payment processing, billing history, and balance calculation.

---

### Step 1: Implement Payment Service & Financial Calculations
- **Files**:
  - `GymMembershipSystem/Services/Interfaces/IPaymentService.cs`
  - `GymMembershipSystem/Services/PaymentService.cs`
- **Actions**:
  1. Define signatures:
     - `Result<Payment> RecordPayment(int memberId, decimal amount, PaymentMethod method, DateTime paymentDate, string? notes)`
     - `decimal GetMemberOutstandingBalance(int memberId)`
     - `decimal GetTotalRevenue(DateTime? startDate = null, DateTime? endDate = null)`
     - `IReadOnlyList<Payment> GetPayments(int? memberIdFilter = null, DateTime? fromDate = null, DateTime? toDate = null)`
  2. Implement Business Rules:
     - **Rule 10**: Verify `UserSession.CurrentUser?.Role == UserRole.Administrator`. If not admin, return `Result.Fail("Only administrators can record payments.")`.
     - **Rule 9**: Verify `amount > 0`. If `amount <= 0`, return `Result.Fail("Payment amount must be greater than zero.")`.
     - Verify member exists and is active.
  3. Calculate outstanding balance:
     - Sum plan prices of all subscriptions belonging to `memberId`.
     - Subtract sum of all payments made by `memberId`.
  4. Publish `AppEvents.PaymentReceived(payment)`.

---

### Step 2: Implement Record Payment Dialog
- **Files**:
  - `GymMembershipSystem/Forms/Payments/RecordPaymentDialog.cs`
  - `GymMembershipSystem/Forms/Payments/RecordPaymentDialog.Designer.cs`
- **Actions**:
  1. Design input form with controls:
     - `cboMember` (ComboBox, searchable).
     - `lblBalanceDisplay` (Font: Bold 14pt, displays outstanding balance).
     - `numAmount` (NumericUpDown, Min: 0.01, Max: 100000.00, DecimalPlaces: 2).
     - `cboPaymentMethod` (Populated with `Enum.GetValues<PaymentMethod>()`).
     - `dtpPaymentDate` (Short format, default today).
     - `txtNotes` (Multiline text box for notes/check numbers).
  2. Add `ErrorProvider` for input validation.
  3. Support constructor with pre-selected `int? preSelectedMemberId`.

---

### Step 3: Wire Payment Dialog Dynamic Calculations & Events
- **File**: `GymMembershipSystem/Forms/Payments/RecordPaymentDialog.cs`
- **Actions**:
  1. Wire `cboMember.SelectedIndexChanged`:
     - Retrieve selected member.
     - Call `_paymentService.GetMemberOutstandingBalance(member.Id)`.
     - Update `lblBalanceDisplay`:
       - If balance > 0: text is `$"Outstanding Balance: {balance:C2}"`, color is Red. Set `numAmount.Value = Math.Max(0.01m, balance)`.
       - If balance <= 0: text is `"No outstanding balance (Account is current)"`, color is Green.
  2. Wire `btnSave.Click`:
     - Validate `numAmount.Value > 0`.
     - Call `_paymentService.RecordPayment(...)`.
     - If success: show confirmation (D13: "Payment of $XX recorded successfully"), set `DialogResult.OK`, and close.

---

### Step 4: Implement Payments View Control
- **Files**:
  - `GymMembershipSystem/Forms/Payments/PaymentsViewControl.cs`
  - `GymMembershipSystem/Forms/Payments/PaymentsViewControl.Designer.cs`
- **Actions**:
  1. Place date range filter controls (`dtpFrom`, `dtpTo`, `btnFilterDate`).
  2. Place metric summary cards: "Total Revenue This Month" and "Total Lifetime Collections".
  3. Place `DataGridView` displaying payment history (`Receipt ID`, `Date`, `Member Name`, `Amount`, `Method`, `Notes`).
  4. Add `btnRecordPayment` and `btnRefresh`.

---

### Step 5: Wire Payment View Population and Events
- **File**: `GymMembershipSystem/Forms/Payments/PaymentsViewControl.cs`
- **Actions**:
  1. Implement `LoadPayments()` querying `IPaymentService`.
  2. Wire `btnRecordPayment.Click`:
     - Open `RecordPaymentDialog`.
     - If `DialogResult.OK`, reload payments and refresh revenue totals.
  3. Wire date filter changes to refresh payments list.

---

### Step 6: Verification and Testing
- **Actions**:
  1. Attempt to enter payment of $0.00: verify error provider blocks submission (Rule 9).
  2. Assign a $50 plan to a member: verify their outstanding balance displays as $50.00.
  3. Record a $30 payment: verify their balance recalculates to $20.00 immediately.
  4. Verify payment appears in the history grid and the monthly revenue card updates.
