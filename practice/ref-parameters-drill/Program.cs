using System;

class Program
{
    static void Main ()
    {
        Console.WriteLine();
        Console.WriteLine("==================== STATS ====================");
        var character1 = new Character ("Dreck", 100, 15);
        Console.WriteLine($"Name".PadRight(13) + $"{character1.Name}");
        Console.WriteLine($"MaxHP".PadRight(13) + $"{character1.MaxHP}");
        Console.WriteLine($"HP".PadRight(13) + $"{character1.HP}");
        Console.WriteLine($"Attack".PadRight(13) + $"{character1.Attack}");  
        Console.WriteLine("===============================================");
        Console.WriteLine();


        
        int HP = character1.HP;
        int damage = 0;
        int maxHP = character1.MaxHP;

        Console.WriteLine($"> Taking {damage} damage...");
        TakeDamage (ref HP, damage, maxHP);
        character1.HP = HP;

        Console.WriteLine($"Name".PadRight(13) + $"{character1.Name}");
        Console.WriteLine($"MaxHP".PadRight(13) + $"{character1.MaxHP}");
        Console.WriteLine($"HP".PadRight(13) + $"{character1.HP}");
        Console.WriteLine($"Attack".PadRight(13) + $"{character1.Attack}");
        Console.WriteLine();


        int heal = 100;

        Console.WriteLine($"> Healing {heal} HP...");
        HealHP (ref HP, heal, maxHP);
        character1.HP = HP;

        Console.WriteLine($"Name".PadRight(13) + $"{character1.Name}");
        Console.WriteLine($"MaxHP".PadRight(13) + $"{character1.MaxHP}");
        Console.WriteLine($"HP".PadRight(13) + $"{character1.HP}");
        Console.WriteLine($"Attack".PadRight(13) + $"{character1.Attack}");
        Console.WriteLine();

        
        int attack = character1.Attack;
        int attackBuff = 0;

        Console.WriteLine($"> Applying +{attackBuff} attack buff...");
        ApplyBuff (ref attack, attackBuff);
        character1.Attack = attack;

        Console.WriteLine($"Name".PadRight(13) + $"{character1.Name}");
        Console.WriteLine($"MaxHP".PadRight(13) + $"{character1.MaxHP}");
        Console.WriteLine($"HP".PadRight(13) + $"{character1.HP}");
        Console.WriteLine($"Attack".PadRight(13) + $"{character1.Attack}");
        Console.WriteLine();
    }//end of Main method


    static void TakeDamage (ref int hp, int damage, int maxHP)
    {
        hp = Math.Clamp(hp - damage, 0, maxHP);
    }

    static void HealHP (ref int hp, int healAmount, int maxHP)
    {
        hp = Math.Clamp(hp + healAmount, 0, maxHP);
        
    }

    static void ApplyBuff (ref int attack, int buffAmount)
    {
        attack += buffAmount;
    }


}//end of Program class