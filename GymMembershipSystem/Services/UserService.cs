using System;
using System.Collections.Generic;
using System.Linq;
using GymMembershipSystem.Common;
using GymMembershipSystem.Data;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Services
{
    /// <summary>
    /// Thread-safe in-memory user account and credential management service.
    /// Enforces:
    /// - Username uniqueness (case-insensitive).
    /// - Minimum password length of 6 characters.
    /// - Self-deactivation and self-demotion protection for currently authenticated administrators.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly InMemoryDataStore _dataStore;

        public UserService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public IReadOnlyList<User> GetUsers(string? searchQuery = null, UserRole? roleFilter = null)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Users.AsEnumerable();

                if (roleFilter.HasValue)
                {
                    query = query.Where(u => u.Role == roleFilter.Value);
                }

                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var trimmed = searchQuery.Trim();
                    query = query.Where(u =>
                        u.Username.Contains(trimmed, StringComparison.OrdinalIgnoreCase) ||
                        u.FullName.Contains(trimmed, StringComparison.OrdinalIgnoreCase) ||
                        u.Id.ToString() == trimmed);
                }

                return query.OrderBy(u => u.Id).ToList();
            }
        }

        public User? GetUserById(int userId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Users.FirstOrDefault(u => u.Id == userId);
            }
        }

        public Result<User> CreateUser(string username, string password, string fullName, UserRole role)
        {
            if (string.IsNullOrWhiteSpace(username))
                return Result<User>.Fail("Username is required.");

            username = username.Trim();
            if (username.Length < 3)
                return Result<User>.Fail("Username must be at least 3 characters long.");

            if (string.IsNullOrWhiteSpace(fullName))
                return Result<User>.Fail("Full name is required.");

            fullName = fullName.Trim();

            if (string.IsNullOrWhiteSpace(password))
                return Result<User>.Fail("Password is required.");

            if (password.Length < 6)
                return Result<User>.Fail("Password must be at least 6 characters long.");

            lock (_dataStore.SyncRoot)
            {
                // Enforce username uniqueness
                bool exists = _dataStore.Users.Any(u =>
                    string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));

                if (exists)
                {
                    return Result<User>.Fail($"Username '{username}' is already in use by another account.");
                }

                var user = new User
                {
                    Id = _dataStore.NextUserId(),
                    Username = username,
                    PasswordHash = PasswordHasher.HashPassword(password),
                    FullName = fullName,
                    Role = role,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow
                };

                _dataStore.Users.Add(user);
                AppEvents.PublishUserChanged(user, ChangeType.Created);

                return Result<User>.Ok(user);
            }
        }

        public Result UpdateUser(int userId, string fullName, UserRole role, bool isActive)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return Result.Fail("Full name is required.");

            fullName = fullName.Trim();

            lock (_dataStore.SyncRoot)
            {
                var user = _dataStore.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                    return Result.Fail($"User #{userId} was not found.");

                // Self-deactivation protection
                if (UserSession.CurrentUser?.Id == userId && !isActive)
                {
                    return Result.Fail("You cannot deactivate your own active session account.");
                }

                // Self-demotion protection
                if (UserSession.CurrentUser?.Id == userId && role != UserRole.Administrator)
                {
                    return Result.Fail("You cannot remove administrator privileges from your own active account.");
                }

                user.FullName = fullName;
                user.Role = role;
                user.IsActive = isActive;

                AppEvents.PublishUserChanged(user, ChangeType.Updated);

                return Result.Ok();
            }
        }

        public Result ResetPassword(int userId, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                return Result.Fail("New password is required.");

            if (newPassword.Length < 6)
                return Result.Fail("Password must be at least 6 characters long.");

            lock (_dataStore.SyncRoot)
            {
                var user = _dataStore.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                    return Result.Fail($"User #{userId} was not found.");

                user.PasswordHash = PasswordHasher.HashPassword(newPassword.Trim());
                AppEvents.PublishUserChanged(user, ChangeType.Updated);

                return Result.Ok();
            }
        }

        public Result<bool> ToggleUserActiveState(int userId)
        {
            lock (_dataStore.SyncRoot)
            {
                var user = _dataStore.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                    return Result<bool>.Fail($"User #{userId} was not found.");

                // Self-deactivation protection
                if (UserSession.CurrentUser?.Id == userId && user.IsActive)
                {
                    return Result<bool>.Fail("You cannot deactivate your own active session account.");
                }

                user.IsActive = !user.IsActive;
                AppEvents.PublishUserChanged(user, ChangeType.Updated);

                return Result<bool>.Ok(user.IsActive);
            }
        }
    }
}
