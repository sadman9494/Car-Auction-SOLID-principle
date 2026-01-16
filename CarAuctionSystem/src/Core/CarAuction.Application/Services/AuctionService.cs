namespace CarAuction.Application.Services;

using CarAuction.Application.Interfaces.Services;
using CarAuction.Domain.Entities;
using CarAuction.Domain.Enums;
using CarAuction.Domain.Repositories;

/// <summary>
/// Auction service implementation - TODO: Complete implementation
/// </summary>
public class AuctionService : IAuctionService
{
    private readonly IUnitOfWork _unitOfWork;

    public AuctionService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Auction> CreateAuctionAsync(Guid carId, Guid createdByUserId, decimal startingPrice, decimal reservePrice, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public async Task<Auction> GetAuctionByIdAsync(Guid auctionId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Auction>> GetAllAuctionsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Auction>> GetActiveAuctionsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAuctionStatusAsync(Guid auctionId, AuctionStatus status)
    {
        throw new NotImplementedException();
    }

    public async Task<Auction> EndAuctionAsync(Guid auctionId)
    {
        throw new NotImplementedException();
    }
}
