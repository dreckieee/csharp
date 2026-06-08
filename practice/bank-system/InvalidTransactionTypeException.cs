public class InvalidTransactionTypeException : Exception
{
    public string TransactionType {get; private set;}
    public InvalidTransactionTypeException(string message, string transactionType) : base(message)
    {
        TransactionType = transactionType;
    }
}