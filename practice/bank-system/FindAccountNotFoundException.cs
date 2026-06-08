public class FindAccountNotFoundException : Exception
{
    public string AccountOwner {get; private set;}
    public FindAccountNotFoundException (string message, string accountOwner) : base(message)
    {
        AccountOwner = accountOwner;
    }
}