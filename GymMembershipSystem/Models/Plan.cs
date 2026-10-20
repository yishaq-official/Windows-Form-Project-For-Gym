namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a membership plan catalog item.
    /// </summary>
    public class Plan
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DurationInDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return $"{Name} ({DurationInDays} Days - ${Price:F2})";
        }
    }
}
