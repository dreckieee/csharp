using System;

public class Archer : Fighter
{

    public Archer (string name, decimal hp) : base (name, hp)
    {

    }

    public override void Attack (Fighter target)
    {
        Console.WriteLine($"\n{Name} has attacked {target.Name}!");
        Random crit = new Random();
        decimal damage = 30m;
        if(crit.Next(1,101) < 31)
        {
            Console.WriteLine($"Critical hit!");
            damage *= 2m;
        }
        target.HP -= damage;
        Console.WriteLine($"{Name} dealt {damage} damage to {target.Name}!");
    }



}