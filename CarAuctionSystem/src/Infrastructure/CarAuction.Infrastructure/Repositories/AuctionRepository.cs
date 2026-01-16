namespace CarAuction.Infrastructure.Repositories;

using CarAuction.Domain.Entities;
using CarAuction.Domain.Repositories;

/// <summary>
/// Auction repository implementation - TODO: Implement methods
/// </summary>
public class AuctionRepository : IAuctionRepository
{
    public async Task<Auction?> GetByIdAsync(Guid id) => throw new NotImplementedException();
    public async Task<IEnumerable<Auction>> GetAllAsync() => throw new NotImplementedException();
    public async Task<IEnumerable<Auction>> GetActiveAuctionsAsync() => throw new NotImplementedException();
    public async Task AddAsync(Auction auction) => throw new NotImplementedException();
    public async Task UpdateAsync(Auction auction) => throw new NotImplementedException();
    public async Task DeleteAsync(Guid id) => throw new NotImplementedException();
}
