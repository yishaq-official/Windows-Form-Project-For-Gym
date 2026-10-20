using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a member's subscription to a membership plan.
    /// </summary>
    public class Subscription
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime ExpiryDate { get; set; }
        public int? TrainerId { get; set; }
        public MembershipStatus Status { get; set; } = MembershipStatus.Active;

        /// <summary>
        /// True if status is Active and ExpiryDate is on or after today.
        /// </summary>
        public bool IsCurrentlyActive => Status == MembershipStatus.Active && ExpiryDate.Date >= DateTime.Today;

        public override string ToString()
        {
            return $"Subscription #{Id} (Member #{MemberId}, Plan #{PlanId}, Expires: {ExpiryDate:yyyy-MM-dd})";
        }
    }
}
