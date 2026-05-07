using System;

class Program
{
    public static List<Enemy> Enemies = new List<Enemy>();
    static void Main()
    {
        while(true)
        {

            Console.WriteLine("\n=============== ENEMY SPAWNER ===============");
            Console.WriteLine("1 -- Spawn an enemy");
            Console.WriteLine("2 -- Attack an enemy");
            Console.WriteLine("3 -- Display all enemies");
            Console.WriteLine("4 -- Display enemies by type");
            Console.WriteLine("5 -- Display critical enemies");
            Console.WriteLine("6 -- End Program");
            Console.WriteLine("(refer to options above)");
            string menuPrompt = "\nEnter a command: ";
            int command = ReadInt(menuPrompt,1,6);
            if(command == 1)
            {
                SpawnEnemy();
            }
            else if(command == 2)
            {
                AttackEnemy();
            }
            else if(command == 3)
            {
                DisplayEnemies();
            }
            else if(command == 4)
            {
                DisplayEnemiesByType();
            }
            else if(command == 5)
            {
                DisplayCriticalEnemies();
            }
            else 
            {
                Console.Write("\nEnding program..\nPress enter key to continue..");
                Console.ReadLine();
                break;
            }

        }
    }//end of Main method


    public static void SpawnEnemy ()
    {
        Console.WriteLine("You have chosen \"SPAWN AN ENEMY\"");
        Console.WriteLine("\nProvide the information about the new enemy.");
        Enemy newEnemy = new Enemy(ReadString("Name: "), ReadString("Type: "), ReadDecimalNoMax("HP: ", 1));
        Enemies.Add(newEnemy);
        Console.WriteLine($"\nYou have successfully added \"{newEnemy.Name}\" as an enemy!\n");
           
    }//end of SpawnEnemy method

    public static void AttackEnemy ()
    {
        Console.WriteLine("You have chosen \"ATTACK AN ENEMY\"");

        if(Enemies.Count == 0)
        {
            Console.WriteLine("There are no enemies to attack. Spawn an enemy first.");
        }
        else
        {
            string input = ReadString("\nEnter the enemy you want to attack: ");
            Enemy? found = Enemies.Find(f => f.Name == input);
            if (found == null)
            {
                Console.WriteLine($"There are no enemies named \"{input}\"");
            }
            else
            {
                decimal damage = ReadDecimalNoMax( "Enter the amount of damage: ", 0);
                Console.WriteLine($"\nYou have successfully attacked {input} for {damage} damage!\n");
                found.TakeDamage(damage);
                if (found.HP <= 0)
                {
                    Enemies.Remove(found);
                    Console.WriteLine($"{input} has been defeated!");
                }
            }
        }
    }//end of AttackEnemy method


    public static void DisplayEnemies ()
    {
        Console.WriteLine("You have chosen \"DISPLAY ALL ENEMIES\"\n");
        if(Enemies.Count == 0)
        {
            Console.WriteLine("There are no enemies left. Spawn an enemy first.");
        }
        else
        {
            foreach(Enemy e in Enemies)
            {
                Console.WriteLine($"Name: {e.Name}\nType: {e.Type}\nHP: {e.HP}\n");
            }
        }
    }//end of DisplayEnemies method


    public static void DisplayEnemiesByType ()
    {
        Console.WriteLine("You have chosen \"DISPLAY ENEMIES BY TYPE\"\n");
        if(Enemies.Count == 0)
        {
            Console.WriteLine("There are no enemies left. Spawn an enemy first.");
        }
        else
        {
            string input = ReadString("Enter the TYPE to display: ");
            List<Enemy> enemiesByType = Enemies.FindAll(f => f.Type == input);
            if(enemiesByType.Count == 0)
            {
                Console.WriteLine($"There are no \"{input.ToUpper()}\" type enemies left.");
            }
            else
            {
                foreach(Enemy e in enemiesByType)
                {
                    Console.WriteLine($"\nName: {e.Name}\nType: {e.Type}\nHP: {e.HP}");
                }
            }
        }
    }//end of DisplayEnemiesByType method


    public static void DisplayCriticalEnemies ()
    {
        Console.WriteLine("You have chosen \"DISPLAY CRITICAL ENEMIES\"\n");
        if(Enemies.Count == 0)
        {
            Console.WriteLine("There are no enemies left. Spawn an enemy first.");
        }
        else
        {
            List<Enemy> enemiesByCriticalHP = Enemies.FindAll(f => f.HP <= 20);
            if(enemiesByCriticalHP.Count == 0)
            {
                Console.WriteLine($"There are no enemies with \"CRITICAL HP\".");
            }
            else
            {
                foreach(Enemy e in enemiesByCriticalHP)
                {
                    Console.WriteLine($"\nName: {e.Name}\nType: {e.Type}\nHP: {e.HP}");
                }
            }
        }
    }//end of DisplayCriticalEnemies method



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

    public static int ReadIntNoMax(string prompt, int min)
    {
        while (true)
        {
            Console.Write(prompt);
            if(int.TryParse(Console.ReadLine(), out int result))
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
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }//end ReadIntNoMax method




    public static decimal ReadDecimal(string prompt, decimal min, decimal max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Input must be a minimum of {min} and maximum of {max} Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter a decimal number. Try again.");
            }
        }
    }//end of ReadDecimal method


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


}//end of Program class
