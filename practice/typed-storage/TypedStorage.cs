public class TypedStorage <T> where T : class
{
    private List<T> _storage = new List<T>();

    public void Add (T item)
    {
        _storage.Add(item);
    }

    public void Remove (T item)
    {
        _storage.Remove(item);
    }

    public T? Get (Predicate<T> match)
    {
        T? result = _storage.Find(match);
        return result;
    }

    public List<T> GetAll ()
    {
        return new List<T>(_storage);
    }
}