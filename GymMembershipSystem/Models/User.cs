using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents an authenticated system user account.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Member;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public override string ToString()
        {
            return $"{FullName} ({Username}) - {Role}";
        }
    }
}
