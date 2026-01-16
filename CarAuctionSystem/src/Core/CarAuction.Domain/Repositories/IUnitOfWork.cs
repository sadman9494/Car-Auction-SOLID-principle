namespace CarAuction.Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    ICarRepository Cars { get; }
    IAuctionRepository Auctions { get; }
    IBidRepository Bids { get; }
    IPaymentRepository Payments { get; }

    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}
