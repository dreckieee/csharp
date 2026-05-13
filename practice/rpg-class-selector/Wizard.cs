using System;


public class Wizard : Hero
{
    public int Intelligence {get; set;}

    public Wizard (string name, int level, int intelligence) : base(name, level)
    {
        Intelligence = intelligence;
    }

    public override void GetStats()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Intelligence: {Intelligence}");
    }
}