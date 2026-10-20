using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// Represents a scheduled group fitness class.
    /// </summary>
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int TrainerId { get; set; }
        public DayOfWeek DayOfWeek { get; set; } = DayOfWeek.Monday;
        public TimeSpan StartTime { get; set; } = new TimeSpan(9, 0, 0);
        public int DurationMinutes { get; set; } = 60;
        public int Capacity { get; set; } = 20;
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Calculated end time of the class.
        /// </summary>
        public TimeSpan EndTime => StartTime.Add(TimeSpan.FromMinutes(DurationMinutes));

        public override string ToString()
        {
            var formattedTime = DateTime.Today.Add(StartTime).ToString("hh:mm tt");
            return $"{Name} ({DayOfWeek} at {formattedTime}, Cap: {Capacity})";
        }
    }
}
