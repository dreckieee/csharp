using System;

public class Orc : Enemy, ILootable, IElite
{

    public Orc (string name, decimal  hp) : base (name, hp)
    {

    }

    public override void Attack (Enemy target)
    {
        Console.WriteLine($"{Name} has attacked {target.Name}!");
    }

    public void DropLoot ()
    {
        Console.WriteLine($"{Name} has dropped war club!\n");
    }

    public void ShowEliteTitle ()
    {
        Console.WriteLine($"{Name} is an elite Orc!");
    }

}