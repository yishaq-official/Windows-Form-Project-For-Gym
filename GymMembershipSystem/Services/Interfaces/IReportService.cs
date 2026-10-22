using System.Collections.Generic;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for aggregating gym operational metrics, member statistics,
    /// class fill rates, and financial summaries.
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Retrieves high-level operational KPIs for executive dashboard ribbons.
        /// </summary>
        DashboardMetrics GetDashboardMetrics();

        /// <summary>
        /// Computes class enrollment capacity and fill rate percentages.
        /// </summary>
        IReadOnlyList<ClassFillRateItem> GetClassFillRates();

        /// <summary>
        /// Computes monthly revenue aggregations and transaction volume grouped by calendar month.
        /// </summary>
        IReadOnlyList<MonthlyIncomeItem> GetMonthlyIncomeSummary();

        /// <summary>
        /// Retrieves a comprehensive member list with current subscription status, plan name, and outstanding balance.
        /// </summary>
        /// <param name="statusFilter">Optional filter: "All", "Active", "Expired", or "Overdue".</param>
        IReadOnlyList<MemberStatusReportItem> GetMemberStatusReport(string? statusFilter = null);
    }
}
