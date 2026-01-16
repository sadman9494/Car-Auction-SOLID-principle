namespace CarAuction.Domain.Repositories;

using CarAuction.Domain.Entities;

public interface IBidRepository
{
    Task<Bid?> GetByIdAsync(Guid id);
    Task<IEnumerable<Bid>> GetByAuctionIdAsync(Guid auctionId);
    Task<IEnumerable<Bid>> GetByUserIdAsync(Guid userId);
    Task<IEnumerable<Bid>> GetAllAsync();
    Task AddAsync(Bid bid);
    Task UpdateAsync(Bid bid);
    Task DeleteAsync(Guid id);
}
