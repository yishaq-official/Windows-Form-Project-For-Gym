# Component 11: Reports — Implementation Plan

This plan outlines the atomic implementation steps for business analytics and report generation.

---

### Step 1: Define Report DTOs and Service Interface
- **Files**:
  - `GymMembershipSystem/Models/ReportModels.cs`
  - `GymMembershipSystem/Services/Interfaces/IReportService.cs`
  - `GymMembershipSystem/Services/ReportService.cs`
- **Actions**:
  1. Define DTO models:
     - `DashboardMetrics`: `TotalMembers`, `ActiveMembers`, `ExpiredMembers`, `TodayAttendanceCount`, `MonthlyRevenue`, `TotalOutstandingBalance`.
     - `ClassFillRateItem`: `ClassId`, `ClassName`, `TrainerName`, `Capacity`, `BookedCount`, `FillRatePercentage`.
     - `MonthlyIncomeItem`: `Year`, `MonthName`, `TotalIncome`, `TransactionCount`.
     - `DailyAttendanceItem`: `Date`, `TotalVisits`.
  2. Implement `IReportService` methods:
     - `DashboardMetrics GetDashboardMetrics()`
     - `IReadOnlyList<ClassFillRateItem> GetClassFillRates()`
     - `IReadOnlyList<MonthlyIncomeItem> GetMonthlyIncomeSummary()`
     - `IReadOnlyList<DailyAttendanceItem> GetDailyAttendanceSummary(int days = 30)`

---

### Step 2: Implement Reporting Service Logic
- **File**: `GymMembershipSystem/Services/ReportService.cs`
- **Actions**:
  1. Compute `DashboardMetrics`:
     - Count total members where `IsActive == true`.
     - Count active vs expired subscriptions.
     - Sum payments where `PaymentDate.Month == DateTime.Today.Month && PaymentDate.Year == DateTime.Today.Year`.
     - Count attendances where `CheckInTime.Date == DateTime.Today`.
  2. Compute `ClassFillRates`:
     - For each class, query active bookings count.
     - Calculate `(BookedCount / (double)Capacity) * 100.0`.
  3. Compute `MonthlyIncome`:
     - Group `InMemoryDataStore.Instance.Payments` by `Year` and `Month`, ordering descending.
  4. Compute `DailyAttendance`:
     - Group `InMemoryDataStore.Instance.Attendances` by `CheckInTime.Date` for the past 30 days.

---

### Step 3: Design Reports View Control Layout
- **Files**:
  - `GymMembershipSystem/Forms/Reports/ReportsViewControl.cs`
  - `GymMembershipSystem/Forms/Reports/ReportsViewControl.Designer.cs`
- **Actions**:
  1. Top KPI Summary Ribbon: 4 distinct panels with accent colors displaying metric titles and large numerical figures.
  2. `TabControl` (`tabReports`):
     - **Tab 1: Class Fill Rates**: `DataGridView` with columns (`Class Name`, `Trainer`, `Capacity`, `Booked`, `Fill Rate %`).
     - **Tab 2: Monthly Revenue**: `DataGridView` with columns (`Month/Year`, `Total Payments Recorded`, `Total Revenue ($)`).
     - **Tab 3: Attendance Analytics**: `DataGridView` with columns (`Date`, `Day of Week`, `Total Member Check-ins`).
  3. Action bar: `btnRefreshReports` and `btnPrintOrExport` (placeholder or CSV export).

---

### Step 4: Wire Real-Time Subscriptions and Event-Driven Updates
- **File**: `GymMembershipSystem/Forms/Reports/ReportsViewControl.cs`
- **Actions**:
  1. Implement `RefreshAllReports()` to query `IReportService` and bind to KPI panels and grids.
  2. In `OnLoad`, subscribe to domain events:
     - `AppEvents.MemberChanged += (m, t) => SafeRefresh();`
     - `AppEvents.PaymentReceived += (p) => SafeRefresh();`
     - `AppEvents.AttendanceRecorded += (a) => SafeRefresh();`
     - `AppEvents.ClassBookingChanged += (c) => SafeRefresh();`
  3. Unsubscribe events on `Dispose` to prevent memory leaks.
  4. Ensure thread-safety using `BeginInvoke` if events arrive from non-UI threads.

---

### Step 5: Verification and Testing
- **Actions**:
  1. Open reports: verify KPI cards match seeded database counts.
  2. Check in a member in the attendance view: verify "Today's Check-ins" increments automatically.
  3. Record a new payment: verify "Monthly Revenue" updates automatically.
  4. Book a member into a class: verify "Class Fill Rate %" updates accurately.
