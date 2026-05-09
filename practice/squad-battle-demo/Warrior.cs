using System;

public class Warrior : Unit
{

    public Warrior (string name, decimal maxHP) : base(name, maxHP)
    {
        
    }


    public override void Attack(Unit target)
    {
        Console.WriteLine($"{Name} has attacked {target.Name} for 20 damage!");
        target.TakeDamage(20m);
    }

}