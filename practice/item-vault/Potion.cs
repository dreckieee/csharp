public class Potion 
{
    public string Name {get; set;}
    public string Description {get; set;}

    public Potion (string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        string result = $"\nName: {Name}\nDescription: {Description}\n";
        return result;
    }
}