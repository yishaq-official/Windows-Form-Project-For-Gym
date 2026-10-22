using System;
using System.Collections.Generic;
using System.Linq;
using GymMembershipSystem.Data;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Services
{
    /// <summary>
    /// Thread-safe in-memory reporting and analytics engine.
    /// Aggregates membership metrics, class fill rates, financial summaries, and footfall volume.
    /// </summary>
    public class ReportService : IReportService
    {
        private readonly InMemoryDataStore _dataStore;

        public ReportService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public DashboardMetrics GetDashboardMetrics()
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;

                int totalMembers = _dataStore.Members.Count;
                int activeMembers = _dataStore.Members.Count(m =>
                    m.IsActive && _dataStore.GetMemberActiveSubscription(m.Id) != null);

                int expiredMembers = _dataStore.Members.Count(m =>
                    m.IsActive &&
                    _dataStore.GetMemberActiveSubscription(m.Id) == null &&
                    _dataStore.GetMemberLatestSubscription(m.Id) != null);

                int totalClasses = _dataStore.Classes.Count(c => c.IsActive);

                decimal monthlyRevenue = _dataStore.Payments
                    .Where(p => p.PaymentDate.Year == today.Year && p.PaymentDate.Month == today.Month)
                    .Sum(p => p.Amount);

                decimal totalOutstanding = _dataStore.Members
                    .Where(m => m.IsActive)
                    .Sum(m => Math.Max(0, _dataStore.GetMemberBalance(m.Id)));

                return new DashboardMetrics
                {
                    TotalMembers = totalMembers,
                    ActiveMembers = activeMembers,
                    ExpiredMembers = expiredMembers,
                    TotalClassesCount = totalClasses,
                    MonthlyRevenue = monthlyRevenue,
                    TotalOutstandingBalance = totalOutstanding
                };
            }
        }

        public IReadOnlyList<ClassFillRateItem> GetClassFillRates()
        {
            lock (_dataStore.SyncRoot)
            {
                var list = new List<ClassFillRateItem>();

                foreach (var gymClass in _dataStore.Classes.Where(c => c.IsActive))
                {
                    int booked = _dataStore.GetActiveBookingCount(gymClass.Id);
                    var trainer = _dataStore.FindTrainer(gymClass.TrainerId);
                    double fillRate = gymClass.Capacity > 0
                        ? Math.Round(((double)booked / gymClass.Capacity) * 100.0, 1)
                        : 0.0;

                    list.Add(new ClassFillRateItem
                    {
                        ClassId = gymClass.Id,
                        ClassName = gymClass.Name,
                        TrainerName = trainer != null ? trainer.FullName : "Unassigned",
                        DayOfWeek = gymClass.DayOfWeek,
                        StartTime = gymClass.StartTime,
                        Capacity = gymClass.Capacity,
                        BookedCount = booked,
                        AvailableSpots = Math.Max(0, gymClass.Capacity - booked),
                        FillRatePercentage = fillRate
                    });
                }

                return list
                    .OrderBy(c => c.DayOfWeek)
                    .ThenBy(c => c.StartTime)
                    .ThenBy(c => c.ClassName)
                    .ToList();
            }
        }

        public IReadOnlyList<MonthlyIncomeItem> GetMonthlyIncomeSummary()
        {
            lock (_dataStore.SyncRoot)
            {
                var groups = _dataStore.Payments
                    .GroupBy(p => new { p.PaymentDate.Year, p.PaymentDate.Month })
                    .OrderByDescending(g => g.Key.Year)
                    .ThenByDescending(g => g.Key.Month)
                    .Select(g => new MonthlyIncomeItem
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        MonthName = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MMMM yyyy"),
                        TotalIncome = g.Sum(p => p.Amount),
                        TransactionCount = g.Count()
                    })
                    .ToList();

                // If no payments recorded yet, present current month as zero baseline
                if (groups.Count == 0)
                {
                    var today = DateTime.Today;
                    groups.Add(new MonthlyIncomeItem
                    {
                        Year = today.Year,
                        Month = today.Month,
                        MonthName = today.ToString("MMMM yyyy"),
                        TotalIncome = 0m,
                        TransactionCount = 0
                    });
                }

                return groups;
            }
        }


        public IReadOnlyList<MemberStatusReportItem> GetMemberStatusReport(string? statusFilter = null)
        {
            lock (_dataStore.SyncRoot)
            {
                var list = new List<MemberStatusReportItem>();

                foreach (var member in _dataStore.Members)
                {
                    var activeSub = _dataStore.GetMemberActiveSubscription(member.Id);
                    var latestSub = _dataStore.GetMemberLatestSubscription(member.Id);
                    decimal balance = _dataStore.GetMemberBalance(member.Id);

                    string status;
                    if (!member.IsActive)
                    {
                        status = "Deactivated";
                    }
                    else if (activeSub != null)
                    {
                        status = "Active";
                    }
                    else if (latestSub != null)
                    {
                        status = "Expired";
                    }
                    else
                    {
                        status = "No Subscription";
                    }

                    string planName = "None";
                    DateTime? expiryDate = null;

                    if (activeSub != null)
                    {
                        var plan = _dataStore.FindPlan(activeSub.PlanId);
                        planName = plan != null ? plan.Name : "Custom Plan";
                        expiryDate = activeSub.ExpiryDate;
                    }
                    else if (latestSub != null)
                    {
                        var plan = _dataStore.FindPlan(latestSub.PlanId);
                        planName = plan != null ? plan.Name : "Past Plan";
                        expiryDate = latestSub.ExpiryDate;
                    }

                    // Apply filter if specified
                    if (!string.IsNullOrWhiteSpace(statusFilter) && !statusFilter.Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        if (statusFilter.Equals("Active", StringComparison.OrdinalIgnoreCase) && status != "Active")
                            continue;
                        if (statusFilter.Equals("Expired", StringComparison.OrdinalIgnoreCase) && status != "Expired")
                            continue;
                        if (statusFilter.Equals("Overdue", StringComparison.OrdinalIgnoreCase) && balance <= 0)
                            continue;
                    }

                    list.Add(new MemberStatusReportItem
                    {
                        MemberId = member.Id,
                        FullName = member.FullName,
                        Phone = member.Phone,
                        Email = member.Email,
                        Status = status,
                        PlanName = planName,
                        ExpiryDate = expiryDate,
                        Balance = balance
                    });
                }

                return list.OrderBy(m => m.MemberId).ToList();
            }
        }
    }
}
