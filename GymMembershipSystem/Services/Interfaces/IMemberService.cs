using System;
using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for member profile operations, queries, and Rule 8 deactivation enforcement.
    /// </summary>
    public interface IMemberService
    {
        IReadOnlyList<Member> GetMembers(string? searchQuery = null, int? planIdFilter = null, MembershipStatus? statusFilter = null);
        Member? GetMemberById(int id);
        Result<Member> RegisterMember(string fullName, Gender gender, DateTime dob, string phone, string email, string address, DateTime joinDate);
        Result UpdateMember(int id, string fullName, Gender gender, DateTime dob, string phone, string email, string address, bool isActive);
        Result DeleteOrDeactivateMember(int id);
        Subscription? GetMemberActiveSubscription(int memberId);
        Subscription? GetMemberLatestSubscription(int memberId);
        Plan? GetMemberCurrentPlan(int memberId);
        MembershipStatus GetMemberStatus(int memberId);
    }
}
