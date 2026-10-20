using System;
using System.Collections.Generic;
using System.Linq;
using GymMembershipSystem.Common;
using GymMembershipSystem.Data;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Services
{
    /// <summary>
    /// Implements subscription lifecycle logic, auto-expiry calculation, and Business Rules 1, 2, and 7.
    /// </summary>
    public class SubscriptionService : ISubscriptionService
    {
        private readonly InMemoryDataStore _dataStore;

        public SubscriptionService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public Subscription? GetActiveSubscription(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Subscriptions
                    .Where(s => s.MemberId == memberId && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today)
                    .OrderByDescending(s => s.ExpiryDate)
                    .FirstOrDefault();
            }
        }

        public Subscription? GetLatestSubscription(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Subscriptions
                    .Where(s => s.MemberId == memberId)
                    .OrderByDescending(s => s.ExpiryDate)
                    .FirstOrDefault();
            }
        }

        public IReadOnlyList<Subscription> GetMemberSubscriptions(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Subscriptions
                    .Where(s => s.MemberId == memberId)
                    .OrderByDescending(s => s.StartDate)
                    .ToList();
            }
        }

        public Result<Subscription> AssignPlan(int memberId, int planId, DateTime startDate, int? trainerId)
        {
            lock (_dataStore.SyncRoot)
            {
                var member = _dataStore.Members.FirstOrDefault(m => m.Id == memberId);
                if (member == null)
                    return Result<Subscription>.Fail($"Member #{memberId} not found.");

                if (!member.IsActive)
                    return Result<Subscription>.Fail($"Member '{member.FullName}' is currently deactivated.");

                var plan = _dataStore.Plans.FirstOrDefault(p => p.Id == planId);
                if (plan == null)
                    return Result<Subscription>.Fail($"Plan #{planId} not found.");

                if (!plan.IsActive)
                    return Result<Subscription>.Fail($"Membership plan '{plan.Name}' is deactivated and cannot be assigned.");

                // Validate Trainer if specified
                if (trainerId.HasValue && trainerId.Value > 0)
                {
                    var trainer = _dataStore.Trainers.FirstOrDefault(t => t.Id == trainerId.Value);
                    if (trainer == null)
                        return Result<Subscription>.Fail($"Trainer #{trainerId.Value} not found.");
                    if (!trainer.IsActive)
                        return Result<Subscription>.Fail($"Trainer '{trainer.FullName}' is deactivated.");
                }
                else
                {
                    trainerId = null;
                }

                startDate = startDate.Date;

                // Enforce Business Rule 2:
                // "A member cannot hold two active subscriptions of the same plan at the same time."
                bool duplicateActivePlan = _dataStore.Subscriptions.Any(s =>
                    s.MemberId == memberId &&
                    s.PlanId == planId &&
                    s.Status == MembershipStatus.Active &&
                    s.ExpiryDate.Date >= startDate);

                if (duplicateActivePlan)
                {
                    return Result<Subscription>.Fail(
                        $"Member '{member.FullName}' already holds an active subscription for '{plan.Name}' covering this date range (Business Rule 2).");
                }

                // Calculate Business Rule 7:
                // Expiry Date = Start Date + Plan.DurationInDays
                var expiryDate = startDate.AddDays(plan.DurationInDays);
                var status = expiryDate >= DateTime.Today ? MembershipStatus.Active : MembershipStatus.Expired;

                var subscription = new Subscription
                {
                    Id = _dataStore.NextSubscriptionId(),
                    MemberId = memberId,
                    PlanId = planId,
                    StartDate = startDate,
                    ExpiryDate = expiryDate,
                    TrainerId = trainerId,
                    Status = status
                };

                _dataStore.Subscriptions.Add(subscription);

                AppEvents.PublishSubscriptionChanged(subscription, ChangeType.Created);
                return Result<Subscription>.Ok(subscription);
            }
        }

        public Result CancelSubscription(int subscriptionId)
        {
            lock (_dataStore.SyncRoot)
            {
                var sub = _dataStore.Subscriptions.FirstOrDefault(s => s.Id == subscriptionId);
                if (sub == null)
                    return Result.Fail($"Subscription #{subscriptionId} not found.");

                sub.Status = MembershipStatus.Inactive;

                AppEvents.PublishSubscriptionChanged(sub, ChangeType.Updated);
                return Result.Ok();
            }
        }
    }
}
