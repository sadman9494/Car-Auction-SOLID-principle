namespace CarAuction.Application.Services;

using CarAuction.Application.Interfaces.Services;
using CarAuction.Domain.Entities;
using CarAuction.Domain.Repositories;

/// <summary>
/// Bid service implementation - TODO: Complete implementation
/// </summary>
public class BidService : IBidService
{
    private readonly IUnitOfWork _unitOfWork;

    public BidService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Bid> PlaceBidAsync(Guid auctionId, Guid bidderUserId, decimal bidAmount)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Bid>> GetBidsForAuctionAsync(Guid auctionId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Bid>> GetBidsFromUserAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<Bid?> GetHighestBidForAuctionAsync(Guid auctionId)
    {
        throw new NotImplementedException();
    }
}
