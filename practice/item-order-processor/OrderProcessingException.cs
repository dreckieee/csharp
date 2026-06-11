public class OrderProcessingException : Exception
{
    public OrderProcessingException (string message) : base (message) {}
    public OrderProcessingException(string message, Exception innerException) : base(message, innerException) {}
}