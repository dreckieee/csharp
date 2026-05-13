using System;


public class Knight : Hero
{
    public int Strength {get; set;}

    public Knight (string name, int level, int strength) : base(name, level)
    {
        Strength = strength;
    }

    public override void GetStats()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Strength: {Strength}");
    }
}