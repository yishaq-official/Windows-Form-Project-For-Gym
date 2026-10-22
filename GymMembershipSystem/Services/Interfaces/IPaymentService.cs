using System;
using System.Collections.Generic;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;

namespace GymMembershipSystem.Services.Interfaces
{
    /// <summary>
    /// Service contract for financial payments, billing calculations, and ledger queries.
    /// Enforces Business Rules 9 and 10.
    /// </summary>
    public interface IPaymentService
    {
        /// <summary>
        /// Records a payment transaction against a member account.
        /// Enforces Business Rule 10 (Admin only) and Business Rule 9 (Amount > 0).
        /// </summary>
        Result<Payment> RecordPayment(
            int memberId,
            decimal amount,
            PaymentMethod method,
            DateTime paymentDate,
            string? notes);

        /// <summary>
        /// Calculates the outstanding unpaid balance for a member: Total Billed - Total Paid.
        /// </summary>
        decimal GetMemberOutstandingBalance(int memberId);

        /// <summary>
        /// Calculates the total cost of all subscriptions ever held by a member.
        /// </summary>
        decimal GetMemberTotalBilled(int memberId);

        /// <summary>
        /// Calculates the cumulative sum of all payments made by a member.
        /// </summary>
        decimal GetMemberTotalPaid(int memberId);

        /// <summary>
        /// Calculates total revenue within an optional date range.
        /// </summary>
        decimal GetTotalRevenue(DateTime? fromDate = null, DateTime? toDate = null);

        /// <summary>
        /// Calculates revenue collected in the specified month and year (defaults to current month).
        /// </summary>
        decimal GetMonthlyRevenue(int? year = null, int? month = null);

        /// <summary>
        /// Calculates aggregate outstanding balance across all active members.
        /// </summary>
        decimal GetTotalOutstandingBalance();

        /// <summary>
        /// Retrieves payment ledger records with optional filters for member, date range, payment method, and search query.
        /// </summary>
        IReadOnlyList<Payment> GetPayments(
            int? memberIdFilter = null,
            DateTime? fromDate = null,
            DateTime? toDate = null,
            PaymentMethod? methodFilter = null,
            string? searchQuery = null);

        /// <summary>
        /// Retrieves a payment by its receipt ID.
        /// </summary>
        Payment? GetPaymentById(int paymentId);
    }
}
