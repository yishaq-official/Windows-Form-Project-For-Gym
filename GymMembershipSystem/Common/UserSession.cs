using System;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Common
{
    /// <summary>
    /// Thread-safe ambient session context holding the currently authenticated user.
    /// </summary>
    public static class UserSession
    {
        private static readonly object _lock = new object();

        public static User? CurrentUser { get; private set; }
        public static DateTime? LoginTime { get; private set; }
        public static bool IsAuthenticated => CurrentUser != null;

        /// <summary>
        /// True if the current authenticated user has the Administrator role.
        /// </summary>
        public static bool IsAdministrator => CurrentUser?.Role == UserRole.Administrator;

        /// <summary>
        /// Sets the active user session and publishes the UserLoggedIn event.
        /// </summary>
        public static void SignIn(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            lock (_lock)
            {
                CurrentUser = user;
                LoginTime = DateTime.UtcNow;
            }

            AppEvents.PublishUserLoggedIn(user);
        }

        /// <summary>
        /// Clears the active user session and publishes the UserLoggedOut event.
        /// </summary>
        public static void SignOut()
        {
            User? previousUser;
            lock (_lock)
            {
                previousUser = CurrentUser;
                CurrentUser = null;
                LoginTime = null;
            }

            AppEvents.PublishUserLoggedOut(previousUser);
        }
    }
}
