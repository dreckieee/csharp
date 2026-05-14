using System;

public abstract class Enemy
{
    public string Name {get; set;}
    public decimal HP {get; set;}
    public Enemy (string name, decimal  hp)
    {
        Name = name;
        HP = hp;
    }

    public abstract void Attack (Enemy target);
}