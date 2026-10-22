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
    /// Implements front-desk attendance recording, check-in validation, and daily occupancy tracking.
    /// Enforces:
    /// - Business Rule 1: Only active members with non-expired subscriptions can check in.
    /// - Business Rule 10: Only administrators can record check-ins and check-outs.
    /// </summary>
    public class AttendanceService : IAttendanceService
    {
        private readonly InMemoryDataStore _dataStore;

        public AttendanceService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public Result<Attendance> CheckInMember(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                // Enforce Business Rule 10:
                // "Only an Administrator can record payments and check-ins."
                if (UserSession.CurrentUser?.Role != UserRole.Administrator)
                {
                    return Result<Attendance>.Fail(
                        "Only administrators can record attendance check-ins (Business Rule 10).");
                }

                var member = _dataStore.Members.FirstOrDefault(m => m.Id == memberId);
                if (member == null)
                    return Result<Attendance>.Fail($"Member #{memberId} was not found.");

                if (!member.IsActive)
                    return Result<Attendance>.Fail($"Member '{member.FullName}' is currently deactivated.");

                var today = DateTime.Today;

                // Enforce Business Rule 1:
                // "A member can check in only if the membership is Active (not expired)."
                var activeSubscription = _dataStore.Subscriptions
                    .FirstOrDefault(s => s.MemberId == memberId && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today);

                if (activeSubscription == null)
                {
                    var latestSub = _dataStore.Subscriptions
                        .Where(s => s.MemberId == memberId)
                        .OrderByDescending(s => s.ExpiryDate)
                        .FirstOrDefault();

                    var expiryDetails = latestSub != null
                        ? $"subscription expired on {latestSub.ExpiryDate:yyyy-MM-dd}"
                        : "no membership subscription record";

                    return Result<Attendance>.Fail(
                        $"Check-in denied for '{member.FullName}': {expiryDetails} (Business Rule 1). Please renew membership.");
                }

                // Prevent duplicate check-in if the member is already inside
                var openAttendance = _dataStore.Attendances
                    .FirstOrDefault(a => a.MemberId == memberId && a.CheckInTime.Date == today && !a.CheckOutTime.HasValue);

                if (openAttendance != null)
                {
                    return Result<Attendance>.Fail(
                        $"Member '{member.FullName}' is already checked in today at {openAttendance.CheckInTime:hh:mm tt}.");
                }

                var attendance = new Attendance
                {
                    Id = _dataStore.NextAttendanceId(),
                    MemberId = memberId,
                    CheckInTime = DateTime.Now,
                    CheckOutTime = null
                };

                _dataStore.Attendances.Add(attendance);
                AppEvents.PublishAttendanceRecorded(attendance);

                return Result<Attendance>.Ok(attendance);
            }
        }

        public Result CheckOutMember(int attendanceId)
        {
            lock (_dataStore.SyncRoot)
            {
                // Enforce Business Rule 10
                if (UserSession.CurrentUser?.Role != UserRole.Administrator)
                {
                    return Result.Fail(
                        "Only administrators can record attendance check-outs (Business Rule 10).");
                }

                var attendance = _dataStore.Attendances.FirstOrDefault(a => a.Id == attendanceId);
                if (attendance == null)
                    return Result.Fail($"Attendance record #{attendanceId} was not found.");

                if (attendance.CheckOutTime.HasValue)
                {
                    return Result.Fail(
                        $"Member already checked out at {attendance.CheckOutTime.Value:hh:mm tt}.");
                }

                attendance.CheckOutTime = DateTime.Now;
                AppEvents.PublishAttendanceRecorded(attendance);

                return Result.Ok();
            }
        }

        public Result CheckOutMemberById(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                if (UserSession.CurrentUser?.Role != UserRole.Administrator)
                {
                    return Result.Fail(
                        "Only administrators can record attendance check-outs (Business Rule 10).");
                }

                var today = DateTime.Today;
                var openAttendance = _dataStore.Attendances
                    .FirstOrDefault(a => a.MemberId == memberId && a.CheckInTime.Date == today && !a.CheckOutTime.HasValue);

                if (openAttendance == null)
                {
                    return Result.Fail($"No active check-in record found today for Member #{memberId}.");
                }

                openAttendance.CheckOutTime = DateTime.Now;
                AppEvents.PublishAttendanceRecorded(openAttendance);

                return Result.Ok();
            }
        }

        public IReadOnlyList<Attendance> GetTodayAttendances(string? searchQuery = null, bool currentlyInsideOnly = false)
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                var query = _dataStore.Attendances.Where(a => a.CheckInTime.Date == today);

                if (currentlyInsideOnly)
                {
                    query = query.Where(a => !a.CheckOutTime.HasValue);
                }

                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var trimmed = searchQuery.Trim();
                    query = query.Where(a =>
                    {
                        if (a.Id.ToString() == trimmed || a.MemberId.ToString() == trimmed)
                            return true;

                        var member = _dataStore.Members.FirstOrDefault(m => m.Id == a.MemberId);
                        return member != null && member.FullName.Contains(trimmed, StringComparison.OrdinalIgnoreCase);
                    });
                }

                return query.OrderByDescending(a => a.CheckInTime).ToList();
            }
        }

        public int GetCurrentOccupancyCount()
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Attendances.Count(a => a.CheckInTime.Date == today && !a.CheckOutTime.HasValue);
            }
        }

        public int GetTodayTotalVisitsCount()
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Attendances.Count(a => a.CheckInTime.Date == today);
            }
        }

        public Attendance? GetActiveAttendanceForMember(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Attendances
                    .FirstOrDefault(a => a.MemberId == memberId && a.CheckInTime.Date == today && !a.CheckOutTime.HasValue);
            }
        }

        public bool IsMemberCurrentlyInside(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Attendances
                    .Any(a => a.MemberId == memberId && a.CheckInTime.Date == today && !a.CheckOutTime.HasValue);
            }
        }
    }
}
