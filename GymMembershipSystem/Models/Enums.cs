namespace GymMembershipSystem.Models
{
    /// <summary>
    /// User roles within the Gym Management System.
    /// </summary>
    public enum UserRole
    {
        Administrator,
        Trainer,
        Member
    }

    /// <summary>
    /// Membership subscription statuses.
    /// </summary>
    public enum MembershipStatus
    {
        Active,
        Expired,
        Inactive
    }

    /// <summary>
    /// Gender options for members.
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    /// <summary>
    /// Accepted payment methods for transactions.
    /// </summary>
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        MobileMoney
    }

    /// <summary>
    /// Change types for domain events in the event-driven architecture.
    /// </summary>
    public enum ChangeType
    {
        Created,
        Updated,
        Deleted
    }
}
