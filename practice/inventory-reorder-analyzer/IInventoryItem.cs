public interface IInventoryItem
{
    string Name { get; }
    string Category {get;}
    int Stock { get; }
    decimal Price { get; }
}