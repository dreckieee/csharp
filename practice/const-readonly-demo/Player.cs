public class Player
{
    public readonly string Id;
    public readonly DateTime CreatedAt;

    public string Name {get; private set;}
    public int Level {get; private set;}
    public Player (string name)
    {
        Name = name;
        Level = 1;
        CreatedAt = DateTime.Now;
        Id = Guid.NewGuid().ToString();
    }
}