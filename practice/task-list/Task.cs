

public class Task
{
    public string Title {get; set;}
    public bool IsDone {get; set;}
    public Task (string title, bool isDone)
    {
        Title = title;
        IsDone = isDone;
    }
}