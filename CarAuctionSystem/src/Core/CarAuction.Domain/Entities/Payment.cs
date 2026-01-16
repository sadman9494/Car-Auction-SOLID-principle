namespace CarAuction.Domain.Entities;

/// <summary>
/// Represents a payment for a won auction
/// </summary>
public class Payment
{
    public Guid Id { get; set; }
    public Guid AuctionId { get; set; }
    public Guid UserIdWithBalance { get; set; }
    public decimal Amount { get; set; }
    public string? PaymentMethod { get; set; }
    public bool IsProcessed { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ProcessedDate { get; set; }

    // Navigation properties
    public required Auction Auction { get; set; }
    public required User User { get; set; }

    public Payment() { }

    public Payment(Guid auctionId, Guid userId, decimal amount)
    {
        Id = Guid.NewGuid();
        AuctionId = auctionId;
        UserIdWithBalance = userId;
        Amount = amount;
        IsProcessed = false;
        CreatedDate = DateTime.UtcNow;
    }
}
