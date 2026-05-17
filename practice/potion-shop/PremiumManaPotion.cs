using System;

public class PremiumManaPotion : Potion, IPremiumPotion
{

    public PremiumManaPotion (string name, decimal price) : base(name,price)
    {

    }
    public override void Effect()
    {
        Console.WriteLine($"{Name} recovers 50 MP");
    }

    public void BonusEffect()
    {
        Console.WriteLine($"{Name} also boosts MP recovery by 50%");
    }

}