using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using GymMembershipSystem.Common;
using GymMembershipSystem.Data;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Services
{
    /// <summary>
    /// Implements member profile management, business validations, and Business Rule 8 enforcement.
    /// </summary>
    public class MemberService : IMemberService
    {
        private readonly InMemoryDataStore _dataStore;

        public MemberService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public IReadOnlyList<Member> GetMembers(string? searchQuery = null, int? planIdFilter = null, MembershipStatus? statusFilter = null)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Members.AsEnumerable();

                // 1. Text Search (ID or Name or Phone or Email)
                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var clean = searchQuery.Trim();
                    bool isId = int.TryParse(clean.TrimStart('#'), out var parsedId);

                    query = query.Where(m =>
                        (isId && m.Id == parsedId) ||
                        m.FullName.Contains(clean, StringComparison.OrdinalIgnoreCase) ||
                        m.Phone.Contains(clean, StringComparison.OrdinalIgnoreCase) ||
                        m.Email.Contains(clean, StringComparison.OrdinalIgnoreCase));
                }

                // 2. Plan Filter
                if (planIdFilter.HasValue && planIdFilter.Value > 0)
                {
                    var today = DateTime.Today;
                    var memberIdsWithPlan = _dataStore.Subscriptions
                        .Where(s => s.PlanId == planIdFilter.Value && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today)
                        .Select(s => s.MemberId)
                        .Distinct()
                        .ToHashSet();

                    query = query.Where(m => memberIdsWithPlan.Contains(m.Id));
                }

                // 3. Status Filter (Active, Expired, Inactive)
                if (statusFilter.HasValue)
                {
                    query = query.Where(m => GetMemberStatusInternal(m.Id) == statusFilter.Value);
                }

                return query.OrderByDescending(m => m.Id).ToList();
            }
        }

        public Member? GetMemberById(int id)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Members.FirstOrDefault(m => m.Id == id);
            }
        }

        public Result<Member> RegisterMember(string fullName, Gender gender, DateTime dob, string phone, string email, string address, DateTime joinDate)
        {
            var valResult = ValidateMemberInputs(fullName, dob, phone, email, address);
            if (valResult.IsFailure)
                return Result<Member>.Fail(valResult.Error);

            fullName = fullName.Trim();
            phone = phone.Trim();
            email = email.Trim().ToLowerInvariant();
            address = address.Trim();

            Member member;
            lock (_dataStore.SyncRoot)
            {
                member = new Member
                {
                    Id = _dataStore.NextMemberId(),
                    FullName = fullName,
                    Gender = gender,
                    DateOfBirth = dob.Date,
                    Phone = phone,
                    Email = email,
                    Address = address,
                    JoinDate = joinDate.Date,
                    IsActive = true
                };

                _dataStore.Members.Add(member);
            }

            AppEvents.PublishMemberChanged(member, ChangeType.Created);
            return Result<Member>.Ok(member);
        }

        public Result UpdateMember(int id, string fullName, Gender gender, DateTime dob, string phone, string email, string address, bool isActive)
        {
            var valResult = ValidateMemberInputs(fullName, dob, phone, email, address);
            if (valResult.IsFailure)
                return valResult;

            fullName = fullName.Trim();
            phone = phone.Trim();
            email = email.Trim().ToLowerInvariant();
            address = address.Trim();

            Member? member;
            lock (_dataStore.SyncRoot)
            {
                member = _dataStore.Members.FirstOrDefault(m => m.Id == id);
                if (member == null)
                    return Result.Fail($"Member #{id} not found.");

                member.FullName = fullName;
                member.Gender = gender;
                member.DateOfBirth = dob.Date;
                member.Phone = phone;
                member.Email = email;
                member.Address = address;
                member.IsActive = isActive;
            }

            AppEvents.PublishMemberChanged(member, ChangeType.Updated);
            return Result.Ok();
        }

        public Result DeleteOrDeactivateMember(int id)
        {
            Member? member;
            bool hasSubscriptionsOrPayments;

            lock (_dataStore.SyncRoot)
            {
                member = _dataStore.Members.FirstOrDefault(m => m.Id == id);
                if (member == null)
                    return Result.Fail($"Member #{id} not found.");

                // Enforce Business Rule 8:
                // "A member with existing subscriptions or payments cannot be deleted; the member must be deactivated instead."
                bool hasSubs = _dataStore.Subscriptions.Any(s => s.MemberId == id);
                bool hasPayments = _dataStore.Payments.Any(p => p.MemberId == id);
                bool hasBookings = _dataStore.Bookings.Any(b => b.MemberId == id);

                hasSubscriptionsOrPayments = hasSubs || hasPayments || hasBookings;

                if (hasSubscriptionsOrPayments)
                {
                    // Soft-deactivation per Business Rule 8
                    member.IsActive = false;
                }
                else
                {
                    // Safe to hard delete
                    _dataStore.Members.Remove(member);
                }
            }

            AppEvents.PublishMemberChanged(member, hasSubscriptionsOrPayments ? ChangeType.Updated : ChangeType.Deleted);
            return Result.Ok();
        }

        public Subscription? GetMemberActiveSubscription(int memberId)
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

        public Subscription? GetMemberLatestSubscription(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Subscriptions
                    .Where(s => s.MemberId == memberId)
                    .OrderByDescending(s => s.ExpiryDate)
                    .FirstOrDefault();
            }
        }

        public Plan? GetMemberCurrentPlan(int memberId)
        {
            var sub = GetMemberActiveSubscription(memberId) ?? GetMemberLatestSubscription(memberId);
            if (sub == null) return null;

            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Plans.FirstOrDefault(p => p.Id == sub.PlanId);
            }
        }

        public MembershipStatus GetMemberStatus(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return GetMemberStatusInternal(memberId);
            }
        }

        private MembershipStatus GetMemberStatusInternal(int memberId)
        {
            var member = _dataStore.Members.FirstOrDefault(m => m.Id == memberId);
            if (member == null || !member.IsActive)
                return MembershipStatus.Inactive;

            var today = DateTime.Today;
            var sub = _dataStore.Subscriptions
                .Where(s => s.MemberId == memberId)
                .OrderByDescending(s => s.ExpiryDate)
                .FirstOrDefault();

            if (sub == null)
                return MembershipStatus.Inactive;

            if (sub.Status == MembershipStatus.Active && sub.ExpiryDate.Date >= today)
                return MembershipStatus.Active;

            return MembershipStatus.Expired;
        }

        private Result ValidateMemberInputs(string fullName, DateTime dob, string phone, string email, string address)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return Result.Fail("Member full name cannot be blank.");

            if (fullName.Trim().Length < 2)
                return Result.Fail("Member full name must be at least 2 characters.");

            if (dob.Date > DateTime.Today)
                return Result.Fail("Date of birth cannot be in the future.");

            if (dob.Date > DateTime.Today.AddYears(-12))
                return Result.Fail("Member must be at least 12 years of age.");

            if (string.IsNullOrWhiteSpace(phone))
                return Result.Fail("Phone number cannot be blank.");

            var cleanPhone = phone.Trim();
            if (!Regex.IsMatch(cleanPhone, @"^[0-9\+\-\(\)\s]{7,25}$") || cleanPhone.Count(char.IsDigit) < 6)
                return Result.Fail("Please provide a valid phone number (at least 6 digits).");

            if (string.IsNullOrWhiteSpace(email))
                return Result.Fail("Email address cannot be blank.");

            var cleanEmail = email.Trim();
            if (!Regex.IsMatch(cleanEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                return Result.Fail("Please provide a valid email address (e.g. name@example.com).");

            if (string.IsNullOrWhiteSpace(address))
                return Result.Fail("Residential address cannot be blank.");

            return Result.Ok();
        }
    }
}
