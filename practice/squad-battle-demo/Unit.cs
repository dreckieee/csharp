using System;

public abstract class Unit
{
    public string Name {get; set;}
    public decimal CurrentHP {get; set;}
    public decimal MaxHP {get; set;}
    public Unit (string name, decimal maxHP)
    {
        Name = name;
        MaxHP = maxHP;
        CurrentHP = maxHP;
    }

    public abstract void Attack(Unit target);

    public virtual void TakeDamage(decimal damage)
    {
        CurrentHP -= damage;
        Console.WriteLine($"{Name} has taken {damage} damage!");
    }

}