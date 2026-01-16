namespace CarAuction.Application.Strategies.Bidding;

using CarAuction.Application.Interfaces.Strategies;

/// <summary>
/// Standard bidding strategy: bid must be greater than current highest bid
/// </summary>
public class StandardBidStrategy : IBidStrategy
{
    public bool IsValidBid(decimal currentHighestBid, decimal newBid)
    {
        return newBid > currentHighestBid;
    }

    public decimal GetMinimumBidAmount(decimal currentHighestBid)
    {
        return currentHighestBid + 1;
    }

    public string GetStrategyName() => "Standard";
}
