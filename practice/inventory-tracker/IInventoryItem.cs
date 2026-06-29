public interface IInventoryItem
{
    string Name { get; }
    int Stock { get; }
    decimal Price { get; }
    void Restock(int quantity);
    void Sell(int quantity);
}