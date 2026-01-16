namespace CarAuction.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;
using CarAuction.Domain.Entities;

/// <summary>
/// EF Core Database Context - TODO: Configure entity mappings
/// </summary>
public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // TODO: Add entity configurations here
    }
}
