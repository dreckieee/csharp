using System;

public class PremiumHealingPotion : Potion, IPremiumPotion
{

    public PremiumHealingPotion (string name, decimal price) : base(name,price)
    {

    }
    public override void Effect()
    {
        Console.WriteLine($"{Name} heals for 50 HP");
    }

    public void BonusEffect()
    {
        Console.WriteLine($"{Name} also boosts HP recovery by 50%");
    }

}