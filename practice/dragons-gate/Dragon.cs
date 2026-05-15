using System;
using System.Diagnostics;

public class Dragon : Character
{

    private static Random rng = new Random();
    public Dragon (string name, float maxHP) : base(name, maxHP)
    {

    }
    public override void Attack(Character target)
    {
        Console.Write($"{Name} is now ATTACKING! ");
        float damage = rng.Next(2,61);
        float actualDamage = damage * target.DefenseMultiplier;
        target.HP -= actualDamage;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{actualDamage} damage has been dealt to {target.Name}!");
        Console.ResetColor();
    }

}