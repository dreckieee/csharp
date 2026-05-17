using System;
using System.Linq;


class Program
{
    static void Main()
    {

        List<Potion> potions = new List<Potion>();

        HealingPotion newHealingPotion = new HealingPotion("Lesser HP Potion", 100m);
        potions.Add(newHealingPotion);
        PremiumHealingPotion newGreaterHealingPotion = new PremiumHealingPotion("Greater HP Potion", 300m);
        potions.Add(newGreaterHealingPotion);

        ManaPotion newManaPotion = new ManaPotion("Lesser MP Potion", 100m);
        potions.Add(newManaPotion);
        PremiumManaPotion newPremiumManaPotion = new PremiumManaPotion("Greater MP Potion", 300m);
        potions.Add(newPremiumManaPotion);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║             P O T I O N              ║");
        Console.WriteLine("║               S H O P                ║");
        Console.WriteLine("╚══════════════════════════════════════╝");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n═════════════════ MENU ══════════════════");
            Console.WriteLine("1 -- Find a potion by name");
            Console.WriteLine("2 -- Get all potions by price");
            Console.WriteLine("3 -- Get all premium potions");
            Console.WriteLine("4 -- Display potions by ascending or descending");
            Console.WriteLine("0 -- Exit");
            Console.ResetColor();
            string prompt = "Enter a command (refer above): ";
            int input = ReadInt(prompt, 0,4);     
  
            if (input == 1)
            {
                if (potions.Count == 0)
                {
                    Console.WriteLine("\nThere are no potions available.");
                }
                else
                {
                    string namePotion = ReadString("\nEnter the name of the potion you are trying to find: ");
                    Potion? found = potions.Find(f => f.Name == namePotion);
                    if (found == null)
                    {
                        Console.WriteLine($"There is no {namePotion} potion in our shop");
                    }
                    else
                    {
                        Console.WriteLine("Match found!");
                        Console.WriteLine($"Name: {found.Name}");
                        Console.WriteLine($"Price: {found.Price} gold");
                        Console.Write($"Effect: ");
                        found.Effect();
                        if (found is IPremiumPotion premium) 
                        {
                            Console.Write("Bonus Effect: ");
                            premium.BonusEffect();
                        }
                    }
                }
            }//get potions by name


            else if (input == 2)
            {
                if (potions.Count == 0)
                {
                    Console.WriteLine("\nThere are no potions available in our shop.");
                }
                else
                {
                    decimal pricePotion = ReadDecimalNoMax("\nEnter the upper limit on price of potions you want us to display: ",0);
                    List<Potion>? found = potions.FindAll(f => f.Price <= pricePotion);
                    if (found.Count == 0)
                    {
                        Console.WriteLine($"There are no potions with a price of {pricePotion} or below in our shop");
                    }
                    else
                    {
                        Console.WriteLine("\nMatch found!");
                        int count = 1;
                        foreach (Potion p in found)
                        {
                            Console.WriteLine($"\nPOTION#{count}");
                            Console.WriteLine($"Name: {p.Name}");
                            Console.WriteLine($"Price: {p.Price} gold");
                            Console.Write($"Effect: ");
                            p.Effect();
                            if (p is IPremiumPotion premium) 
                            {
                                Console.Write("Bonus Effect: ");
                                premium.BonusEffect();
                            }
                            count ++;
                        }
                    }
                }                
            }//get potions by price


            else if (input == 3)
            {
                if (potions.Count == 0)
                {
                    Console.WriteLine("\nThere are no potions available in our shop.");
                }
                else
                {

                    List<Potion> premium = potions.FindAll(p => p is IPremiumPotion);
                    if (premium.Count == 0) {Console.WriteLine("\nThere are no premium potions available in our shop.");}
                    else
                    {
                        int count = 1;
                        foreach (Potion po in premium)
                        {
                            Console.WriteLine($"\nPOTION#{count}");
                            Console.WriteLine($"Name: {po.Name}");
                            Console.WriteLine($"Price: {po.Price} gold");
                            Console.Write($"Effect: ");
                            po.Effect();
                            if (po is IPremiumPotion premiumm) 
                            {
                                Console.Write("Bonus Effect: ");
                                premiumm.BonusEffect();
                            }
                            count ++;
                        }
                    }
                }
            }//get all premium


            else if (input == 4)
            {
                if (potions.Count == 0) {Console.WriteLine("\nThere are no potions available in our shop.");}
                else
                {
                    Console.WriteLine("\n1 -- Ascending Order\n2 -- Descending Order");
                    int sortBy = ReadInt("\nin what order do you want to sort the potions: ",1,2);   
                    List<Potion> sorted = sortBy == 1 
                    ? potions.OrderBy(s => s.Price).ToList()
                    : potions.OrderByDescending(s => s.Price).ToList();

                    int count = 1;
                    foreach (Potion pot in sorted)
                    {
                        Console.WriteLine($"\nPOTION#{count}");
                        Console.WriteLine($"Name: {pot.Name}");
                        Console.WriteLine($"Price: {pot.Price} gold");
                        Console.Write($"Effect: ");
                        pot.Effect();
                        if (pot is IPremiumPotion premium) 
                        {
                            Console.Write("Bonus Effect: ");
                            premium.BonusEffect();
                        }
                        count ++;
                    }
                }
            }//Ascending/Descending order


            else if (input == 0) 
            {
                Console.WriteLine("\nClosing shop..");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }//Exit
        }//menu loop
    }//end of Main method



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



    public static decimal ReadDecimalNoMax(string prompt, decimal min)
    {
        while (true)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
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
    }//end of ReadDecimalNoMax





}//end of Program class