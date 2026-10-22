using System;
using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for attendance terminal operations, check-in verification, and daily log tracking.
    /// Enforces Business Rules 1 and 10.
    /// </summary>
    public interface IAttendanceService
    {
        /// <summary>
        /// Records a member check-in for the day.
        /// Enforces Business Rule 10 (Admin only) and Business Rule 1 (Active membership required).
        /// </summary>
        Result<Attendance> CheckInMember(int memberId);

        /// <summary>
        /// Records check-out for an active attendance record by attendance ID.
        /// Enforces Business Rule 10 (Admin only).
        /// </summary>
        Result CheckOutMember(int attendanceId);

        /// <summary>
        /// Records check-out for a member currently inside by member ID.
        /// </summary>
        Result CheckOutMemberById(int memberId);

        /// <summary>
        /// Retrieves attendance logs for today with optional search query and inside-only filter.
        /// </summary>
        IReadOnlyList<Attendance> GetTodayAttendances(string? searchQuery = null, bool currentlyInsideOnly = false);

        /// <summary>
        /// Returns the number of members currently inside the facility (no check-out timestamp recorded today).
        /// </summary>
        int GetCurrentOccupancyCount();

        /// <summary>
        /// Returns the total number of visits recorded today.
        /// </summary>
        int GetTodayTotalVisitsCount();

        /// <summary>
        /// Finds the active (open) attendance entry for a member today, if any.
        /// </summary>
        Attendance? GetActiveAttendanceForMember(int memberId);

        /// <summary>
        /// Returns true if the member is currently recorded inside the facility.
        /// </summary>
        bool IsMemberCurrentlyInside(int memberId);
    }
}
