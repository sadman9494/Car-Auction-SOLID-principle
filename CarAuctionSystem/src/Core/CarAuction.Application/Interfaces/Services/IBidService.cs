namespace CarAuction.Application.Interfaces.Services;

using CarAuction.Domain.Entities;

public interface IBidService
{
    Task<Bid> PlaceBidAsync(Guid auctionId, Guid bidderUserId, decimal bidAmount);
    Task<IEnumerable<Bid>> GetBidsForAuctionAsync(Guid auctionId);
    Task<IEnumerable<Bid>> GetBidsFromUserAsync(Guid userId);
    Task<Bid?> GetHighestBidForAuctionAsync(Guid auctionId);
}
