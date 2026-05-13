using System;

public class Swordsman : Fighter
{

    public Swordsman (string name, decimal hp) : base (name, hp)
    {

    }

    public override void Attack (Fighter target)
    {
        Console.WriteLine($"\n{Name} has attacked {target.Name}!");
        decimal damage = 40m;
        target.HP -= damage;
        Console.WriteLine($"{Name} dealt {damage} damage to {target.Name}!");
    }



}