using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for authenticating system users and managing user sessions.
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Authenticates administrator credentials against the data store.
        /// </summary>
        Result<User> Authenticate(string username, string password);

        /// <summary>
        /// Logs out the currently active user session.
        /// </summary>
        void Logout();

        /// <summary>
        /// Retrieves the currently authenticated user, if any.
        /// </summary>
        User? GetCurrentUser();
    }
}
