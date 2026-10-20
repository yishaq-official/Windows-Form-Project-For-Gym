# Component 03: Main Application Shell & Navigation

## 1. Conceptual Overview
The Main Application Shell fulfills Requirement **D2** ("Main form with menu and toolbar for navigating between forms") and provides the primary dashboard container for administrators. Rather than using an outdated, clunky Multiple Document Interface (MDI) with floating windows, modern WinForms applications utilize a **Left Navigation Sidebar + Dynamic Content Docking Panel** pattern. This offers a unified, polished single-window desktop experience while still supporting dedicated modal dialogs for add/edit operations.

### Primary Responsibilities:
- Top application bar showing system title, current date/time, logged-in administrator name, and a "Logout" action.
- Left-hand collapsible navigation sidebar with buttons for every major system module.
- Central host panel (`pnlMainContent`) where UserControls or docked views for Members, Plans, Trainers, Classes, Attendance, Payments, and Reports are hosted on demand.
- Bottom status strip showing system status, active database connection indicator (in-memory mode), and real-time clock.

---

## 2. Event-Driven Patterns
- **Sidebar Button Navigation Events**: Clicking any navigation button switches the view inside `pnlMainContent` and updates the active highlight style.
- **Timer Tick Event**: A 1-second system timer updates the real-time clock and date display in the status bar.
- **`SessionChanged` Event**: When logout is triggered, the shell closes and prompts `Program.cs` to show the `LoginForm` again.

---

## 3. UI/UX Design Specification
- **Form**: `MainForm` (Window state: Maximized or 1200x750 minimum).
- **Layout Zones**:
  - `pnlTopBar` (Dock: Top, Height: 55px): Dark theme header, Gym Logo/Text, logged-in user badge ("Welcome, Admin"), "Logout" button.
  - `pnlSidebar` (Dock: Left, Width: 220px): Navigation buttons with icons/emojis:
    - 📊 Dashboard & Reports
    - 👥 Members
    - 📋 Membership Plans
    - 🏋️ Trainers
    - 📅 Classes & Bookings
    - 🕒 Attendance (Check-in)
    - 💳 Payments & Billing
    - ⚙️ User Accounts
  - `pnlContentHost` (Dock: Fill): Container panel with `AutoScroll = true` that dynamically houses the active module view.
  - `statusStrip` (Dock: Bottom): Shows `lblStatus` ("Ready"), `lblStorageMode` ("Mode: In-Memory (Phase 1)"), and `lblClock`.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Forms/Dashboard/MainForm.cs` | Main container code-behind, navigation routing, session management. |
| `GymMembershipSystem/Forms/Dashboard/MainForm.Designer.cs` | Designer layout for header, sidebar, content host, and status strip. |
| `GymMembershipSystem/Forms/Dashboard/DashboardViewControl.cs` | Default landing view showing KPI summary tiles and quick-action buttons. |
| `GymMembershipSystem/Forms/Dashboard/DashboardViewControl.Designer.cs` | Designer for KPI metric widgets. |
| `GymMembershipSystem/Common/NavigationService.cs` | Helper to switch active views inside `pnlContentHost` cleanly. |
