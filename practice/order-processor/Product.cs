public class Product
{
    public string Name {get; private set;}
    public decimal Price {get; private set;}
    public int Stock {get; private set;}
    public Product (string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
    public void PlaceOrder (int quantity)
    {
        if (quantity <= 0)
        {
            throw new InvalidAmountException ($"Order quantity is invalid. Received: {quantity}");
        }
        else if (quantity > Stock)
        {
            throw new InsufficientStockException ($"Insufficient stock for {Name}. Requested: {quantity}, Available: {Stock}");
        }
        else
        {
            Stock -= quantity;
        } 
    }
}