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
    /// Thread-safe in-memory implementation of IPaymentService.
    /// Enforces:
    /// - Business Rule 9: Payment amount must be strictly greater than 0 and recorded against an active member.
    /// - Business Rule 10: Only an administrator can record payments.
    /// </summary>
    public class PaymentService : IPaymentService
    {
        private readonly InMemoryDataStore _dataStore;

        public PaymentService(InMemoryDataStore? dataStore = null)
        {
            _dataStore = dataStore ?? InMemoryDataStore.Instance;
        }

        public Result<Payment> RecordPayment(
            int memberId,
            decimal amount,
            PaymentMethod method,
            DateTime paymentDate,
            string? notes)
        {
            lock (_dataStore.SyncRoot)
            {
                // Enforce Business Rule 10:
                // "Only an Administrator can record payments and check-ins."
                if (UserSession.CurrentUser?.Role != UserRole.Administrator)
                {
                    return Result<Payment>.Fail(
                        "Only administrators can record payments (Business Rule 10).");
                }

                // Enforce Business Rule 9:
                // "A payment amount must be greater than 0 and is recorded against a member."
                if (amount <= 0)
                {
                    return Result<Payment>.Fail(
                        "Payment amount must be greater than zero (Business Rule 9).");
                }

                var member = _dataStore.Members.FirstOrDefault(m => m.Id == memberId);
                if (member == null)
                    return Result<Payment>.Fail($"Member #{memberId} was not found.");

                if (!member.IsActive)
                    return Result<Payment>.Fail($"Member '{member.FullName}' is currently deactivated.");

                var payment = new Payment
                {
                    Id = _dataStore.NextPaymentId(),
                    MemberId = memberId,
                    Amount = Math.Round(amount, 2),
                    PaymentDate = paymentDate,
                    PaymentMethod = method,
                    Notes = notes?.Trim() ?? string.Empty
                };

                _dataStore.Payments.Add(payment);
                AppEvents.PublishPaymentReceived(payment);

                return Result<Payment>.Ok(payment);
            }
        }

        public decimal GetMemberOutstandingBalance(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.GetMemberBalance(memberId);
            }
        }

        public decimal GetMemberTotalBilled(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.GetMemberTotalCost(memberId);
            }
        }

        public decimal GetMemberTotalPaid(int memberId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.GetMemberTotalPaid(memberId);
            }
        }

        public decimal GetTotalRevenue(DateTime? fromDate = null, DateTime? toDate = null)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Payments.AsEnumerable();

                if (fromDate.HasValue)
                {
                    query = query.Where(p => p.PaymentDate.Date >= fromDate.Value.Date);
                }

                if (toDate.HasValue)
                {
                    query = query.Where(p => p.PaymentDate.Date <= toDate.Value.Date);
                }

                return query.Sum(p => p.Amount);
            }
        }

        public decimal GetMonthlyRevenue(int? year = null, int? month = null)
        {
            lock (_dataStore.SyncRoot)
            {
                int targetYear = year ?? DateTime.Today.Year;
                int targetMonth = month ?? DateTime.Today.Month;

                return _dataStore.Payments
                    .Where(p => p.PaymentDate.Year == targetYear && p.PaymentDate.Month == targetMonth)
                    .Sum(p => p.Amount);
            }
        }

        public decimal GetTotalOutstandingBalance()
        {
            lock (_dataStore.SyncRoot)
            {
                decimal totalBalance = 0;
                foreach (var member in _dataStore.Members.Where(m => m.IsActive))
                {
                    decimal balance = _dataStore.GetMemberBalance(member.Id);
                    if (balance > 0)
                    {
                        totalBalance += balance;
                    }
                }
                return totalBalance;
            }
        }

        public IReadOnlyList<Payment> GetPayments(
            int? memberIdFilter = null,
            DateTime? fromDate = null,
            DateTime? toDate = null,
            PaymentMethod? methodFilter = null,
            string? searchQuery = null)
        {
            lock (_dataStore.SyncRoot)
            {
                var query = _dataStore.Payments.AsEnumerable();

                if (memberIdFilter.HasValue && memberIdFilter.Value > 0)
                {
                    query = query.Where(p => p.MemberId == memberIdFilter.Value);
                }

                if (fromDate.HasValue)
                {
                    query = query.Where(p => p.PaymentDate.Date >= fromDate.Value.Date);
                }

                if (toDate.HasValue)
                {
                    query = query.Where(p => p.PaymentDate.Date <= toDate.Value.Date);
                }

                if (methodFilter.HasValue)
                {
                    query = query.Where(p => p.PaymentMethod == methodFilter.Value);
                }

                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    var trimmed = searchQuery.Trim();
                    query = query.Where(p =>
                    {
                        if (p.Id.ToString() == trimmed || p.MemberId.ToString() == trimmed)
                            return true;

                        var member = _dataStore.Members.FirstOrDefault(m => m.Id == p.MemberId);
                        if (member != null && member.FullName.Contains(trimmed, StringComparison.OrdinalIgnoreCase))
                            return true;

                        return p.Notes.Contains(trimmed, StringComparison.OrdinalIgnoreCase);
                    });
                }

                return query.OrderByDescending(p => p.PaymentDate).ThenByDescending(p => p.Id).ToList();
            }
        }

        public Payment? GetPaymentById(int paymentId)
        {
            lock (_dataStore.SyncRoot)
            {
                return _dataStore.Payments.FirstOrDefault(p => p.Id == paymentId);
            }
        }
    }
}
