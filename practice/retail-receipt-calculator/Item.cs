public class Item
{
    public string Name {get; private set;}
    public int Quantity {get; private set;}
    public decimal Price {get; private set;}
    public Item (string name, int quantity, decimal price)
    {
        GuardItem(name, quantity, price);

        Name = name;
        Quantity = quantity;
        Price = price;
    }
    private void GuardItem (string name, int quantity, decimal price)
    {
        if (String.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name), "Item name is not provided.");
        }
        if (quantity <= 0)
        {
            throw new ArgumentException("Item quantity cannot be zero (0) or less.", nameof(quantity));
        }
        if (price <= 0)
        {
            throw new ArgumentException("Item price cannot be zero (0) and less.", nameof(price));
        }

    }
}