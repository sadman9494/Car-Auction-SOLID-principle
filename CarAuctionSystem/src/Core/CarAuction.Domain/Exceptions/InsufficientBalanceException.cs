namespace CarAuction.Domain.Exceptions;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(decimal required, decimal available)
        : base($"Insufficient balance. Required: {required:C}, Available: {available:C}") { }
}
