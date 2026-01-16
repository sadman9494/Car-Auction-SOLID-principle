namespace CarAuction.Application.Services;

using CarAuction.Application.Interfaces.Services;
using CarAuction.Domain.Entities;
using CarAuction.Domain.Repositories;

/// <summary>
/// Payment service implementation - TODO: Complete implementation
/// </summary>
public class PaymentService : IPaymentService
{
    private readonly IUnitOfWork _unitOfWork;

    public PaymentService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Payment> ProcessPaymentAsync(Guid auctionId, Guid userId, decimal amount)
    {
        throw new NotImplementedException();
    }

    public async Task<Payment> GetPaymentByIdAsync(Guid paymentId)
    {
        throw new NotImplementedException();
    }

    public async Task<Payment?> GetPaymentForAuctionAsync(Guid auctionId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
    {
        throw new NotImplementedException();
    }
}
