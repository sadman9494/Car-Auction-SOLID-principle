namespace CarAuction.Application.Interfaces.Strategies;

public interface IBidStrategy
{
    bool IsValidBid(decimal currentHighestBid, decimal newBid);
    decimal GetMinimumBidAmount(decimal currentHighestBid);
    string GetStrategyName();
}
