using System;
using System.Windows.Forms;
using GymMembershipSystem.Data;
using GymMembershipSystem.Forms.Auth;
using GymMembershipSystem.Forms.Dashboard;

namespace GymMembershipSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            // Seed Phase 1 in-memory repository with realistic demonstration records
            DataSeeder.Seed(InMemoryDataStore.Instance);

            if (args.Length > 0 && args[0] == "--test-c8")
            {
                RunComponent8Tests();
                return;
            }

            // Authentication & Application Shell Lifecycle Loop
            while (true)
            {
                using var loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    // User canceled or closed the login window -> exit application
                    break;
                }

                using var mainForm = new MainForm();
                Application.Run(mainForm);

                // If user signed out (DialogResult == Retry), loop back to login dialog
                if (mainForm.DialogResult != DialogResult.Retry)
                {
                    break;
                }
            }
        }

        private static void RunComponent8Tests()
        {
            var store = InMemoryDataStore.Instance;
            var classService = new Services.ClassService(store);
            var memberService = new Services.MemberService(store);
            var subService = new Services.SubscriptionService(store);

            Console.WriteLine("==================================================");
            Console.WriteLine("RUNNING AUTOMATED VERIFICATION: COMPONENT 08");
            Console.WriteLine("==================================================");

            // Test 1: Seeded classes exist
            var classes = classService.GetAllClasses();
            Console.WriteLine($"[TEST 1] GetAllClasses returned {classes.Count} classes (Expected >= 5).");
            if (classes.Count < 5) throw new Exception("Expected at least 5 seeded classes.");

            // Test 2: Create a new class with capacity 2
            var trainer = store.Trainers.First(t => t.IsActive);
            var createResult = classService.CreateClass("Mini Bootcamp", trainer.Id, DayOfWeek.Friday, new TimeSpan(14, 0, 0), 45, 2);
            if (createResult.IsFailure) throw new Exception($"CreateClass failed: {createResult.Error}");
            var miniClass = createResult.Value!;
            Console.WriteLine($"[TEST 2] Created class '{miniClass.Name}' with Capacity={miniClass.Capacity}.");

            // Test 3: Rule 1 - Member without active subscription cannot book
            var inactiveMember = new Member
            {
                Id = store.NextMemberId(),
                FullName = "Unsubscribed User",
                Email = "unsub@test.com",
                Phone = "555-0000",
                IsActive = true
            };
            store.Members.Add(inactiveMember);
            var unsubBookResult = classService.BookMember(miniClass.Id, inactiveMember.Id);
            Console.WriteLine($"[TEST 3] Rule 1 check: IsFailure={unsubBookResult.IsFailure}, Error='{unsubBookResult.Error}'");
            if (unsubBookResult.IsSuccess) throw new Exception("Rule 1 violation: Member without active subscription was allowed to book!");

            // Test 4: Book 2 active members (fill to capacity)
            var activeMember1 = store.Members.First(m => memberService.GetMemberStatus(m.Id) == MembershipStatus.Active);
            var activeMember2 = store.Members.Where(m => memberService.GetMemberStatus(m.Id) == MembershipStatus.Active && m.Id != activeMember1.Id).First();

            var book1 = classService.BookMember(miniClass.Id, activeMember1.Id);
            var book2 = classService.BookMember(miniClass.Id, activeMember2.Id);
            if (book1.IsFailure || book2.IsFailure) throw new Exception($"Booking active members failed: {book1.Error} / {book2.Error}");
            int activeCount = classService.GetActiveBookingCount(miniClass.Id);
            int availableSpots = classService.GetAvailableSpots(miniClass.Id);
            Console.WriteLine($"[TEST 4] Booked 2 members. Active bookings={activeCount}, Available spots={availableSpots}.");
            if (activeCount != 2 || availableSpots != 0) throw new Exception("Class capacity counter error.");

            // Test 5: Rule 3 - Class is full
            var activeMember3 = store.Members.Where(m => memberService.GetMemberStatus(m.Id) == MembershipStatus.Active && m.Id != activeMember1.Id && m.Id != activeMember2.Id).First();
            var fullBookResult = classService.BookMember(miniClass.Id, activeMember3.Id);
            Console.WriteLine($"[TEST 5] Rule 3 check (Class is full): IsFailure={fullBookResult.IsFailure}, Error='{fullBookResult.Error}'");
            if (fullBookResult.IsSuccess) throw new Exception("Rule 3 violation: Allowed booking into full class!");

            // Test 6: Rule 4 - Duplicate booking prevention
            var dupBookResult = classService.BookMember(miniClass.Id, activeMember1.Id);
            Console.WriteLine($"[TEST 6] Rule 4 check (Duplicate): IsFailure={dupBookResult.IsFailure}, Error='{dupBookResult.Error}'");
            if (dupBookResult.IsSuccess) throw new Exception("Rule 4 violation: Allowed member to book same class twice!");

            // Test 7: Rule 5 - Cancel booking frees spot
            var cancelResult = classService.CancelBooking(miniClass.Id, activeMember1.Id);
            if (cancelResult.IsFailure) throw new Exception($"CancelBooking failed: {cancelResult.Error}");
            int afterCancelBookings = classService.GetActiveBookingCount(miniClass.Id);
            int afterCancelSpots = classService.GetAvailableSpots(miniClass.Id);
            Console.WriteLine($"[TEST 7] Rule 5 check: Cancelled booking. Active bookings={afterCancelBookings}, Available spots={afterCancelSpots}.");
            if (afterCancelBookings != 1 || afterCancelSpots != 1) throw new Exception("Rule 5 violation: Spot was not freed upon cancellation!");

            // Test 8: Rule 6 - Capacity cannot be reduced below active bookings
            var reduceFail = classService.UpdateClass(miniClass.Id, miniClass.Name, miniClass.TrainerId, miniClass.DayOfWeek, miniClass.StartTime, miniClass.DurationMinutes, 0, true);
            Console.WriteLine($"[TEST 8] Rule 6 check (Reduce capacity below active bookings): IsFailure={reduceFail.IsFailure}, Error='{reduceFail.Error}'");
            if (reduceFail.IsSuccess) throw new Exception("Rule 6 violation: Capacity was reduced below active bookings count!");

            // Test 9: Valid capacity update
            var updateSuccess = classService.UpdateClass(miniClass.Id, miniClass.Name, miniClass.TrainerId, miniClass.DayOfWeek, miniClass.StartTime, miniClass.DurationMinutes, 5, true);
            if (updateSuccess.IsFailure) throw new Exception($"Valid capacity update failed: {updateSuccess.Error}");
            Console.WriteLine($"[TEST 9] Capacity successfully updated to 5. New available spots={classService.GetAvailableSpots(miniClass.Id)}.");

            Console.WriteLine("==================================================");
            Console.WriteLine("ALL COMPONENT 08 BUSINESS RULES PASSED PERFECTLY!");
            Console.WriteLine("==================================================");
        }
    }
}