public class TaskList<T>
{
    private List<T> Tasks {get; set;} = new();

    public void Add (T task)
    {
        Tasks.Add(task);
    }
    public void Remove (T task)
    {
        Tasks.Remove(task);
    }
    public List<T> FindAll (Predicate<T> match)
    {
        List<T> result = Tasks.FindAll(match);
        return result;
    }
}