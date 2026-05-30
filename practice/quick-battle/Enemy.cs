using System;

public abstract class Enemy : Character
{
    public Enemy (string name, float maxHP, float attack, float defense) : base (name, maxHP, attack, defense)
    {

    }

    public abstract string GetUniqueTraitDescription();
    public void DisplayInformation()
    {
        Console.WriteLine("Enemy Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"HP: {MaxHP}");
        Console.WriteLine($"Attack: {Attack}");
        Console.WriteLine($"Defense: {Defense}");
    }
}