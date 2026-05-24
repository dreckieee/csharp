

public abstract class Monster
{
    public string Name {get; private set;}
    public string Type {get; private set;}
    public string Description {get; private set;}
    public Monster (string name, string type, string description)
    {
        Name = name;
        Type = type;
        Description = description;
    }

    public abstract string GetEntry();
}