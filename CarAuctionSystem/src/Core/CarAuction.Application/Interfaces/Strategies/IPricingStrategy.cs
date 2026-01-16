namespace CarAuction.Application.Interfaces.Strategies;

public interface IPricingStrategy
{
    decimal CalculateFinalPrice(decimal highestBid, decimal reservePrice);
    string GetStrategyName();
}
