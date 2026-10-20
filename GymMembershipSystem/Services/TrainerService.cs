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
    /// Implements trainer management operations, validation rules, and in-memory storage interactions.
    /// </summary>
    public class TrainerService : ITrainerService
    {
        private readonly InMemoryDataStore _dataStore;

        public TrainerService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public IReadOnlyList<Trainer> GetAllTrainers(bool includeInactive = false, string? searchQuery = null)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Trainers.AsEnumerable();

                if (!includeInactive)
                {
                    query = query.Where(t => t.IsActive);
                }

                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var cleanQuery = searchQuery.Trim();
                    query = query.Where(t =>
                        t.FullName.Contains(cleanQuery, StringComparison.OrdinalIgnoreCase) ||
                        t.Specialty.Contains(cleanQuery, StringComparison.OrdinalIgnoreCase) ||
                        t.Phone.Contains(cleanQuery, StringComparison.OrdinalIgnoreCase));
                }

                return query.OrderBy(t => t.FullName).ToList();
            }
        }

        public Trainer? GetTrainerById(int trainerId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Trainers.FirstOrDefault(t => t.Id == trainerId);
            }
        }

        public Result<Trainer> CreateTrainer(string name, string specialty, string phone)
        {
            var valResult = ValidateTrainerInputs(name, specialty, phone);
            if (valResult.IsFailure)
                return Result<Trainer>.Fail(valResult.Error);

            name = name.Trim();
            specialty = specialty.Trim();
            phone = phone.Trim();

            Trainer trainer;
            lock (_dataStore.SyncRoot)
            {
                trainer = new Trainer
                {
                    Id = _dataStore.NextTrainerId(),
                    FullName = name,
                    Specialty = specialty,
                    Phone = phone,
                    IsActive = true
                };

                _dataStore.Trainers.Add(trainer);
            }

            AppEvents.PublishTrainerChanged(trainer, ChangeType.Created);
            return Result<Trainer>.Ok(trainer);
        }

        public Result UpdateTrainer(int trainerId, string name, string specialty, string phone, bool isActive)
        {
            var valResult = ValidateTrainerInputs(name, specialty, phone);
            if (valResult.IsFailure)
                return valResult;

            name = name.Trim();
            specialty = specialty.Trim();
            phone = phone.Trim();

            Trainer? trainer;
            lock (_dataStore.SyncRoot)
            {
                trainer = _dataStore.Trainers.FirstOrDefault(t => t.Id == trainerId);
                if (trainer == null)
                    return Result.Fail($"Trainer #{trainerId} not found.");

                trainer.FullName = name;
                trainer.Specialty = specialty;
                trainer.Phone = phone;
                trainer.IsActive = isActive;
            }

            AppEvents.PublishTrainerChanged(trainer, ChangeType.Updated);
            return Result.Ok();
        }

        public Result DeleteOrDeactivateTrainer(int trainerId)
        {
            Trainer? trainer;
            bool isReferenced;

            lock (_dataStore.SyncRoot)
            {
                trainer = _dataStore.Trainers.FirstOrDefault(t => t.Id == trainerId);
                if (trainer == null)
                    return Result.Fail($"Trainer #{trainerId} not found.");

                bool hasClasses = _dataStore.Classes.Any(c => c.TrainerId == trainerId);
                bool hasSubscriptions = _dataStore.Subscriptions.Any(s => s.TrainerId == trainerId);

                isReferenced = hasClasses || hasSubscriptions;

                if (isReferenced)
                {
                    // Soft-deactivate to maintain foreign-key relationship integrity
                    trainer.IsActive = false;
                }
                else
                {
                    // Safe to hard-delete
                    _dataStore.Trainers.Remove(trainer);
                }
            }

            AppEvents.PublishTrainerChanged(trainer, isReferenced ? ChangeType.Updated : ChangeType.Deleted);
            return Result.Ok();
        }

        public int GetAssignedMemberCount(int trainerId)
        {
            lock (_dataStore.SyncRoot)
            {
                var today = DateTime.Today;
                return _dataStore.Subscriptions
                    .Where(s => s.TrainerId == trainerId && s.Status == MembershipStatus.Active && s.ExpiryDate.Date >= today)
                    .Select(s => s.MemberId)
                    .Distinct()
                    .Count();
            }
        }

        public int GetScheduledClassCount(int trainerId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Classes.Count(c => c.TrainerId == trainerId && c.IsActive);
            }
        }

        private Result ValidateTrainerInputs(string name, string specialty, string phone)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Result.Fail("Trainer full name cannot be blank.");

            if (name.Trim().Length < 2)
                return Result.Fail("Trainer name must be at least 2 characters.");

            if (string.IsNullOrWhiteSpace(specialty))
                return Result.Fail("Trainer specialty cannot be blank.");

            if (string.IsNullOrWhiteSpace(phone))
                return Result.Fail("Phone number cannot be blank.");

            var cleanPhone = phone.Trim();
            // Validate phone characters (digits, +, -, (, ), spaces) and minimum digit count
            if (!Regex.IsMatch(cleanPhone, @"^[0-9\+\-\(\)\s]{7,25}$"))
                return Result.Fail("Please provide a valid phone number (digits, optional '+', dashes, or parentheses).");

            int digitCount = cleanPhone.Count(char.IsDigit);
            if (digitCount < 6)
                return Result.Fail("Phone number must contain at least 6 digits.");

            return Result.Ok();
        }
    }
}
