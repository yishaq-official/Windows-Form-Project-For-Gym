using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for managing application user accounts, credentials, and access roles.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieves users matching search terms and optional role filter.
        /// </summary>
        IReadOnlyList<User> GetUsers(string? searchQuery = null, UserRole? roleFilter = null);

        /// <summary>
        /// Retrieves a user by primary key ID.
        /// </summary>
        User? GetUserById(int userId);

        /// <summary>
        /// Creates a new user account with validated credentials and assigned role.
        /// </summary>
        Result<User> CreateUser(string username, string password, string fullName, UserRole role);

        /// <summary>
        /// Updates profile information, role assignment, and active status for an existing user.
        /// Prevents deactivation of the currently logged-in administrator.
        /// </summary>
        Result UpdateUser(int userId, string fullName, UserRole role, bool isActive);

        /// <summary>
        /// Resets credentials for an existing user with password length validation.
        /// </summary>
        Result ResetPassword(int userId, string newPassword);

        /// <summary>
        /// Toggles the active status of a user (deactivates or reactivates).
        /// Prevents self-deactivation of the currently logged-in account.
        /// </summary>
        Result<bool> ToggleUserActiveState(int userId);
    }
}
