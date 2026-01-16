using CarAuction.Domain.Enums;

namespace CarAuction.Domain.Entities;

/// <summary>
/// Represents an auction for a car
/// </summary>
public class Auction
{
    public Guid Id { get; set; }
    public Guid CarId { get; set; }
    public Guid CreatedByUserId { get; set; }
    public AuctionStatus Status { get; set; }
    public decimal StartingPrice { get; set; }
    public decimal ReservePrice { get; set; }
    public decimal CurrentHighestBid { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid? WinnerUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // Navigation properties
    public required Car Car { get; set; }
    public required User CreatedByUser { get; set; }
    public User? WinnerUser { get; set; }
    public ICollection<Bid> Bids { get; set; } = new List<Bid>();
    public Payment? Payment { get; set; }

    public Auction() { }

    public Auction(Guid carId, Guid createdByUserId, decimal startingPrice, 
        decimal reservePrice, DateTime endDate)
    {
        Id = Guid.NewGuid();
        CarId = carId;
        CreatedByUserId = createdByUserId;
        Status = AuctionStatus.Draft;
        StartingPrice = startingPrice;
        ReservePrice = reservePrice;
        CurrentHighestBid = startingPrice;
        StartDate = DateTime.UtcNow;
        EndDate = endDate;
        CreatedDate = DateTime.UtcNow;
    }
}
