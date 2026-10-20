using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a financial payment transaction for membership or services.
    /// </summary>
    public class Payment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;
        public string Notes { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Payment #{Id} (Member #{MemberId}, ${Amount:F2} via {PaymentMethod} on {PaymentDate:yyyy-MM-dd})";
        }
    }
}
