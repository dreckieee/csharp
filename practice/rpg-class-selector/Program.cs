using System;

class Program
{
    
    static void Main()
    {
        string promptName = "\nEnter the NAME of your hero: ";
        string promptClass = "1 -- Knight\n2 -- Wizard\n3 -- Rogue\nEnter the CLASS of your hero: ";

        string heroName = ReadString(promptName);
        string heroClass = ReadString(promptClass);

        switch (heroClass)
        {
            case "1":
                int str = ReadIntNoMax("Enter your knight's STRENGTH: ",0);
                Knight newKnight = new Knight(heroName, 1, str);
                newKnight.GetStats();
                break;
            case "2":
                int intt = ReadIntNoMax("Enter your wizard's INTELLIGENCE: ",0);
                Wizard newWizard = new Wizard(heroName, 1, intt);
                newWizard.GetStats();
                break;
            case "3":
                int agi = ReadIntNoMax("Enter your rogue's Agility: ",0);
                Rogue newRogue = new Rogue(heroName, 1, agi);
                newRogue.GetStats();
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
        Console.WriteLine();


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


    public static int ReadIntNoMax(string prompt, int min)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
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
    }//end of ReadIntNoMax method



}//end of Program class