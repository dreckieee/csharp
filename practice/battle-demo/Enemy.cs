using System;

class Enemy : IDamageable
{
    public string Name {get; set;}
    public decimal HP {get; set;}
    public Enemy (string name, decimal hp)
    {
        Name = name;
        HP = hp;
    }

    public virtual void TakeDamage(decimal amount)
    {
        HP -= amount;
        Console.WriteLine($"{Name} has taken {amount} damage!");
    }
}//end of Enemy class
