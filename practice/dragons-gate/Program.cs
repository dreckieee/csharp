using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║           D R A G O N ' S            ║");
        Console.WriteLine("║               G A T E                ║");
        Console.WriteLine("╚══════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("You are a wandering adventurer..");
        Console.WriteLine("Ahead: a cave. \nInside: a dragon. \n\nBehind: nothing.");
        Console.WriteLine();
        string heroName = ReadString("Enter your name, adventurer: ");
        Hero hero1 = new Hero (heroName, 500f);
        Dragon dragon1 = new Dragon ("Wyvern", 500f);
        Console.Write("Welcome, ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(heroName);
        Console.ResetColor();
        Console.WriteLine("!");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{hero1.Name}");
        Console.ResetColor();
        Console.Write($", please defeat the ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{dragon1.Name}");
        Console.ResetColor();
        Console.WriteLine(" for us!\n\n");
        while(hero1.HP > 0 && dragon1.HP > 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{hero1.Name}");
            Console.ResetColor();
            Console.Write($" ══ {hero1.HP}HP");
            Console.Write("\t\tVS\t");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{dragon1.Name}");
            Console.ResetColor();
            Console.Write($" ══ {dragon1.HP}HP");
            Console.Write("\n1 -- Attack\n2 -- Defend\n3 -- Run\n");

            int command = ReadInt("Choose a command: ",1,3);
            if (command == 1)
            {
                hero1.Attack(dragon1);
                if(dragon1.HP <= 0)
                {
                    Console.WriteLine($"{hero1.Name} has killed the dragon {dragon1.Name}");
                    Console.WriteLine("VICTORY!\n");
                    Console.Write("Press enter key to continue..");
                    Console.ReadLine();
                    break;
                }
            }
            else if (command == 2)
            {
                hero1.Defend();
            }
            else if (command == 3)
            {
                Console.WriteLine($"{hero1.Name} has chosen to RUN!");
                Console.WriteLine("DEFEAT!\n");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }
            dragon1.Attack(hero1);
            if(hero1.HP <= 0)
            {
                Console.WriteLine($"{dragon1.Name} has killed the hero {hero1.Name}");
                Console.WriteLine("DEFEAT!\n");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }
            hero1.ResetDefend();
        }
        

    }//end of Main method
    
    public static string ReadString(string prompt)
    {
        while (true)
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


    public static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
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
    }//end of ReadInt method

}//end of Program class
