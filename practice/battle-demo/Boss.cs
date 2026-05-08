using System;


class Boss : Enemy
{

    public int Phase {get; set;}
    public Boss (string name, decimal hp, int phase) :  base (name, hp) 
    {
        Phase = phase;
    }

    public override void TakeDamage(decimal amount)
    {
        decimal reduced = amount * 0.5m;
        HP -= reduced;
        Console.WriteLine($"{Name} has resisted and only took {reduced} damage!");
    }

    public void SpecialAttack()
    {
        Console.WriteLine($"{Name} uses its special skill \"Heal\"!");
        Console.WriteLine($"{Name} is healed by 500 HP!");
        HP += 500;
    }
}//end of Boss class
