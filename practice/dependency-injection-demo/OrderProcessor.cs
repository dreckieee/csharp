public class OrderProcessor 
{
    private readonly ILogger _logger;
    public OrderProcessor (ILogger logger)
    {
        _logger = logger;
    }
    public void ProcessOrder (string orderId)
    {
        _logger.Log($"Processing order {orderId}");
    }
}