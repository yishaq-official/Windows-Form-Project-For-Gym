using System;

namespace GymMembershipSystem.Models
{
    /// <summary>
    /// High-level operational and financial KPIs displayed on executive dashboards.
    /// </summary>
    public class DashboardMetrics
    {
        public int TotalMembers { get; set; }
        public int ActiveMembers { get; set; }
        public int ExpiredMembers { get; set; }
        public int TodayAttendanceCount { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public decimal TotalOutstandingBalance { get; set; }
    }

    /// <summary>
    /// Analytics row item showing class capacity utilization and booking counts.
    /// </summary>
    public class ClassFillRateItem
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string TrainerName { get; set; } = string.Empty;
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public int Capacity { get; set; }
        public int BookedCount { get; set; }
        public int AvailableSpots { get; set; }
        public double FillRatePercentage { get; set; }

        public string ScheduleDisplay => $"{DayOfWeek} at {DateTime.Today.Add(StartTime):hh:mm tt}";
        public string FillRateDisplay => $"{FillRatePercentage:F1}%";
    }

    /// <summary>
    /// Monthly aggregated revenue and transaction volume.
    /// </summary>
    public class MonthlyIncomeItem
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; } = string.Empty;
        public decimal TotalIncome { get; set; }
        public int TransactionCount { get; set; }

        public string TotalIncomeDisplay => TotalIncome.ToString("C2");
    }

    /// <summary>
    /// Daily check-in footfall analysis.
    /// </summary>
    public class DailyAttendanceItem
    {
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; } = string.Empty;
        public int TotalVisits { get; set; }
        public int UniqueMembersCount { get; set; }

        public string DateDisplay => Date.ToString("yyyy-MM-dd");
    }

    /// <summary>
    /// Member directory status report row including current plan and receivables.
    /// </summary>
    public class MemberStatusReportItem
    {
        public int MemberId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string PlanName { get; set; } = string.Empty;
        public DateTime? ExpiryDate { get; set; }
        public decimal Balance { get; set; }

        public string ExpiryDateDisplay => ExpiryDate.HasValue ? ExpiryDate.Value.ToString("yyyy-MM-dd") : "N/A";
        public string BalanceDisplay => Balance.ToString("C2");
    }
}
