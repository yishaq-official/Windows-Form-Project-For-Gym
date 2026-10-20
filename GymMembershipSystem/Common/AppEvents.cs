using System;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Common
{
    /// <summary>
    /// Centralized event bus / aggregator enabling decoupled event-driven architecture
    /// across domain services, data stores, and UI forms.
    /// </summary>
    public static class AppEvents
    {
        // Domain change events
        public static event Action<Member, ChangeType>? MemberChanged;
        public static event Action<Plan, ChangeType>? PlanChanged;
        public static event Action<Trainer, ChangeType>? TrainerChanged;
        public static event Action<Subscription, ChangeType>? SubscriptionChanged;
        public static event Action<GymClass, ChangeType>? GymClassChanged;
        public static event Action<Booking, ChangeType>? BookingChanged;
        public static event Action<Attendance>? AttendanceRecorded;
        public static event Action<Payment>? PaymentReceived;
        public static event Action<User, ChangeType>? UserChanged;
        public static event Action? DataReset;

        #region Publishing Methods

        /// <summary>
        /// Publishes a member change event (Created, Updated, Deleted).
        /// </summary>
        public static void PublishMemberChanged(Member member, ChangeType changeType)
        {
            SafeInvoke(MemberChanged, member, changeType);
        }

        /// <summary>
        /// Publishes a membership plan change event.
        /// </summary>
        public static void PublishPlanChanged(Plan plan, ChangeType changeType)
        {
            SafeInvoke(PlanChanged, plan, changeType);
        }

        /// <summary>
        /// Publishes a trainer change event.
        /// </summary>
        public static void PublishTrainerChanged(Trainer trainer, ChangeType changeType)
        {
            SafeInvoke(TrainerChanged, trainer, changeType);
        }

        /// <summary>
        /// Publishes a subscription assignment or update event.
        /// </summary>
        public static void PublishSubscriptionChanged(Subscription subscription, ChangeType changeType)
        {
            SafeInvoke(SubscriptionChanged, subscription, changeType);
        }

        /// <summary>
        /// Publishes a gym class definition change event.
        /// </summary>
        public static void PublishGymClassChanged(GymClass gymClass, ChangeType changeType)
        {
            SafeInvoke(GymClassChanged, gymClass, changeType);
        }

        /// <summary>
        /// Publishes a class booking change event.
        /// </summary>
        public static void PublishBookingChanged(Booking booking, ChangeType changeType)
        {
            SafeInvoke(BookingChanged, booking, changeType);
        }

        /// <summary>
        /// Publishes an attendance check-in or check-out event.
        /// </summary>
        public static void PublishAttendanceRecorded(Attendance attendance)
        {
            SafeInvoke(AttendanceRecorded, attendance);
        }

        /// <summary>
        /// Publishes a payment recorded event.
        /// </summary>
        public static void PublishPaymentReceived(Payment payment)
        {
            SafeInvoke(PaymentReceived, payment);
        }

        /// <summary>
        /// Publishes a system user change event.
        /// </summary>
        public static void PublishUserChanged(User user, ChangeType changeType)
        {
            SafeInvoke(UserChanged, user, changeType);
        }

        /// <summary>
        /// Publishes a global data store reset / reseed event.
        /// </summary>
        public static void PublishDataReset()
        {
            SafeInvoke(DataReset);
        }

        #endregion

        #region Safe Invocation Helpers

        private static void SafeInvoke<T1, T2>(Action<T1, T2>? handler, T1 arg1, T2 arg2)
        {
            if (handler == null) return;
            foreach (var invocation in handler.GetInvocationList())
            {
                try
                {
                    ((Action<T1, T2>)invocation)(arg1, arg2);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[AppEvents] Error invoking handler for {typeof(T1).Name}, {typeof(T2).Name}: {ex.Message}");
                }
            }
        }

        private static void SafeInvoke<T>(Action<T>? handler, T arg)
        {
            if (handler == null) return;
            foreach (var invocation in handler.GetInvocationList())
            {
                try
                {
                    ((Action<T>)invocation)(arg);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[AppEvents] Error invoking handler for {typeof(T).Name}: {ex.Message}");
                }
            }
        }

        private static void SafeInvoke(Action? handler)
        {
            if (handler == null) return;
            foreach (var invocation in handler.GetInvocationList())
            {
                try
                {
                    ((Action)invocation)();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[AppEvents] Error invoking parameterless handler: {ex.Message}");
                }
            }
        }

        #endregion
    }
}
