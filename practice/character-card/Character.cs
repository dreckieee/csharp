using System;

class Character
{//start of class Character

    public Character(string name, int level, decimal health, decimal attackPower)
    {
        Name = name;
        Level = level;
        Health = health;
        AttackPower = attackPower;
    }
    public string? Name {get; set;}

    private decimal health;

    public decimal Health
    {
        get {return health;}
        set
        {
            if (value < 0) health = 0;
            else health = value;
        }
    }
    public decimal AttackPower {get; set;}

    public int Level {get; set;}


    public void DisplayStats()
    {

        Console.WriteLine("================ STATS =================");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Attack Power: {AttackPower}");
        Console.WriteLine("========================================\n");
    }

    public void LevelUp()
    {
        Level ++;
        Health += 10;
        AttackPower += 5;
        Console.WriteLine($"• {Name} has leveled up!");
        Console.WriteLine($"• +10 to Health!");
        Console.WriteLine($"• +5 to Attack Power");
    }

    public void TakeDamage(decimal damage)
    {
        Health -= damage;
        Console.WriteLine($"• {Name} has taken {Math.Round(damage, 2)} damage!");
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
    


}//end of class Character
