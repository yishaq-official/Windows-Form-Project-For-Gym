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
    /// Thread-safe in-memory implementation of IClassService.
    /// Enforces Business Rules:
    /// - Rule 1: Only active members with valid non-expired subscriptions can book classes.
    /// - Rule 3: Rejects bookings when class capacity is reached.
    /// - Rule 4: Prevents a member from booking the same class twice.
    /// - Rule 5: Cancelling a booking frees a spot immediately.
    /// - Rule 6: Prevents reducing capacity below the count of active bookings.
    /// </summary>
    public class ClassService : IClassService
    {
        private readonly InMemoryDataStore _dataStore;

        public ClassService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public IReadOnlyList<GymClass> GetAllClasses(
            DayOfWeek? dayFilter = null,
            int? trainerIdFilter = null,
            string? searchQuery = null,
            bool includeInactive = false)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Classes.AsEnumerable();

                if (!includeInactive)
                {
                    query = query.Where(c => c.IsActive);
                }

                if (dayFilter.HasValue)
                {
                    query = query.Where(c => c.DayOfWeek == dayFilter.Value);
                }

                if (trainerIdFilter.HasValue && trainerIdFilter.Value > 0)
                {
                    query = query.Where(c => c.TrainerId == trainerIdFilter.Value);
                }

                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var trimmed = searchQuery.Trim();
                    query = query.Where(c =>
                        c.Name.Contains(trimmed, StringComparison.OrdinalIgnoreCase) ||
                        c.Id.ToString() == trimmed);
                }

                return query
                    .OrderBy(c => c.DayOfWeek)
                    .ThenBy(c => c.StartTime)
                    .ToList();
            }
        }

        public GymClass? GetClassById(int classId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Classes.FirstOrDefault(c => c.Id == classId);
            }
        }

        public int GetActiveBookingCount(int classId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
            }
        }

        public int GetAvailableSpots(int classId)
        {
            lock (_dataStore.SyncRoot)
            {
                var gymClass = _dataStore.Classes.FirstOrDefault(c => c.Id == classId);
                if (gymClass == null) return 0;
                var activeBookings = _dataStore.Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
                return Math.Max(0, gymClass.Capacity - activeBookings);
            }
        }

        public IReadOnlyList<Booking> GetClassBookings(int classId, bool includeCancelled = false)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Bookings.Where(b => b.ClassId == classId);
                if (!includeCancelled)
                {
                    query = query.Where(b => !b.IsCancelled);
                }
                return query.OrderByDescending(b => b.BookingDate).ToList();
            }
        }

        public IReadOnlyList<Member> GetBookedMembers(int classId)
        {
            lock (_dataStore.SyncRoot)
            {
                var activeMemberIds = _dataStore.Bookings
                    .Where(b => b.ClassId == classId && !b.IsCancelled)
                    .Select(b => b.MemberId)
                    .Distinct()
                    .ToList();

                return _dataStore.Members
                    .Where(m => activeMemberIds.Contains(m.Id))
                    .OrderBy(m => m.FullName)
                    .ToList();
            }
        }

        public Result<GymClass> CreateClass(
            string name,
            int trainerId,
            DayOfWeek dayOfWeek,
            TimeSpan startTime,
            int durationMinutes,
            int capacity)
        {
            lock (_dataStore.SyncRoot)
            {
                var validation = ValidateClassInputs(name, trainerId, durationMinutes, capacity);
                if (validation.IsFailure)
                    return Result<GymClass>.Fail(validation.Error);

                var gymClass = new GymClass
                {
                    Id = _dataStore.NextClassId(),
                    Name = name.Trim(),
                    TrainerId = trainerId,
                    DayOfWeek = dayOfWeek,
                    StartTime = startTime,
                    DurationMinutes = durationMinutes,
                    Capacity = capacity,
                    IsActive = true
                };

                _dataStore.Classes.Add(gymClass);
                AppEvents.PublishGymClassChanged(gymClass, ChangeType.Created);

                return Result<GymClass>.Ok(gymClass);
            }
        }

        public Result UpdateClass(
            int classId,
            string name,
            int trainerId,
            DayOfWeek dayOfWeek,
            TimeSpan startTime,
            int durationMinutes,
            int capacity,
            bool isActive)
        {
            lock (_dataStore.SyncRoot)
            {
                var gymClass = _dataStore.Classes.FirstOrDefault(c => c.Id == classId);
                if (gymClass == null)
                    return Result.Fail($"Class #{classId} not found.");

                var validation = ValidateClassInputs(name, trainerId, durationMinutes, capacity);
                if (validation.IsFailure)
                    return validation;

                // Enforce Business Rule 6:
                // "Capacity cannot be reduced below the current number of bookings."
                int activeBookings = _dataStore.Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
                if (capacity < activeBookings)
                {
                    return Result.Fail(
                        $"Capacity cannot be reduced to {capacity} because there are currently {activeBookings} active bookings for this class (Business Rule 6).");
                }

                gymClass.Name = name.Trim();
                gymClass.TrainerId = trainerId;
                gymClass.DayOfWeek = dayOfWeek;
                gymClass.StartTime = startTime;
                gymClass.DurationMinutes = durationMinutes;
                gymClass.Capacity = capacity;
                gymClass.IsActive = isActive;

                AppEvents.PublishGymClassChanged(gymClass, ChangeType.Updated);
                return Result.Ok();
            }
        }

        public Result DeleteOrDeactivateClass(int classId)
        {
            lock (_dataStore.SyncRoot)
            {
                var gymClass = _dataStore.Classes.FirstOrDefault(c => c.Id == classId);
                if (gymClass == null)
                    return Result.Fail($"Class #{classId} not found.");

                int activeBookings = _dataStore.Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
                bool hasHistory = _dataStore.Bookings.Any(b => b.ClassId == classId);

                if (activeBookings > 0)
                {
                    // Soft-deactivate if active members are booked
                    gymClass.IsActive = false;
                    AppEvents.PublishGymClassChanged(gymClass, ChangeType.Updated);
                    return Result.Ok();
                }

                if (hasHistory)
                {
                    // Has past cancelled bookings -> soft-delete to retain audit integrity
                    gymClass.IsActive = false;
                    AppEvents.PublishGymClassChanged(gymClass, ChangeType.Updated);
                }
                else
                {
                    // No bookings ever recorded -> hard delete
                    _dataStore.Classes.Remove(gymClass);
                    AppEvents.PublishGymClassChanged(gymClass, ChangeType.Deleted);
                }

                return Result.Ok();
            }
        }

        public Result<Booking> BookMember(int classId, int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                var gymClass = _dataStore.Classes.FirstOrDefault(c => c.Id == classId);
                if (gymClass == null)
                    return Result<Booking>.Fail($"Class #{classId} not found.");

                if (!gymClass.IsActive)
                    return Result<Booking>.Fail($"Class '{gymClass.Name}' is deactivated and not accepting bookings.");

                var member = _dataStore.Members.FirstOrDefault(m => m.Id == memberId);
                if (member == null)
                    return Result<Booking>.Fail($"Member #{memberId} not found.");

                if (!member.IsActive)
                    return Result<Booking>.Fail($"Member '{member.FullName}' is currently deactivated.");

                // Enforce Business Rule 1:
                // Only members with an active, non-expired subscription can book classes.
                var today = DateTime.Today;
                var activeSubscription = _dataStore.Subscriptions
                    .FirstOrDefault(s => s.MemberId == memberId && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today);

                if (activeSubscription == null)
                {
                    return Result<Booking>.Fail(
                        $"Member '{member.FullName}' does not have an active membership subscription (Business Rule 1). Please assign or renew their plan before booking classes.");
                }

                // Enforce Business Rule 4:
                // "A member cannot book the same class twice."
                bool alreadyBooked = _dataStore.Bookings.Any(b => b.ClassId == classId && b.MemberId == memberId && !b.IsCancelled);
                if (alreadyBooked)
                {
                    return Result<Booking>.Fail(
                        $"Member '{member.FullName}' is already booked into '{gymClass.Name}' (Business Rule 4).");
                }

                // Enforce Business Rule 3:
                // "A class booking is accepted only if the number of active bookings is below the class capacity.
                // When capacity is reached, new bookings are rejected with a 'Class is full' message."
                int activeCount = _dataStore.Bookings.Count(b => b.ClassId == classId && !b.IsCancelled);
                if (activeCount >= gymClass.Capacity)
                {
                    return Result<Booking>.Fail(
                        $"Class is full. '{gymClass.Name}' has reached its maximum capacity of {gymClass.Capacity} participants (Business Rule 3).");
                }

                var booking = new Booking
                {
                    Id = _dataStore.NextBookingId(),
                    ClassId = classId,
                    MemberId = memberId,
                    BookingDate = DateTime.Today,
                    IsCancelled = false
                };

                _dataStore.Bookings.Add(booking);

                AppEvents.PublishBookingChanged(booking, ChangeType.Created);
                return Result<Booking>.Ok(booking);
            }
        }

        public Result CancelBooking(int classId, int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                var booking = _dataStore.Bookings
                    .FirstOrDefault(b => b.ClassId == classId && b.MemberId == memberId && !b.IsCancelled);

                if (booking == null)
                    return Result.Fail("Active booking not found for this member in the specified class.");

                // Enforce Business Rule 5: Cancelling a booking frees one place immediately.
                booking.IsCancelled = true;

                AppEvents.PublishBookingChanged(booking, ChangeType.Updated);
                return Result.Ok();
            }
        }

        public Result CancelBookingById(int bookingId)
        {
            lock (_dataStore.SyncRoot)
            {
                var booking = _dataStore.Bookings.FirstOrDefault(b => b.Id == bookingId);
                if (booking == null)
                    return Result.Fail($"Booking #{bookingId} not found.");

                if (booking.IsCancelled)
                    return Result.Fail("Booking is already cancelled.");

                // Enforce Business Rule 5
                booking.IsCancelled = true;

                AppEvents.PublishBookingChanged(booking, ChangeType.Updated);
                return Result.Ok();
            }
        }

        private Result ValidateClassInputs(string name, int trainerId, int durationMinutes, int capacity)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Result.Fail("Class name is required.");

            if (name.Trim().Length > 100)
                return Result.Fail("Class name cannot exceed 100 characters.");

            if (trainerId <= 0)
                return Result.Fail("An assigned trainer is required.");

            var trainer = _dataStore.Trainers.FirstOrDefault(t => t.Id == trainerId);
            if (trainer == null)
                return Result.Fail($"Assigned trainer #{trainerId} does not exist.");

            if (!trainer.IsActive)
                return Result.Fail($"Trainer '{trainer.FullName}' is deactivated and cannot be assigned to new classes.");

            if (durationMinutes < 15 || durationMinutes > 300)
                return Result.Fail("Class duration must be between 15 and 300 minutes.");

            if (capacity < 1 || capacity > 100)
                return Result.Fail("Class capacity must be between 1 and 100 participants.");

            return Result.Ok();
        }
    }
}
