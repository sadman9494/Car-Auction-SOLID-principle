namespace CarAuction.Infrastructure.Repositories;

using CarAuction.Domain.Repositories;

/// <summary>
/// Unit of Work implementation - TODO: Complete implementation
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    public IUserRepository Users => throw new NotImplementedException();
    public ICarRepository Cars => throw new NotImplementedException();
    public IAuctionRepository Auctions => throw new NotImplementedException();
    public IBidRepository Bids => throw new NotImplementedException();
    public IPaymentRepository Payments => throw new NotImplementedException();

    public async Task<int> SaveChangesAsync() => throw new NotImplementedException();
    public async Task BeginTransactionAsync() => throw new NotImplementedException();
    public async Task CommitAsync() => throw new NotImplementedException();
    public async Task RollbackAsync() => throw new NotImplementedException();
    public void Dispose() => throw new NotImplementedException();
}
