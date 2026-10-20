using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a member's enrollment/booking into a gym class.
    /// </summary>
    public class Booking
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int MemberId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Today;
        public bool IsCancelled { get; set; } = false;

        public override string ToString()
        {
            return $"Booking #{Id} (Class #{ClassId}, Member #{MemberId}, Date: {BookingDate:yyyy-MM-dd}, Cancelled: {IsCancelled})";
        }
    }
}
