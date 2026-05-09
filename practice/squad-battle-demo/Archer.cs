using System;

public class Archer : Unit
{

    public Archer (string name, decimal maxHP) : base(name, maxHP)
    {
        
    }


    public override void Attack(Unit target)
    {
        decimal damage = 25m;
        Random crit = new Random();
        if(crit.Next(1,101) < 31)
        {
            Console.WriteLine("Critical hit!");
            damage *= 2;
        }
        Console.WriteLine($"{Name} has attacked {target.Name} for {damage} damage!");
        target.TakeDamage(damage);
    }

}