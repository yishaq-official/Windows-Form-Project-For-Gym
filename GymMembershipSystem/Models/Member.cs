using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a gym member profile.
    /// </summary>
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public Gender Gender { get; set; } = Gender.Male;
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; } = DateTime.Today;
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Member's calculated age based on current date and DateOfBirth.
        /// </summary>
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }
                return Math.Max(0, age);
            }
        }

        public override string ToString()
        {
            return $"#{Id:D4} - {FullName} ({Phone})";
        }
    }
}
