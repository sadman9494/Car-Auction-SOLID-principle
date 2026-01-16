namespace CarAuction.Application.Interfaces.Services;

using CarAuction.Domain.Entities;

public interface IPaymentService
{
    Task<Payment> ProcessPaymentAsync(Guid auctionId, Guid userId, decimal amount);
    Task<Payment> GetPaymentByIdAsync(Guid paymentId);
    Task<Payment?> GetPaymentForAuctionAsync(Guid auctionId);
    Task<IEnumerable<Payment>> GetAllPaymentsAsync();
}
