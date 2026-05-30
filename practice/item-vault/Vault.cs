public class Vault<T>
{
    private List<T> Any {get; set;} = new();

    public void Add (T item)
    {
        Any.Add(item);
        Console.WriteLine($"Successfully added -- {item}");
    }
    public void Remove (T item)
    {
        Any.Remove(item);
        Console.WriteLine($"Successfully removed -- {item}");
    }

    public T? Find (Predicate<T> match)
    {
        Console.WriteLine($"Searching the Vault...\n");
        T? result = Any.Find(match);

        if (result == null)
        {
            Console.WriteLine("Item not found in the Vault!");
            return default;
        }
        Console.WriteLine($"Found -- {result}");
        return result;
    }

    public void ListAll()
    {
        for(int count = 0; count < Any.Count; count ++) 
        {
            Console.WriteLine($"Item#{count+1}");
            Console.WriteLine($"{Any[count]}");
        }
    }
}