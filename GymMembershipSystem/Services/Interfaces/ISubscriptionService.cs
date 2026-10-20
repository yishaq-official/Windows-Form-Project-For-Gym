using System;
using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for membership subscription assignments, renewal calculations, and rule enforcement.
    /// </summary>
    public interface ISubscriptionService
    {
        Subscription? GetActiveSubscription(int memberId);
        Subscription? GetLatestSubscription(int memberId);
        IReadOnlyList<Subscription> GetMemberSubscriptions(int memberId);
        Result<Subscription> AssignPlan(int memberId, int planId, DateTime startDate, int? trainerId);
        Result CancelSubscription(int subscriptionId);
    }
}
