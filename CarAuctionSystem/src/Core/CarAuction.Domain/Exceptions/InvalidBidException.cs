namespace CarAuction.Domain.Exceptions;

public class InvalidBidException : Exception
{
    public InvalidBidException(string message) : base(message) { }
}
