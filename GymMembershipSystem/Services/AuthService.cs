using System;
using System.Linq;
using GymMembershipSystem.Common;
using GymMembershipSystem.Data;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Services
{
    /// <summary>
    /// In-memory authentication service implementing admin login validation and session initiation.
    /// </summary>
    public class AuthService : IAuthService
    {
        private readonly InMemoryDataStore _dataStore;

        public AuthService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public Result<User> Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return Result<User>.Fail("Username is required.");

            if (string.IsNullOrWhiteSpace(password))
                return Result<User>.Fail("Password is required.");

            username = username.Trim();

            User? user;
            lock (_dataStore.SyncRoot)
            {
                user = _dataStore.Users.FirstOrDefault(u =>
                    string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
            }

            if (user == null)
            {
                return Result<User>.Fail("Invalid username or password.");
            }

            // Verify password using SHA-256 or direct string fallback
            bool passwordValid = PasswordHasher.VerifyPassword(password, user.PasswordHash) ||
                                 string.Equals(user.PasswordHash, password, StringComparison.Ordinal);

            if (!passwordValid)
            {
                return Result<User>.Fail("Invalid username or password.");
            }

            // Verify active status
            if (!user.IsActive)
            {
                return Result<User>.Fail("Account is deactivated. Please contact an administrator.");
            }

            // Verify Administrator role (WinForms desktop app requirement)
            if (user.Role != UserRole.Administrator)
            {
                return Result<User>.Fail("Access denied: only administrators can log into the desktop management portal.");
            }

            // Establish session
            UserSession.SignIn(user);

            return Result<User>.Ok(user);
        }

        public void Logout()
        {
            UserSession.SignOut();
        }

        public User? GetCurrentUser()
        {
            return UserSession.CurrentUser;
        }
    }
}
