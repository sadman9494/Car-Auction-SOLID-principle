namespace CarAuction.Domain.Entities;

/// <summary>
/// Represents a car being auctioned
/// </summary>
public class Car
{
    public Guid Id { get; set; }
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public required string Vin { get; set; }
    public decimal EstimatedValue { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }

    // Navigation property
    public Auction? Auction { get; set; }

    public Car() { }

    public Car(string make, string model, int year, string vin, decimal estimatedValue)
    {
        Id = Guid.NewGuid();
        Make = make;
        Model = model;
        Year = year;
        Vin = vin;
        EstimatedValue = estimatedValue;
        CreatedDate = DateTime.UtcNow;
    }
}
