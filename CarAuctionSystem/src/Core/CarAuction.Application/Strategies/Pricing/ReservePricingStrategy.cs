namespace CarAuction.Application.Strategies.Pricing;

using CarAuction.Application.Interfaces.Strategies;

/// <summary>
/// Reserve pricing strategy: final price is highest bid only if it meets reserve price
/// </summary>
public class ReservePricingStrategy : IPricingStrategy
{
    public decimal CalculateFinalPrice(decimal highestBid, decimal reservePrice)
    {
        return highestBid >= reservePrice ? highestBid : reservePrice;
    }

    public string GetStrategyName() => "Reserve";
}
