# Component 11: Reports & Business Analytics

## 1. Conceptual Overview
The Reports component satisfies Requirement **D14** ("Simple report view: total members, active vs. expired members, today's attendance, total payments") and Section **7** ("Reports: Total number of members, active and expired members, total payments/income per month, attendance per day, bookings per class and class fill rate").

### Primary Responsibilities:
- Centralized reporting screen providing operational insights for the administrator.
- Calculating metrics on demand:
  1. **Member Metrics**: Total registered members, Active members count, Expired members count, Inactive/deactivated members count.
  2. **Financial Metrics**: Total revenue generated this month, total revenue all-time, total outstanding receivables across all members.
  3. **Attendance Metrics**: Total check-ins today, average daily check-ins for the current month.
  4. **Class Fill Rate Metrics**: Bookings per class and fill rate percentage:
     $$\text{Fill Rate} = \left(\frac{\text{Active Bookings}}{\text{Class Capacity}}\right) \times 100\%$$
- Visual representation using KPI summary cards, structured summary tables, and date-range filtering.

---

## 2. Event-Driven Patterns
- **Real-Time KPI Auto-Refresh via Event Subscriptions**:
  - Subscribes to `AppEvents.MemberChanged`: auto-updates member KPI cards.
  - Subscribes to `AppEvents.PaymentReceived`: auto-updates revenue totals.
  - Subscribes to `AppEvents.AttendanceRecorded`: auto-updates today's check-in counter.
  - Subscribes to `AppEvents.ClassBookingChanged`: auto-updates class fill rate tables.

---

## 3. UI/UX Design Specification
- **View**: `ReportsViewControl` (UserControl).
- **Controls & Components**:
  - **KPI Metric Ribbon**:
    - Card 1: 👥 Total Members (Active / Expired breakdown)
    - Card 2: 💵 Monthly Revenue ($)
    - Card 3: 🕒 Today's Check-ins
    - Card 4: ⚠️ Outstanding Balances ($)
  - **Tabs / Sections (`TabControl`)**:
    - **Tab 1: Membership Status**: Pie/Table breakdown of Active vs. Expired members with list export.
    - **Tab 2: Class Fill Rates**: Table showing Class Name, Trainer, Capacity, Booked Count, Fill Rate % (with progress bar column).
    - **Tab 3: Monthly Revenue Summary**: Table grouping total payments collected by month.
    - **Tab 4: Daily Attendance**: Summary of daily check-ins over the past 30 days.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IReportService.cs` | Service contract for aggregating analytics and metrics. |
| `GymMembershipSystem/Services/ReportService.cs` | In-memory aggregation logic querying `InMemoryDataStore`. |
| `GymMembershipSystem/Models/ReportModels.cs` | DTOs for `DashboardMetrics`, `ClassFillRateReport`, `MonthlyRevenueReport`. |
| `GymMembershipSystem/Forms/Reports/ReportsViewControl.cs` | Main view displaying analytics, KPI cards, and breakdowns. |
| `GymMembershipSystem/Forms/Reports/ReportsViewControl.Designer.cs` | Designer for reports view. |
