using System;
using System.Security.Cryptography;
using System.Text;

namespace GymMembershipSystem.Common
{
    /// <summary>
    /// Utility for hashing and verifying user passwords using SHA-256.
    /// </summary>
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToHexString(hash);
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(storedHash))
                return false;

            var computed = HashPassword(password);
            return string.Equals(computed, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
