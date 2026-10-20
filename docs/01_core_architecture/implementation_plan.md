# Component 01: Core Architecture — Implementation Plan

This plan breaks down the construction of the domain model and in-memory storage infrastructure into granular steps.

---

### Step 1: Define System Enums
- **File**: `GymMembershipSystem/Models/Enums.cs`
- **Actions**:
  1. Define `UserRole` (`Administrator`, `Trainer`, `Member`).
  2. Define `MembershipStatus` (`Active`, `Expired`, `Inactive`).
  3. Define `Gender` (`Male`, `Female`, `Other`).
  4. Define `PaymentMethod` (`Cash`, `CreditCard`, `DebitCard`, `BankTransfer`, `MobileMoney`).
  5. Define `ChangeType` (`Created`, `Updated`, `Deleted`).

---

### Step 2: Implement Domain Entities
- **Files**:
  - `GymMembershipSystem/Models/User.cs`
  - `GymMembershipSystem/Models/Member.cs`
  - `GymMembershipSystem/Models/Plan.cs`
  - `GymMembershipSystem/Models/Subscription.cs`
  - `GymMembershipSystem/Models/Trainer.cs`
  - `GymMembershipSystem/Models/GymClass.cs`
  - `GymMembershipSystem/Models/Booking.cs`
  - `GymMembershipSystem/Models/Attendance.cs`
  - `GymMembershipSystem/Models/Payment.cs`
- **Actions**:
  1. Add typed properties matching requirements D3, D4, D5, D7, D8, D9, D10, D11, D15.
  2. Implement calculated properties (e.g., `Member.Age` calculated from `DateOfBirth`, `GymClass.AvailableSpots`).
  3. Add string formatting overrides (`ToString()`) for seamless binding in WinForms `ComboBox` and `ListBox`.

---

### Step 3: Implement Common Utilities & Result Type
- **Files**:
  - `GymMembershipSystem/Common/Result.cs`
  - `GymMembershipSystem/Common/AppEvents.cs`
- **Actions**:
  1. Create a generic `Result<T>` and non-generic `Result` with `IsSuccess`, `Error`, `Value` to enforce graceful business validation without throwing UI unhandled exceptions.
  2. Implement `AppEvents` static class exposing `event Action<Member, ChangeType>? MemberChanged`, `event Action<Payment>? PaymentRecorded`, etc.

---

### Step 4: Implement In-Memory Data Store
- **File**: `GymMembershipSystem/Data/InMemoryDataStore.cs`
- **Actions**:
  1. Create a thread-safe singleton store `InMemoryDataStore.Instance`.
  2. Define internal generic lists:
     - `List<User> Users`
     - `List<Member> Members`
     - `List<Plan> Plans`
     - `List<Subscription> Subscriptions`
     - `List<Trainer> Trainers`
     - `List<GymClass> Classes`
     - `List<Booking> Bookings`
     - `List<Attendance> Attendances`
     - `List<Payment> Payments`
  3. Implement auto-increment ID generation helpers for each entity.

---

### Step 5: Implement Seed Data Generator
- **File**: `GymMembershipSystem/Data/DataSeeder.cs`
- **Actions**:
  1. Add default administrator account: `admin` / `admin123`.
  2. Add sample membership plans (e.g., Monthly $30, Quarterly $80, Annual $280).
  3. Add 3-5 sample trainers with specialties (e.g., Strength, Cardio, Yoga).
  4. Add 5-10 sample members (some with active plans, some expired, some new without plans).
  5. Add scheduled classes (Spinning, Weightlifting, HIIT).
  6. Add sample historical attendance and payments.
  7. Expose `DataSeeder.Seed(InMemoryDataStore store)` method.

---

### Step 6: Verification and Sanity Testing
- **Actions**:
  1. Add an invocation of `DataSeeder.Seed` at application boot in `Program.cs`.
  2. Verify that all collections contain seeded data.
  3. Verify entity relationship consistency (e.g., subscription `MemberId` corresponds to an existing `Member.Id`).
