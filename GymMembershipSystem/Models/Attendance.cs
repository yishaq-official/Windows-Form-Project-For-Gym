using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a member's check-in / check-out log entry.
    /// </summary>
    public class Attendance
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime CheckInTime { get; set; } = DateTime.Now;
        public DateTime? CheckOutTime { get; set; }

        /// <summary>
        /// True if the member is currently checked in and has not yet checked out.
        /// </summary>
        public bool IsCurrentlyInside => !CheckOutTime.HasValue;

        public override string ToString()
        {
            var outText = CheckOutTime.HasValue ? CheckOutTime.Value.ToString("t") : "Currently Inside";
            return $"Attendance #{Id} (Member #{MemberId}, In: {CheckInTime:t}, Out: {outText})";
        }
    }
}
