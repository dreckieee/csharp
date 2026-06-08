public class InsufficientFundsException : Exception
{
    public decimal Amount {get; private set;}
    public InsufficientFundsException(string message, decimal amount) : base(message)
    {
        Amount = amount;
    }
}