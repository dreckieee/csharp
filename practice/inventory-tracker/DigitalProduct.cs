public class DigitalProduct : IInventoryItem
{
    public string Name {get; private set;}
    public int Stock {get; private set;} = 1; //Sentinel value
    public decimal Price {get; private set;}
    public int UnitsSold {get; private set;} = 0;
    public DigitalProduct (string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public void Sell (int quantity)
    {
        if (quantity <= 0)
        {
            throw new InvalidAmountException ($"Invalid quantity for sell order. Received: {quantity}");
        }
        else
        {
            UnitsSold += quantity;
        }
    }
    public void Restock (int quantity)
    {
        
    }
}