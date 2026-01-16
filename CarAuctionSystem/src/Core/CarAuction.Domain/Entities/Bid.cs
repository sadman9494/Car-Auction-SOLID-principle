namespace CarAuction.Domain.Entities;

/// <summary>
/// Represents a bid placed on an auction
/// </summary>
public class Bid
{
    public Guid Id { get; set; }
    public Guid AuctionId { get; set; }
    public Guid BidderUserId { get; set; }
    public decimal BidAmount { get; set; }
    public DateTime BidDate { get; set; }

    // Navigation properties
    public required Auction Auction { get; set; }
    public required User BidderUser { get; set; }

    public Bid() { }

    public Bid(Guid auctionId, Guid bidderUserId, decimal bidAmount)
    {
        Id = Guid.NewGuid();
        AuctionId = auctionId;
        BidderUserId = bidderUserId;
        BidAmount = bidAmount;
        BidDate = DateTime.UtcNow;
    }
}
