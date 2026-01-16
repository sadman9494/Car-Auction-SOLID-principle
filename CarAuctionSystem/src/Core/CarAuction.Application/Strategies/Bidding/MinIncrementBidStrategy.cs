namespace CarAuction.Application.Strategies.Bidding;

using CarAuction.Application.Interfaces.Strategies;

/// <summary>
/// Minimum increment bidding strategy: bid must be at least $50 above current highest
/// </summary>
public class MinIncrementBidStrategy : IBidStrategy
{
    private const decimal MinimumIncrement = 50m;

    public bool IsValidBid(decimal currentHighestBid, decimal newBid)
    {
        return newBid >= currentHighestBid + MinimumIncrement;
    }

    public decimal GetMinimumBidAmount(decimal currentHighestBid)
    {
        return currentHighestBid + MinimumIncrement;
    }

    public string GetStrategyName() => "MinIncrement";
}
