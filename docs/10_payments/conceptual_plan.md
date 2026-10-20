# Component 10: Payments & Financial Billing

## 1. Conceptual Overview
The Payments component satisfies Requirement **D11** ("Record payments: member, amount, date, method; and show outstanding balance") and business rules:
- **Business Rule 9**: A payment amount must be greater than 0 and is recorded against a member.
- **Business Rule 10**: Only an Administrator can record payments and check-ins.

### Primary Responsibilities:
- Recording payments received from members towards their plan subscriptions.
- Supporting multiple payment methods: Cash, Credit Card, Debit Card, Bank Transfer, Mobile Money.
- Dynamic calculation of financial balances per member:
  $$\text{Total Billed} = \sum \text{Plan Prices for Member's Subscriptions}$$
  $$\text{Total Paid} = \sum \text{Payment Amounts for Member}$$
  $$\text{Outstanding Balance} = \text{Total Billed} - \text{Total Paid}$$
- Providing a financial ledger view showing payment history by date range and member.

---

## 2. Event-Driven Patterns
- **`PaymentRecorded` Domain Event**: Fired whenever a payment is registered. Updates the revenue summary tile on the Dashboard and refreshes member balance labels.
- **Member Selection Event**: When a member is picked in the Payment form, the form automatically fetches and calculates their outstanding balance and pre-fills the amount due.

---

## 3. UI/UX Design Specification
- **View**: `PaymentsViewControl` (UserControl).
- **Controls & Components**:
  - Filter Bar: Date range pickers (`dtpFrom`, `dtpTo`), `txtMemberFilter`, `btnNewPayment`, `btnExportSummary`.
  - Financial KPI Badges:
    - `lblTotalRevenue`: Total payments collected this month.
    - `lblOutstandingTotal`: Aggregate unpaid balances.
  - Payments History Grid (`DataGridView`):
    - Columns: `Receipt #`, `Member Name`, `Date`, `Amount Paid`, `Payment Method`, `Admin Received By`, `Notes`.
- **Dialog**: `RecordPaymentDialog` (Modal):
  - `cboMember`: Select member (displays full name and current balance).
  - Balance Panel: Displays `Current Balance: $XX.XX` (highlighted in red if positive, green if $0.00).
  - `numAmount`: NumericUpDown for amount (Min: 0.01, Step: 10.00, formatted as currency).
  - `cboPaymentMethod`: Dropdown of payment methods.
  - `dtpPaymentDate`: Defaults to Today.
  - `txtNotes`: Optional memo/receipt reference.
  - Action buttons: `btnSavePayment`, `btnCancel`.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IPaymentService.cs` | Service contract for payments and billing calculations. |
| `GymMembershipSystem/Services/PaymentService.cs` | Business rules implementation enforcing Rules 9 & 10. |
| `GymMembershipSystem/Forms/Payments/PaymentsViewControl.cs` | Main view displaying transaction history and revenue summaries. |
| `GymMembershipSystem/Forms/Payments/PaymentsViewControl.Designer.cs` | Designer for payments transaction view. |
| `GymMembershipSystem/Forms/Payments/RecordPaymentDialog.cs` | Modal dialog for entering new member payments. |
| `GymMembershipSystem/Forms/Payments/RecordPaymentDialog.Designer.cs` | Designer for payment entry modal. |
