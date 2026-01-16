namespace CarAuction.Domain.Exceptions;

public class AuctionNotFoundException : Exception
{
    public AuctionNotFoundException(Guid auctionId) 
        : base($"Auction with ID '{auctionId}' was not found.") { }
}
