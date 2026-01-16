namespace CarAuction.Application.Strategies.Pricing;

using CarAuction.Application.Interfaces.Strategies;

/// <summary>
/// Highest bid pricing strategy: final price is the highest bid amount
/// </summary>
public class HighestBidPricingStrategy : IPricingStrategy
{
    public decimal CalculateFinalPrice(decimal highestBid, decimal reservePrice)
    {
        return highestBid;
    }

    public string GetStrategyName() => "HighestBid";
}
