using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for membership plan catalog operations and constraints.
    /// </summary>
    public interface IPlanService
    {
        IReadOnlyList<Plan> GetAllPlans(bool includeInactive = false);
        Plan? GetPlanById(int planId);
        Result<Plan> CreatePlan(string name, int durationDays, decimal price);
        Result UpdatePlan(int planId, string name, int durationDays, decimal price, bool isActive);
        Result DeleteOrDeactivatePlan(int planId);
        int GetActiveSubscriptionCount(int planId);
    }
}
