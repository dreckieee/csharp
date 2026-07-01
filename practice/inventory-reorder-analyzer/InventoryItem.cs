public class InventoryItem : IInventoryItem
{
    public string Name {get; private set;}
    public string Category {get; private set;}
    public int Stock {get; private set;}
    public decimal Price {get; private set;}
    public InventoryItem (string name, string category, int stock, decimal price)
    {

        if (stock < 0)
        {
            throw new ArgumentException ("Stock cannot be negative.", nameof(stock));
        }
        if (price < 0)
        {
            throw new ArgumentException ("Price cannot be negative.", nameof(price));
        }

        Name = name;
        Category = category;
        Stock = stock;
        Price = price;
    }
}