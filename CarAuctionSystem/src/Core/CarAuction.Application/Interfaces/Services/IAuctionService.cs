namespace CarAuction.Application.Interfaces.Services;

using CarAuction.Domain.Entities;
using CarAuction.Domain.Enums;

public interface IAuctionService
{
    Task<Auction> CreateAuctionAsync(Guid carId, Guid createdByUserId, 
        decimal startingPrice, decimal reservePrice, DateTime endDate);
    Task<Auction> GetAuctionByIdAsync(Guid auctionId);
    Task<IEnumerable<Auction>> GetAllAuctionsAsync();
    Task<IEnumerable<Auction>> GetActiveAuctionsAsync();
    Task UpdateAuctionStatusAsync(Guid auctionId, AuctionStatus status);
    Task<Auction> EndAuctionAsync(Guid auctionId);
}
