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
    /// Implements membership plan business rules, constraints, and in-memory operations.
    /// </summary>
    public class PlanService : IPlanService
    {
        private readonly InMemoryDataStore _dataStore;

        public PlanService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public IReadOnlyList<Plan> GetAllPlans(bool includeInactive = false)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Plans
                    .Where(p => includeInactive || p.IsActive)
                    .OrderBy(p => p.Price)
                    .ToList();
            }
        }

        public Plan? GetPlanById(int planId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Plans.FirstOrDefault(p => p.Id == planId);
            }
        }

        public Result<Plan> CreatePlan(string name, int durationDays, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Result<Plan>.Fail("Plan name cannot be empty.");

            name = name.Trim();

            if (durationDays <= 0)
                return Result<Plan>.Fail("Plan duration must be at least 1 day.");

            if (price <= 0)
                return Result<Plan>.Fail("Plan price must be greater than zero.");

            Plan plan;
            lock (_dataStore.SyncRoot)
            {
                bool exists = _dataStore.Plans.Any(p =>
                    string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

                if (exists)
                    return Result<Plan>.Fail($"A membership plan named '{name}' already exists.");

                plan = new Plan
                {
                    Id = _dataStore.NextPlanId(),
                    Name = name,
                    DurationInDays = durationDays,
                    Price = decimal.Round(price, 2),
                    IsActive = true
                };

                _dataStore.Plans.Add(plan);
            }

            AppEvents.PublishPlanChanged(plan, ChangeType.Created);
            return Result<Plan>.Ok(plan);
        }

        public Result UpdatePlan(int planId, string name, int durationDays, decimal price, bool isActive)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Result.Fail("Plan name cannot be empty.");

            name = name.Trim();

            if (durationDays <= 0)
                return Result.Fail("Plan duration must be at least 1 day.");

            if (price <= 0)
                return Result.Fail("Plan price must be greater than zero.");

            Plan? plan;
            lock (_dataStore.SyncRoot)
            {
                plan = _dataStore.Plans.FirstOrDefault(p => p.Id == planId);
                if (plan == null)
                    return Result.Fail($"Plan #{planId} not found.");

                bool duplicate = _dataStore.Plans.Any(p =>
                    p.Id != planId && string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

                if (duplicate)
                    return Result.Fail($"Another membership plan named '{name}' already exists.");

                plan.Name = name;
                plan.DurationInDays = durationDays;
                plan.Price = decimal.Round(price, 2);
                plan.IsActive = isActive;
            }

            AppEvents.PublishPlanChanged(plan, ChangeType.Updated);
            return Result.Ok();
        }

        public Result DeleteOrDeactivatePlan(int planId)
        {
            Plan? plan;
            bool hasSubscriptions;

            lock (_dataStore.SyncRoot)
            {
                plan = _dataStore.Plans.FirstOrDefault(p => p.Id == planId);
                if (plan == null)
                    return Result.Fail($"Plan #{planId} not found.");

                hasSubscriptions = _dataStore.Subscriptions.Any(s => s.PlanId == planId);

                if (hasSubscriptions)
                {
                    // Soft-deactivate to preserve historical subscription data
                    plan.IsActive = false;
                }
                else
                {
                    // Safe to hard-delete
                    _dataStore.Plans.Remove(plan);
                }
            }

            AppEvents.PublishPlanChanged(plan, hasSubscriptions ? ChangeType.Updated : ChangeType.Deleted);
            return Result.Ok();
        }

        public int GetActiveSubscriptionCount(int planId)
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Subscriptions.Count(s =>
                    s.PlanId == planId && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today);
            }
        }
    }
}
