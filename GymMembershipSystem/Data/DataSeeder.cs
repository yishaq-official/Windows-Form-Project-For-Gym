using System;
using System.Collections.Generic;
using System.Linq;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Data
{
    /// <summary>
    /// Generates realistic initial demonstration seed data for Phase 1.
    /// </summary>
    public static class DataSeeder
    {
        public static void Seed(InMemoryDataStore store, bool force = false)
        {
            lock (store.SyncRoot)
            {
                if (!force && store.Users.Any())
                {
                    return; // Already seeded
                }

                store.Clear();

                // 1. Seed Users
                var adminUser = new User
                {
                    Id = store.NextUserId(),
                    Username = "admin",
                    PasswordHash = PasswordHasher.HashPassword("admin123"),
                    FullName = "System Administrator",
                    Role = UserRole.Administrator,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow.AddMonths(-6)
                };

                var trainerUser = new User
                {
                    Id = store.NextUserId(),
                    Username = "trainer",
                    PasswordHash = PasswordHasher.HashPassword("trainer123"),
                    FullName = "Marcus Vance",
                    Role = UserRole.Trainer,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow.AddMonths(-4)
                };

                var memberUser = new User
                {
                    Id = store.NextUserId(),
                    Username = "member",
                    PasswordHash = PasswordHasher.HashPassword("member123"),
                    FullName = "Sarah Connor",
                    Role = UserRole.Member,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow.AddMonths(-2)
                };

                store.Users.AddRange(new[] { adminUser, trainerUser, memberUser });

                // 2. Seed Membership Plans
                var planMonthly = new Plan
                {
                    Id = store.NextPlanId(),
                    Name = "Standard Monthly",
                    DurationInDays = 30,
                    Price = 30.00m,
                    IsActive = true
                };

                var planQuarterly = new Plan
                {
                    Id = store.NextPlanId(),
                    Name = "Quarterly Fitness",
                    DurationInDays = 90,
                    Price = 80.00m,
                    IsActive = true
                };

                var planAnnual = new Plan
                {
                    Id = store.NextPlanId(),
                    Name = "Annual VIP",
                    DurationInDays = 365,
                    Price = 280.00m,
                    IsActive = true
                };

                var planTrial = new Plan
                {
                    Id = store.NextPlanId(),
                    Name = "14-Day Trial",
                    DurationInDays = 14,
                    Price = 15.00m,
                    IsActive = true
                };

                store.Plans.AddRange(new[] { planMonthly, planQuarterly, planAnnual, planTrial });

                // 3. Seed Trainers
                var trainer1 = new Trainer
                {
                    Id = store.NextTrainerId(),
                    FullName = "Marcus Vance",
                    Specialty = "Strength & Conditioning",
                    Phone = "+1-555-0101",
                    IsActive = true
                };

                var trainer2 = new Trainer
                {
                    Id = store.NextTrainerId(),
                    FullName = "Elena Rostova",
                    Specialty = "Yoga & Pilates",
                    Phone = "+1-555-0102",
                    IsActive = true
                };

                var trainer3 = new Trainer
                {
                    Id = store.NextTrainerId(),
                    FullName = "David Kim",
                    Specialty = "HIIT & Cardio Conditioning",
                    Phone = "+1-555-0103",
                    IsActive = true
                };

                var trainer4 = new Trainer
                {
                    Id = store.NextTrainerId(),
                    FullName = "Aaliyah Patel",
                    Specialty = "Rehabilitation & Mobility",
                    Phone = "+1-555-0104",
                    IsActive = true
                };

                store.Trainers.AddRange(new[] { trainer1, trainer2, trainer3, trainer4 });

                // 4. Seed Members
                var member1 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Sarah Connor",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1985, 5, 12),
                    Phone = "+1-555-1101",
                    Email = "sarah.connor@example.com",
                    Address = "101 Resistance Way, Los Angeles, CA",
                    JoinDate = DateTime.Today.AddDays(-60),
                    IsActive = true
                };

                var member2 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Bruce Wayne",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1990, 2, 19),
                    Phone = "+1-555-1102",
                    Email = "bruce.wayne@example.com",
                    Address = "1007 Mountain Drive, Gotham",
                    JoinDate = DateTime.Today.AddDays(-120),
                    IsActive = true
                };

                var member3 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Diana Prince",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1992, 3, 22),
                    Phone = "+1-555-1103",
                    Email = "diana.prince@example.com",
                    Address = "500 Gateway City Blvd",
                    JoinDate = DateTime.Today.AddDays(-20),
                    IsActive = true
                };

                var member4 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Peter Parker",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2001, 8, 10),
                    Phone = "+1-555-1104",
                    Email = "peter.parker@example.com",
                    Address = "20 Ingram St, Forest Hills, NY",
                    JoinDate = DateTime.Today.AddDays(-10),
                    IsActive = true
                };

                var member5 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Clark Kent",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1988, 6, 18),
                    Phone = "+1-555-1105",
                    Email = "clark.kent@example.com",
                    Address = "344 Clinton St, Metropolis",
                    JoinDate = DateTime.Today.AddDays(-45),
                    IsActive = true
                };

                var member6 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Natasha Romanoff",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1994, 11, 22),
                    Phone = "+1-555-1106",
                    Email = "natasha.r@example.com",
                    Address = "New York, NY",
                    JoinDate = DateTime.Today.AddDays(-5),
                    IsActive = true
                };

                var member7 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Barry Allen",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1995, 9, 30),
                    Phone = "+1-555-1107",
                    Email = "barry.allen@example.com",
                    Address = "Central City Plaza",
                    JoinDate = DateTime.Today.AddDays(-2),
                    IsActive = true
                };

                var member8 = new Member
                {
                    Id = store.NextMemberId(),
                    FullName = "Arthur Curry",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1986, 1, 29),
                    Phone = "+1-555-1108",
                    Email = "arthur.curry@example.com",
                    Address = "Amnesty Bay Light",
                    JoinDate = DateTime.Today.AddDays(-30),
                    IsActive = false // Inactive / Deactivated
                };

                store.Members.AddRange(new[] { member1, member2, member3, member4, member5, member6, member7, member8 });

                // 5. Seed Subscriptions
                // Sarah: Annual VIP, Active, Trainer assigned (Marcus)
                var sub1 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member1.Id,
                    PlanId = planAnnual.Id,
                    StartDate = DateTime.Today.AddDays(-60),
                    ExpiryDate = DateTime.Today.AddDays(-60).AddDays(planAnnual.DurationInDays),
                    TrainerId = trainer1.Id,
                    Status = MembershipStatus.Active
                };

                // Bruce: Annual VIP, Active, Trainer assigned (David)
                var sub2 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member2.Id,
                    PlanId = planAnnual.Id,
                    StartDate = DateTime.Today.AddDays(-120),
                    ExpiryDate = DateTime.Today.AddDays(-120).AddDays(planAnnual.DurationInDays),
                    TrainerId = trainer3.Id,
                    Status = MembershipStatus.Active
                };

                // Diana: Quarterly Fitness, Active, Trainer assigned (Elena)
                var sub3 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member3.Id,
                    PlanId = planQuarterly.Id,
                    StartDate = DateTime.Today.AddDays(-20),
                    ExpiryDate = DateTime.Today.AddDays(-20).AddDays(planQuarterly.DurationInDays),
                    TrainerId = trainer2.Id,
                    Status = MembershipStatus.Active
                };

                // Peter: Monthly, Active, Trainer assigned (Marcus)
                var sub4 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member4.Id,
                    PlanId = planMonthly.Id,
                    StartDate = DateTime.Today.AddDays(-10),
                    ExpiryDate = DateTime.Today.AddDays(-10).AddDays(planMonthly.DurationInDays),
                    TrainerId = trainer1.Id,
                    Status = MembershipStatus.Active
                };

                // Clark: Monthly, Expired 15 days ago
                var sub5 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member5.Id,
                    PlanId = planMonthly.Id,
                    StartDate = DateTime.Today.AddDays(-45),
                    ExpiryDate = DateTime.Today.AddDays(-45).AddDays(planMonthly.DurationInDays), // Expired 15 days ago
                    TrainerId = null,
                    Status = MembershipStatus.Expired
                };

                // Natasha: Quarterly, Active
                var sub6 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member6.Id,
                    PlanId = planQuarterly.Id,
                    StartDate = DateTime.Today.AddDays(-5),
                    ExpiryDate = DateTime.Today.AddDays(-5).AddDays(planQuarterly.DurationInDays),
                    TrainerId = trainer3.Id,
                    Status = MembershipStatus.Active
                };

                // Barry: Trial, Active
                var sub7 = new Subscription
                {
                    Id = store.NextSubscriptionId(),
                    MemberId = member7.Id,
                    PlanId = planTrial.Id,
                    StartDate = DateTime.Today.AddDays(-2),
                    ExpiryDate = DateTime.Today.AddDays(-2).AddDays(planTrial.DurationInDays),
                    TrainerId = null,
                    Status = MembershipStatus.Active
                };

                store.Subscriptions.AddRange(new[] { sub1, sub2, sub3, sub4, sub5, sub6, sub7 });

                // 6. Seed Gym Classes
                var class1 = new GymClass
                {
                    Id = store.NextClassId(),
                    Name = "Sunrise Power Yoga",
                    TrainerId = trainer2.Id,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(7, 0, 0),
                    DurationMinutes = 60,
                    Capacity = 15,
                    IsActive = true
                };

                var class2 = new GymClass
                {
                    Id = store.NextClassId(),
                    Name = "HIIT Inferno Blast",
                    TrainerId = trainer3.Id,
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(18, 0, 0),
                    DurationMinutes = 45,
                    Capacity = 12,
                    IsActive = true
                };

                var class3 = new GymClass
                {
                    Id = store.NextClassId(),
                    Name = "Heavy Iron Bench & Squat",
                    TrainerId = trainer1.Id,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(17, 30, 0),
                    DurationMinutes = 60,
                    Capacity = 10,
                    IsActive = true
                };

                var class4 = new GymClass
                {
                    Id = store.NextClassId(),
                    Name = "Core & Pilates Sculpt",
                    TrainerId = trainer4.Id,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 30, 0),
                    DurationMinutes = 50,
                    Capacity = 14,
                    IsActive = true
                };

                var class5 = new GymClass
                {
                    Id = store.NextClassId(),
                    Name = "Weekend Kickboxing",
                    TrainerId = trainer3.Id,
                    DayOfWeek = DayOfWeek.Saturday,
                    StartTime = new TimeSpan(10, 0, 0),
                    DurationMinutes = 60,
                    Capacity = 16,
                    IsActive = true
                };

                store.Classes.AddRange(new[] { class1, class2, class3, class4, class5 });

                // 7. Seed Bookings
                store.Bookings.Add(new Booking
                {
                    Id = store.NextBookingId(),
                    ClassId = class1.Id,
                    MemberId = member3.Id,
                    BookingDate = DateTime.Today,
                    IsCancelled = false
                });

                store.Bookings.Add(new Booking
                {
                    Id = store.NextBookingId(),
                    ClassId = class2.Id,
                    MemberId = member2.Id,
                    BookingDate = DateTime.Today,
                    IsCancelled = false
                });

                store.Bookings.Add(new Booking
                {
                    Id = store.NextBookingId(),
                    ClassId = class3.Id,
                    MemberId = member1.Id,
                    BookingDate = DateTime.Today,
                    IsCancelled = false
                });

                store.Bookings.Add(new Booking
                {
                    Id = store.NextBookingId(),
                    ClassId = class4.Id,
                    MemberId = member4.Id,
                    BookingDate = DateTime.Today,
                    IsCancelled = false
                });

                store.Bookings.Add(new Booking
                {
                    Id = store.NextBookingId(),
                    ClassId = class5.Id,
                    MemberId = member6.Id,
                    BookingDate = DateTime.Today,
                    IsCancelled = false
                });

                // 8. Seed Attendance (Today and historical)
                // Sarah Connor checked in and out today
                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member1.Id,
                    CheckInTime = DateTime.Today.AddHours(8).AddMinutes(15),
                    CheckOutTime = DateTime.Today.AddHours(9).AddMinutes(45)
                });

                // Bruce Wayne currently checked in (inside)
                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member2.Id,
                    CheckInTime = DateTime.Today.AddHours(9).AddMinutes(30),
                    CheckOutTime = null
                });

                // Diana Prince checked in and out today
                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member3.Id,
                    CheckInTime = DateTime.Today.AddHours(10).AddMinutes(0),
                    CheckOutTime = DateTime.Today.AddHours(11).AddMinutes(20)
                });

                // Peter Parker currently checked in (inside)
                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member4.Id,
                    CheckInTime = DateTime.Today.AddHours(12).AddMinutes(5),
                    CheckOutTime = null
                });

                // Historical attendances for reporting
                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member1.Id,
                    CheckInTime = DateTime.Today.AddDays(-1).AddHours(8).AddMinutes(0),
                    CheckOutTime = DateTime.Today.AddDays(-1).AddHours(9).AddMinutes(30)
                });

                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member2.Id,
                    CheckInTime = DateTime.Today.AddDays(-1).AddHours(18).AddMinutes(0),
                    CheckOutTime = DateTime.Today.AddDays(-1).AddHours(19).AddMinutes(45)
                });

                store.Attendances.Add(new Attendance
                {
                    Id = store.NextAttendanceId(),
                    MemberId = member3.Id,
                    CheckInTime = DateTime.Today.AddDays(-2).AddHours(7).AddMinutes(30),
                    CheckOutTime = DateTime.Today.AddDays(-2).AddHours(8).AddMinutes(45)
                });

                // 9. Seed Payments
                // Sarah Connor paid for Annual VIP ($280.00)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member1.Id,
                    Amount = planAnnual.Price,
                    PaymentDate = DateTime.Today.AddDays(-60),
                    PaymentMethod = PaymentMethod.CreditCard,
                    Notes = "Annual VIP subscription initial fee"
                });

                // Bruce Wayne paid for Annual VIP ($280.00)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member2.Id,
                    Amount = planAnnual.Price,
                    PaymentDate = DateTime.Today.AddDays(-120),
                    PaymentMethod = PaymentMethod.BankTransfer,
                    Notes = "Full annual payment via bank wire"
                });

                // Diana Prince paid for Quarterly ($80.00)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member3.Id,
                    Amount = planQuarterly.Price,
                    PaymentDate = DateTime.Today.AddDays(-20),
                    PaymentMethod = PaymentMethod.DebitCard,
                    Notes = "Quarterly fitness plan"
                });

                // Peter Parker paid $20.00 partial out of $30.00 (has $10 balance!)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member4.Id,
                    Amount = 20.00m,
                    PaymentDate = DateTime.Today.AddDays(-10),
                    PaymentMethod = PaymentMethod.MobileMoney,
                    Notes = "Partial payment towards monthly plan ($10 outstanding)"
                });

                // Clark Kent paid for his past plan ($30.00)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member5.Id,
                    Amount = planMonthly.Price,
                    PaymentDate = DateTime.Today.AddDays(-45),
                    PaymentMethod = PaymentMethod.Cash,
                    Notes = "Monthly plan payment"
                });

                // Natasha Romanoff paid for Quarterly ($80.00)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member6.Id,
                    Amount = planQuarterly.Price,
                    PaymentDate = DateTime.Today.AddDays(-5),
                    PaymentMethod = PaymentMethod.CreditCard,
                    Notes = "Quarterly plan enrollment"
                });

                // Barry Allen paid for Trial ($15.00)
                store.Payments.Add(new Payment
                {
                    Id = store.NextPaymentId(),
                    MemberId = member7.Id,
                    Amount = planTrial.Price,
                    PaymentDate = DateTime.Today.AddDays(-2),
                    PaymentMethod = PaymentMethod.Cash,
                    Notes = "14-day trial fee"
                });
            }
        }
    }
}
