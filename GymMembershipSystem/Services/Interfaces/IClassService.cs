using System;
using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for gym class schedule management and member bookings.
    /// Enforces Business Rules 1, 3, 4, 5, and 6.
    /// </summary>
    public interface IClassService
    {
        /// <summary>
        /// Retrieves gym classes with optional filtering by day of week, trainer, search term, and active status.
        /// </summary>
        IReadOnlyList<GymClass> GetAllClasses(
            DayOfWeek? dayFilter = null,
            int? trainerIdFilter = null,
            string? searchQuery = null,
            bool includeInactive = false);

        /// <summary>
        /// Finds a gym class by ID.
        /// </summary>
        GymClass? GetClassById(int classId);

        /// <summary>
        /// Gets the count of active (non-cancelled) bookings for a class.
        /// </summary>
        int GetActiveBookingCount(int classId);

        /// <summary>
        /// Gets remaining spots in a class (Capacity - ActiveBookings).
        /// </summary>
        int GetAvailableSpots(int classId);

        /// <summary>
        /// Gets all booking records for a class (including or excluding cancelled).
        /// </summary>
        IReadOnlyList<Booking> GetClassBookings(int classId, bool includeCancelled = false);

        /// <summary>
        /// Gets all members currently actively booked into a class.
        /// </summary>
        IReadOnlyList<Member> GetBookedMembers(int classId);

        /// <summary>
        /// Creates a new group fitness class schedule.
        /// </summary>
        Result<GymClass> CreateClass(
            string name,
            int trainerId,
            DayOfWeek dayOfWeek,
            TimeSpan startTime,
            int durationMinutes,
            int capacity);

        /// <summary>
        /// Updates an existing gym class schedule, enforcing Business Rule 6 (capacity >= active bookings).
        /// </summary>
        Result UpdateClass(
            int classId,
            string name,
            int trainerId,
            DayOfWeek dayOfWeek,
            TimeSpan startTime,
            int durationMinutes,
            int capacity,
            bool isActive);

        /// <summary>
        /// Deactivates or removes a gym class schedule.
        /// </summary>
        Result DeleteOrDeactivateClass(int classId);

        /// <summary>
        /// Enrolls an active member into a class, enforcing Business Rules 1, 3, and 4.
        /// </summary>
        Result<Booking> BookMember(int classId, int memberId);

        /// <summary>
        /// Cancels a member's active booking, enforcing Business Rule 5 (restores spot immediately).
        /// </summary>
        Result CancelBooking(int classId, int memberId);

        /// <summary>
        /// Cancels a specific booking by ID.
        /// </summary>
        Result CancelBookingById(int bookingId);
    }
}
