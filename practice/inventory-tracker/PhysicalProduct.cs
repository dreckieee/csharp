public class PhysicalProduct : IInventoryItem
{
    public string Name {get; private set;}
    public int Stock {get; private set;}
    public decimal Price {get; private set;}
    public PhysicalProduct (string name, int stock, decimal price)
    {
        Name = name;
        Stock = stock;
        Price = price;
    }
    public void Sell (int quantity)
    {
        if (quantity <= 0)
        {
            throw new InvalidAmountException ($"Invalid quantity for sell order. Received: {quantity}");
        }
        else if (quantity > Stock)
        {
            throw new InsufficientStockException ($"Sell order for {Name} exceeds stock level. Requested: {quantity}. Available: {Stock}");
        }
        else
        {
            Stock -= quantity;
        }
    }
    public void Restock (int quantity)
    {
        if (quantity <= 0)
        {
            throw new InvalidAmountException ($"Invalid quantity for sell order. Received: {quantity}");
        }
        else
        {
            Stock += quantity;
        }
    }
}