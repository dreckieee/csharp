using System;

public class Hero : Character
{
    private static Random rng = new Random();
    
    public Hero (string name, float maxHP) : base(name, maxHP)
    {

    }
    public override void Attack(Character target)
    {
        Console.Write($"{Name} has chosen to ATTACK! ");
        Console.ForegroundColor = ConsoleColor.Blue;
        float damage = rng.Next(20,29);
        float actualDamage = damage * DefenseMultiplier;
        target.HP -= actualDamage;
        Console.WriteLine($"{damage} damage has been dealt to {target.Name}!");
        Console.ResetColor();
    }

    public void Defend ()
    {
        Console.Write($"{Name} has chosen to DEFEND! ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("+50% reduced incoming damage!");
        DefenseMultiplier = 0.5f;
        Console.ResetColor();
    }
    public void ResetDefend ()
    {
        DefenseMultiplier = 1.0f;
    }
}