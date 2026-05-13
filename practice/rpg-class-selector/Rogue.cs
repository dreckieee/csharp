using System;


public class Rogue : Hero
{
    public int Agility {get; set;}

    public Rogue (string name, int level, int agility) : base(name, level)
    {
        Agility = agility;
    }

    public override void GetStats()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Agility: {Agility}");
    }
}