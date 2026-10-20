using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for gym trainer catalog operations and assignment rules.
    /// </summary>
    public interface ITrainerService
    {
        IReadOnlyList<Trainer> GetAllTrainers(bool includeInactive = false, string? searchQuery = null);
        Trainer? GetTrainerById(int trainerId);
        Result<Trainer> CreateTrainer(string name, string specialty, string phone);
        Result UpdateTrainer(int trainerId, string name, string specialty, string phone, bool isActive);
        Result DeleteOrDeactivateTrainer(int trainerId);
        int GetAssignedMemberCount(int trainerId);
        int GetScheduledClassCount(int trainerId);
    }
}
