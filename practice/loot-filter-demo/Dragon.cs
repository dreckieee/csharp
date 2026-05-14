using System;

public class Dragon : Enemy, ILootable, IElite
{

    public Dragon (string name, decimal  hp) : base (name, hp)
    {

    }

    public override void Attack (Enemy target)
    {
        Console.WriteLine($"{Name} has attacked {target.Name}!");
    }

    public void DropLoot ()
    {
        Console.WriteLine($"{Name} has dropped dragon hide!\n");
    }

    public void ShowEliteTitle ()
    {
        Console.WriteLine($"{Name} is an elite Dragon!");
    }

}