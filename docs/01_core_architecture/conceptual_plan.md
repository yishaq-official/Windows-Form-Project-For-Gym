# Component 01: Core Architecture & In-Memory Data Store

## 1. Conceptual Overview
The core architecture establishes the foundational data structures, in-memory repository, domain models, and an event-broker system for the desktop application. In Phase 1, data persistence is maintained in memory via a singleton store. In Phase 2, this store will be replaced by API clients without modifying UI forms.

### Primary Responsibilities:
- Centralized data storage for `Members`, `Plans`, `Subscriptions`, `Trainers`, `Classes`, `Bookings`, `Attendance`, `Payments`, and `Users`.
- Seed data initialization (pre-populating realistic records so testing is instant).
- Global event bus for decoupled pub/sub events (e.g., `PaymentRecorded`, `AttendanceLogged`, `MemberStatusChanged`).
- Thread-safe collections and unique identifier generation.

---

## 2. Event-Driven Patterns
- **`AppEvents` (Event Aggregator / Broker)**:
  - Event: `MemberChanged(Member member, ChangeType changeType)`
  - Event: `AttendanceRecorded(Attendance attendance)`
  - Event: `PaymentReceived(Payment payment)`
  - Event: `ClassBookingChanged(GymClass gymClass)`
- **Subscriber Benefit**: When attendance is marked on the Attendance form, the Dashboard form automatically updates its "Today's Attendance" counter via event handling without direct form-to-form coupling.

---

## 3. Domain Entities & Enums
- **Enums**:
  - `UserRole`: `Administrator`, `Trainer`, `Member`
  - `MembershipStatus`: `Active`, `Expired`, `Inactive`
  - `Gender`: `Male`, `Female`, `Other`
  - `PaymentMethod`: `Cash`, `CreditCard`, `DebitCard`, `BankTransfer`, `MobileMoney`
- **Entities**:
  - `User`: `Id`, `Username`, `PasswordHash`, `FullName`, `Role`, `IsActive`, `CreatedAt`
  - `Member`: `Id`, `FullName`, `Gender`, `DateOfBirth`, `Phone`, `Email`, `Address`, `JoinDate`, `IsActive`
  - `Plan`: `Id`, `Name`, `DurationInDays`, `Price`, `IsActive`
  - `Subscription`: `Id`, `MemberId`, `PlanId`, `StartDate`, `ExpiryDate`, `TrainerId?`, `Status`
  - `Trainer`: `Id`, `FullName`, `Specialty`, `Phone`, `IsActive`
  - `GymClass`: `Id`, `Name`, `TrainerId`, `DayOfWeek`, `StartTime`, `DurationMinutes`, `Capacity`
  - `Booking`: `Id`, `ClassId`, `MemberId`, `BookingDate`, `IsCancelled`
  - `Attendance`: `Id`, `MemberId`, `CheckInTime`, `CheckOutTime?`
  - `Payment`: `Id`, `MemberId`, `Amount`, `PaymentDate`, `PaymentMethod`, `Notes`

---

## 4. Planned Implementation Files

| File Path | Purpose |
|-----------|---------|
| `GymMembershipSystem/Models/Enums.cs` | Contains all system enums (`UserRole`, `MembershipStatus`, `Gender`, `PaymentMethod`). |
| `GymMembershipSystem/Models/User.cs` | System user entity. |
| `GymMembershipSystem/Models/Member.cs` | Member entity. |
| `GymMembershipSystem/Models/Plan.cs` | Membership plan entity. |
| `GymMembershipSystem/Models/Subscription.cs` | Subscription relationship entity. |
| `GymMembershipSystem/Models/Trainer.cs` | Trainer entity. |
| `GymMembershipSystem/Models/GymClass.cs` | Gym class schedule entity. |
| `GymMembershipSystem/Models/Booking.cs` | Member-to-class booking entity. |
| `GymMembershipSystem/Models/Attendance.cs` | Attendance check-in/out record entity. |
| `GymMembershipSystem/Models/Payment.cs` | Payment transaction entity. |
| `GymMembershipSystem/Data/InMemoryDataStore.cs` | Centralized data storage with in-memory thread-safe collections. |
| `GymMembershipSystem/Data/DataSeeder.cs` | Generates initial admin account, demo members, plans, trainers, and classes. |
| `GymMembershipSystem/Common/AppEvents.cs` | Static event bus for broadcasting domain events across forms. |
| `GymMembershipSystem/Common/Result.cs` | Standard operation result wrapper (`Success`, `ErrorMessage`). |
