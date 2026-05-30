public class Inventory <T>
{
    private List<T> _items = new();
    public int Count => _items.Count;
    public void Add (T item)
    {
        _items.Add(item);
    }
    public void Remove (T item)
    {
        _items.Remove(item);
    }
    public List<T> GetAll()
    {
       return _items;
    }
}