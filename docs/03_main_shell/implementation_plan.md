# Component 03: Main Application Shell — Implementation Plan

This plan breaks down the construction of the primary navigation shell and docking host into step-by-step actions.

---

### Step 1: Implement Navigation Service Helper
- **File**: `GymMembershipSystem/Common/NavigationService.cs`
- **Actions**:
  1. Create a navigation controller that takes a reference to the main container panel (`Panel contentHost`).
  2. Implement `NavigateTo(UserControl viewControl)`:
     - Clear existing controls in `contentHost.Controls`.
     - Set `viewControl.Dock = DockStyle.Fill`.
     - Add `viewControl` to `contentHost.Controls`.
     - Call `viewControl.BringToFront()`.

---

### Step 2: Design MainForm Layout
- **Files**:
  - `GymMembershipSystem/Forms/Dashboard/MainForm.cs`
  - `GymMembershipSystem/Forms/Dashboard/MainForm.Designer.cs`
- **Actions**:
  1. Set Form properties: `Text = "Gym Management System - Administrator Portal"`, `StartPosition = CenterScreen`, `MinimumSize = new Size(1100, 700)`.
  2. Construct `pnlTopBar` (Dock: Top, Height: 55):
     - Place title `lblAppTitle` ("GYM MANAGEMENT SYSTEM").
     - Place user status `lblCurrentUser` ("Logged in as: [Admin Name]").
     - Place `btnLogout` (styled flat button).
  3. Construct `pnlSidebar` (Dock: Left, Width: 220):
     - Add navigation buttons:
       - `btnNavDashboard`
       - `btnNavMembers`
       - `btnNavPlans`
       - `btnNavTrainers`
       - `btnNavClasses`
       - `btnNavAttendance`
       - `btnNavPayments`
       - `btnNavUsers`
  4. Construct `pnlContentHost` (Dock: Fill).
  5. Add `StatusStrip` at the bottom with labels for ready status, in-memory notice, and current system clock.

---

### Step 3: Implement Dashboard Landing View Control
- **Files**:
  - `GymMembershipSystem/Forms/Dashboard/DashboardViewControl.cs`
  - `GymMembershipSystem/Forms/Dashboard/DashboardViewControl.Designer.cs`
- **Actions**:
  1. Create a `UserControl` containing 4 summary KPI cards (Panels with bold numbers and descriptive sub-labels):
     - Total Members
     - Active Members
     - Today's Check-ins
     - Total Payments
  2. Add a quick actions panel:
     - "Quick Check-in" button
     - "New Member Registration" button
     - "Record Payment" button
  3. Wire quick action buttons to invoke the corresponding navigation views or modal dialogs.

---

### Step 4: Wire Navigation Events and Active Button Styling
- **File**: `GymMembershipSystem/Forms/Dashboard/MainForm.cs`
- **Actions**:
  1. In `MainForm_Load`:
     - Display `UserSession.CurrentUser.FullName` in the top bar.
     - Start a 1-second `System.Windows.Forms.Timer` to update the clock.
     - Navigate to `DashboardViewControl` by default.
  2. Implement an `SetActiveButton(Button selectedButton)` method that adjusts background and font colors to visually indicate which tab is active.
  3. Wire each sidebar button's `Click` event to:
     - Call `SetActiveButton(sender as Button)`.
     - Instruct `NavigationService` to load the appropriate UserControl (Members, Plans, etc.).

---

### Step 5: Implement Logout and Exit Flow
- **File**: `GymMembershipSystem/Forms/Dashboard/MainForm.cs`
- **Actions**:
  1. Wire `btnLogout.Click`:
     - Prompt confirmation dialog (D13: "Are you sure you want to log out?").
     - If confirmed: clear `UserSession`, close `MainForm` with `DialogResult = DialogResult.Retry` or restart application flow so `LoginForm` re-displays.
  2. Wire `FormClosing` event to gracefully handle closing confirmation when operations are pending.

---

### Step 6: Verification and Testing
- **Actions**:
  1. Verify window renders properly across varied display resolutions (100% and 125% DPI).
  2. Verify sidebar buttons highlight cleanly when clicked.
  3. Verify switching between views works without flickering or memory leaks.
  4. Verify logout properly returns to the login screen.
