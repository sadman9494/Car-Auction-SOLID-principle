namespace CarAuction.Domain.Entities;

/// <summary>
/// Represents a user in the system
/// </summary>
public class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public decimal Balance { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // Navigation properties
    public ICollection<Auction> CreatedAuctions { get; set; } = new List<Auction>();
    public ICollection<Bid> PlacedBids { get; set; } = new List<Bid>();
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public User() { }

    public User(string name, string email, decimal balance = 0)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Balance = balance;
        CreatedDate = DateTime.UtcNow;
    }
}
