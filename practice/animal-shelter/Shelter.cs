public class Shelter <T> where T : Animal
{
    private List<T> _animals = new();
    public int Count => _animals.Count;
    public void Add (T animal)
    {
        _animals.Add(animal);
    }
    public void Remove (T animal)
    {
        _animals.Remove(animal);
    }
    public List<T> GetAll()
    {
       return _animals;
    }
}