namespace CarAuction.Domain.Repositories;

using CarAuction.Domain.Entities;

public interface IAuctionRepository
{
    Task<Auction?> GetByIdAsync(Guid id);
    Task<IEnumerable<Auction>> GetAllAsync();
    Task<IEnumerable<Auction>> GetActiveAuctionsAsync();
    Task AddAsync(Auction auction);
    Task UpdateAsync(Auction auction);
    Task DeleteAsync(Guid id);
}
