# Component 08: Classes & Member Bookings

## 1. Conceptual Overview
The Classes & Bookings component satisfies Requirements **D8** ("Create, edit, and delete classes: name, trainer, day, time, capacity"), **D9** ("Book a member into a class and cancel a booking"), and Business Rules:
- **Business Rule 3**: A class booking is accepted only if the number of active bookings is below the class capacity. When capacity is reached, new bookings are rejected with a "Class is full" message.
- **Business Rule 4**: A member cannot book the same class twice.
- **Business Rule 5**: Cancelling a booking frees one place.
- **Business Rule 6**: Capacity cannot be reduced below the current number of bookings.

### Primary Responsibilities:
- Managing gym class schedules (e.g., "Morning Yoga", "HIIT Blast", "Spin Session").
- Viewing real-time capacity and active attendees per class.
- Member class booking workflow with instant capacity validation.
- Booking cancellation workflow with immediate capacity restitution.
- Modifying class details while protecting against reducing capacity below active bookings.

---

## 2. Event-Driven Patterns
- **`ClassBookingChanged` Event**: When a member books or cancels, updates the visual fill rate progress bar or capacity counter on the Class Schedule screen.
- **`ClassSelected` Event**: Clicking a class in the schedule grid automatically populates the roster listbox with the names and phone numbers of all booked members.
- **Input Validation**: `numCapacity` validating event preventing the admin from setting a capacity lower than current active bookings (Rule 6).

---

## 3. UI/UX Design Specification
- **View**: `ClassesViewControl` (Split View layout):
  - **Left Section (Class Schedule Table)**:
    - Search by class name, filter by Day of Week (Monday - Sunday) or Trainer.
    - Grid columns: `ID`, `Class Name`, `Trainer`, `Day`, `Time`, `Capacity`, `Booked Spots`, `Availability Status`.
    - Action Buttons: `btnNewClass`, `btnEditClass`, `btnDeleteClass`.
  - **Right Section (Roster & Booking Panel)**:
    - Class Header: Name, Day/Time, Trainer.
    - Capacity Gauge / Progress bar: e.g., "18 / 20 Booked (2 spots left)".
    - Roster List (`lvwBookedMembers`): List of booked members.
    - Action Buttons:
      - `btnBookMember`: Opens member selector dialog to book an active member.
      - `btnCancelBooking`: Cancels selected member's booking and frees spot.

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Services/Interfaces/IClassService.cs` | Service contract for class schedule and booking operations. |
| `GymMembershipSystem/Services/ClassService.cs` | In-memory implementation enforcing Business Rules 3, 4, 5, and 6. |
| `GymMembershipSystem/Forms/Classes/ClassesViewControl.cs` | Master-detail view for class schedules and class roster. |
| `GymMembershipSystem/Forms/Classes/ClassesViewControl.Designer.cs` | Designer for classes master-detail view. |
| `GymMembershipSystem/Forms/Classes/ClassEditDialog.cs` | Modal dialog for creating and editing gym classes. |
| `GymMembershipSystem/Forms/Classes/ClassEditDialog.Designer.cs` | Designer for class edit modal. |
| `GymMembershipSystem/Forms/Classes/BookClassDialog.cs` | Member picker dialog for booking a member into a class. |
| `GymMembershipSystem/Forms/Classes/BookClassDialog.Designer.cs` | Designer for class booking dialog. |
