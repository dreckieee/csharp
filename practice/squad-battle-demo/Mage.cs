using System;


public class Mage : Unit, IHealable
{

    public decimal Mana {get; set;}
    public Mage (string name, decimal maxHP, decimal mana) : base(name, maxHP)
    {
        Mana = mana;
    }


    public override void Attack(Unit target)
    {
        if (Mana <= 0)
        {
            Console.WriteLine($"Not enough mana to attack!");
        }
        else
        {
            Console.WriteLine($"{Name} has attacked {target.Name} for 30 damage!");
            target.TakeDamage(30m);
            Mana -= 30m;
        }
    }//end of Attack method



    public override void TakeDamage(decimal damage)
    {
        decimal absorbed = 0m;
        decimal overflow = 0m;
        if (Mana > 0)
        {
            
            Mana -= damage;
            if(Mana < 0)
            {
                overflow = Mana;
                absorbed = overflow + damage;
                Console.WriteLine($"{Name}'s shield has absorbed {absorbed} damage!");
                Console.WriteLine($"{Name}'s shield has broken!");
                CurrentHP += overflow;
                Console.WriteLine($"{Name} has taken {overflow*-1} damage!");
                Mana = 0m;
            }
            else if(Mana == 0)
            {
                Console.WriteLine($"{Name}'s shield has broken!");
                absorbed = damage;
                Console.WriteLine($"{Name}'s shield has absorbed {absorbed} damage!");
            }
            else
            {
                absorbed = damage;
                Console.WriteLine($"{Name}'s shield has absorbed {absorbed} damage!");
            }
        }
        else
        {
            CurrentHP -= damage;
            Console.WriteLine($"{Name} has taken {damage} damage!");
        }
    }//end of TakeDamage method

    public void Heal(decimal amount)
    {
        Console.WriteLine($"{Name} has casted \"Heal\"!");
        if(CurrentHP + amount > MaxHP)
        {
            Console.WriteLine($"{Name} has been healed by {MaxHP-CurrentHP} HP!");
            CurrentHP = MaxHP;
        }
        else
        {
            Console.WriteLine($"{Name} has been healed by {amount} HP!");
            CurrentHP += amount;   
        }
    }

}