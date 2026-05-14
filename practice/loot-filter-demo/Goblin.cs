using System;

public class Goblin : Enemy, ILootable
{

    public Goblin (string name, decimal  hp) : base (name, hp)
    {

    }

    public override void Attack (Enemy target)
    {
        Console.WriteLine($"{Name} has attacked {target.Name}!");
    }

    public void DropLoot ()
    {
        Console.WriteLine($"{Name} has dropped goblin sack!");
    }
}