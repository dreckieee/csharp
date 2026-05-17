using System;

public class ManaPotion : Potion
{

    public ManaPotion (string name, decimal price) : base(name,price)
    {

    }
    public override void Effect()
    {
        Console.WriteLine($"{Name} recovers 50 MP");
    }
}