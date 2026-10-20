namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a gym personal trainer or fitness instructor.
    /// </summary>
    public class Trainer
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return $"{FullName} ({Specialty})";
        }
    }
}
