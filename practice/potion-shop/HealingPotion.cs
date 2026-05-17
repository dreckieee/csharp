using System;

public class HealingPotion : Potion
{

    public HealingPotion (string name, decimal price) : base(name,price)
    {

    }
    public override void Effect()
    {
        Console.WriteLine($"{Name} heals for 50 HP");
    }
}