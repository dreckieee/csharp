public class Sale
{
    public string Product {get; private set;}
    public string Region {get; private set;}
    public double Amount {get; private set;}
    public readonly DateTime CreatedAt;
    public Sale (string product, string region, double amount)
    {
        Product = product;
        Region = region;
        Amount = amount;
        CreatedAt = DateTime.Now;
    }
}