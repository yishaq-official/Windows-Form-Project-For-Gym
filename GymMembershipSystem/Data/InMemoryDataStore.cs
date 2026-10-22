using System;
using System.Collections.Generic;
using System.Linq;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Data
{
    /// <summary>
    /// Thread-safe in-memory data store acting as the central repository in Phase 1.
    /// Exposes strongly typed collections, atomic ID generators, and domain query helpers.
    /// </summary>
    public class InMemoryDataStore
    {
        private static readonly Lazy<InMemoryDataStore> _instance =
            new Lazy<InMemoryDataStore>(() => new InMemoryDataStore());

        public static InMemoryDataStore Instance => _instance.Value;

        private readonly object _lock = new object();

        // Collections
        public List<User> Users { get; } = new List<User>();
        public List<Member> Members { get; } = new List<Member>();
        public List<Plan> Plans { get; } = new List<Plan>();
        public List<Subscription> Subscriptions { get; } = new List<Subscription>();
        public List<Trainer> Trainers { get; } = new List<Trainer>();
        public List<GymClass> Classes { get; } = new List<GymClass>();
        public List<Booking> Bookings { get; } = new List<Booking>();
        public List<Payment> Payments { get; } = new List<Payment>();

        // Auto-increment ID counters
        private int _lastUserId;
        private int _lastMemberId;
        private int _lastPlanId;
        private int _lastSubscriptionId;
        private int _lastTrainerId;
        private int _lastClassId;
        private int _lastBookingId;
        private int _lastPaymentId;

        public InMemoryDataStore()
        {
        }

        #region ID Generation

        public int NextUserId() => System.Threading.Interlocked.Increment(ref _lastUserId);
        public int NextMemberId() => System.Threading.Interlocked.Increment(ref _lastMemberId);
        public int NextPlanId() => System.Threading.Interlocked.Increment(ref _lastPlanId);
        public int NextSubscriptionId() => System.Threading.Interlocked.Increment(ref _lastSubscriptionId);
        public int NextTrainerId() => System.Threading.Interlocked.Increment(ref _lastTrainerId);
        public int NextClassId() => System.Threading.Interlocked.Increment(ref _lastClassId);
        public int NextBookingId() => System.Threading.Interlocked.Increment(ref _lastBookingId);
        public int NextPaymentId() => System.Threading.Interlocked.Increment(ref _lastPaymentId);

        public void ResetIdCounters(
            int userId = 0,
            int memberId = 0,
            int planId = 0,
            int subscriptionId = 0,
            int trainerId = 0,
            int classId = 0,
            int bookingId = 0,
            int paymentId = 0)
        {
            lock (_lock)
            {
                _lastUserId = userId;
                _lastMemberId = memberId;
                _lastPlanId = planId;
                _lastSubscriptionId = subscriptionId;
                _lastTrainerId = trainerId;
                _lastClassId = classId;
                _lastBookingId = bookingId;
                _lastPaymentId = paymentId;
            }
        }

        #endregion

        #region Data Retrieval & Query Helpers

        public object SyncRoot => _lock;

        /// <summary>
        /// Retrieves a thread-safe snapshot list of all members.
        /// </summary>
        public List<Member> GetMembersSnapshot()
        {
            lock (_lock)
            {
                return Members.ToList();
            }
        }

        /// <summary>
        /// Retrieves a thread-safe snapshot of all membership plans.
        /// </summary>
        public List<Plan> GetPlansSnapshot()
        {
            lock (_lock)
            {
                return Plans.ToList();
            }
        }

        /// <summary>
        /// Retrieves a thread-safe snapshot of all trainers.
        /// </summary>
        public List<Trainer> GetTrainersSnapshot()
        {
            lock (_lock)
            {
                return Trainers.ToList();
            }
        }

        /// <summary>
        /// Retrieves a thread-safe snapshot of all gym classes.
        /// </summary>
        public List<GymClass> GetClassesSnapshot()
        {
            lock (_lock)
            {
                return Classes.ToList();
            }
        }

        /// <summary>
        /// Finds a member by ID.
        /// </summary>
        public Member? FindMember(int memberId)
        {
            lock (_lock)
            {
                return Members.FirstOrDefault(m => m.Id == memberId);
            }
        }

        /// <summary>
        /// Finds a plan by ID.
        /// </summary>
        public Plan? FindPlan(int planId)
        {
            lock (_lock)
            {
                return Plans.FirstOrDefault(p => p.Id == planId);
            }
        }

        /// <summary>
        /// Finds a trainer by ID.
        /// </summary>
        public Trainer? FindTrainer(int trainerId)
        {
            lock (_lock)
            {
                return Trainers.FirstOrDefault(t => t.Id == trainerId);
            }
        }

        /// <summary>
        /// Finds a gym class by ID.
        /// </summary>
        public GymClass? FindClass(int classId)
        {
            lock (_lock)
            {
                return Classes.FirstOrDefault(c => c.Id == classId);
            }
        }

        /// <summary>
        /// Gets the current active subscription for a member (where Status is Active and ExpiryDate >= Today).
        /// </summary>
        public Subscription? GetMemberActiveSubscription(int memberId)
        {
            lock (_lock)
            {
                var today = DateTime.Today;
                return Subscriptions
                    .Where(s => s.MemberId == memberId && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today)
                    .OrderByDescending(s => s.ExpiryDate)
                    .FirstOrDefault();
            }
        }

        /// <summary>
        /// Gets the latest subscription record for a member, regardless of active or expired status.
        /// </summary>
        public Subscription? GetMemberLatestSubscription(int memberId)
        {
            lock (_lock)
            {
                return Subscriptions
                    .Where(s => s.MemberId == memberId)
                    .OrderByDescending(s => s.ExpiryDate)
                    .FirstOrDefault();
            }
        }

        /// <summary>
        /// Gets the count of non-cancelled bookings for a specific class (Rule 3 enforcement).
        /// </summary>
        public int GetActiveBookingCount(int classId)
        {
            lock (_lock)
            {
                return Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
            }
        }

        /// <summary>
        /// Gets remaining available spots for a class.
        /// </summary>
        public int GetAvailableSpots(int classId)
        {
            lock (_lock)
            {
                var gymClass = Classes.FirstOrDefault(c => c.Id == classId);
                if (gymClass == null) return 0;
                var booked = Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
                return Math.Max(0, gymClass.Capacity - booked);
            }
        }


        /// <summary>
        /// Computes the total charges for a member across all subscriptions.
        /// </summary>
        public decimal GetMemberTotalCost(int memberId)
        {
            lock (_lock)
            {
                var memberSubs = Subscriptions.Where(s => s.MemberId == memberId).ToList();
                decimal totalCost = 0;
                foreach (var sub in memberSubs)
                {
                    var plan = Plans.FirstOrDefault(p => p.Id == sub.PlanId);
                    if (plan != null)
                    {
                        totalCost += plan.Price;
                    }
                }
                return totalCost;
            }
        }

        /// <summary>
        /// Computes the total payments recorded for a member.
        /// </summary>
        public decimal GetMemberTotalPaid(int memberId)
        {
            lock (_lock)
            {
                return Payments.Where(p => p.MemberId == memberId).Sum(p => p.Amount);
            }
        }

        /// <summary>
        /// Computes outstanding balance for a member: Total Cost - Total Paid.
        /// </summary>
        public decimal GetMemberBalance(int memberId)
        {
            lock (_lock)
            {
                return GetMemberTotalCost(memberId) - GetMemberTotalPaid(memberId);
            }
        }

        #endregion

        #region Reset / Clear

        /// <summary>
        /// Clears all collections and resets ID counters.
        /// Broadcasts AppEvents.DataReset.
        /// </summary>
        public void Clear()
        {
            lock (_lock)
            {
                Users.Clear();
                Members.Clear();
                Plans.Clear();
                Subscriptions.Clear();
                Trainers.Clear();
                Classes.Clear();
                Bookings.Clear();
                Payments.Clear();
                ResetIdCounters();
            }

            AppEvents.PublishDataReset();
        }

        #endregion
    }
}
