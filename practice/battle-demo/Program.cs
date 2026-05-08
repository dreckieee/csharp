using System;
using System.Linq.Expressions;

class Program
{
    public static List<Enemy> enemies = new List<Enemy>();

    static void Main()
    {
        enemies.Add(new Boss ("wyvern dragon", 1000m, 1) );
        enemies.Add(new Enemy ("skeleton king", 100m) );
        enemies.Add(new Enemy ("slime", 10m) );
        while (true)
        {
            Console.WriteLine("\n=============== BATTLE DEMO ===============");
            Console.WriteLine("1 -- Attack an enemy");
            Console.WriteLine("2 -- Display enemies");
            Console.WriteLine("3 -- Exit Program");
            string commandPrompt = "Enter a command: ";
            int command = ReadInt(commandPrompt,1,3);
            if (command == 1)
            {
                AttackEnemy();
            }
            else if (command == 2)
            {
                Console.WriteLine("\nYou have chosen \"DISPLAY ENEMIES\"!");
                DisplayEnemies ();
            }
            else if (command == 3)
            {
                Console.WriteLine("\nYou have chosen \"EXIT PROGRAM\"!");
                Console.WriteLine("Closing program...");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }
        }

    }//end of Main method


    public static void AttackEnemy ()
    {
        Console.WriteLine("\nYou have chosen \"ATTACK AN ENEMY\"!");
        if (enemies.Count == 0)
        {
            Console.WriteLine("There are no enemies left!");
        }
        else
        {
            foreach(Enemy e in enemies)
            {
                Console.Write($"{e.Name} -- {e.HP} HP\n");
            }
            string input = ReadString("Select an enemy to attack (type the name): ");
            Enemy? found = enemies.Find(f => f.Name == input);
            if(found == null)
            {
                Console.WriteLine($"There are no enemies with the name {input}");
            }
            else 
            {
                decimal damage = ReadDecimalNoMax("Enter your damage: ",1);
                found.TakeDamage(damage);
                if(found.HP <= 0)
                {
                    Console.WriteLine($"{found.Name} has been defeated!");
                    enemies.Remove(found);
                }
                else if (found is Boss boss && boss.Phase < 2)
                {
                    if (found.HP <= 500)
                    {
                        boss.Phase = 2;
                        Console.WriteLine($"{boss.Name} has entered Phase {boss.Phase}!");
                        boss.SpecialAttack();
                    }
                }
            }
        }
        Console.WriteLine();
    }//end of AttackEnemy method



    public static void DisplayEnemies ()
    {
        if(enemies.Count == 0)
        {
            Console.WriteLine("There are no enemies left!");
        }
        else
        {
            foreach(Enemy e in enemies)
            {
                Console.Write($"{e.Name} -- {e.HP} HP\n");
            }
        }
        Console.WriteLine();
    }//end of DisplayEnemies method




    public static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Input must be a minimum of {min} and maximum of {max}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }//end ReadInt method



    public static string ReadString(string prompt)
    {
        while(true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be empty. Try again.");
            }
            else
            {
                return input;
            }
        }
    }//end of ReadString method

    public static decimal ReadDecimalNoMax(string prompt, decimal min)
    {
        while (true)
        {
            Console.Write(prompt);
            if(decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                if (result >= min)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Must be at least {min}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter a decimal number. Try again.");
            }
        }
    }//end ReadDecimalNoMax method



}
