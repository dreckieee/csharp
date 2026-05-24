using System;


class Program
{
    static void Main()
    {
        string prompt0 = "Enter player's name: ";
        string newPlayerName = ReadString(prompt0);
        int newPlayerGold = 100;
        Dictionary<string, int> newPlayerInventory = new Dictionary<string, int>();
        Player player1 = new Player(newPlayerName, newPlayerGold, newPlayerInventory);

        Console.Write("\nWelcome, ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(player1.Name);
        Console.ResetColor();
        Console.WriteLine("!\n");

        Console.WriteLine("Shop is currently empty. Enter 5 Items to sell in shop");
        Dictionary<string, int> listing = new Dictionary<string, int>();
        Shop itemShop = new Shop (listing);

        for (int x = 0; x < 5; x++)
        {
            string prompt1 = "\nEnter the name of the NEW ITEM: ";
            string newItem = ReadString(prompt1).ToUpper();

            string prompt2 = $"Enter the selling price of {newItem}: ";
            int newItemPrice = ReadIntNoMax(prompt2, 0);

            itemShop.AddItem(newItem, newItemPrice);
        }
        
        while (true)
        {
            Console.WriteLine("\n1 -- View Shop");
            Console.WriteLine("2 -- Buy Item");
            Console.WriteLine("3 -- Sell Item");
            Console.WriteLine("4 -- View Inventory");
            Console.WriteLine("5 -- Check Gold");
            Console.WriteLine("0 -- Exit");
            string menuPrompt = "Enter your command (refer above): ";
            int command = ReadInt(menuPrompt, 0, 5);

            if (command == 0) 
            {
                Console.WriteLine("Exiting menu...");
                Console.Write("Press enter key to continue...");
                Console.ReadLine();
                break;
            }


            else if (command == 1) 
            {
                itemShop.DisplayListing();
            }


            else if (command == 2) 
            {
                string buyItemPrompt = "Enter the item you want to buy: ";
                string buyItem = ReadString(buyItemPrompt).ToUpper();
                if (itemShop.Listing.ContainsKey(buyItem))
                {
                    player1.Buy(buyItem, itemShop.Listing[buyItem]);
                }
                else {Console.WriteLine($"There are no {buyItem} in the shop");}           
            }


            else if (command == 3) 
            {
                string sellItemPrompt = "Enter the item you want to sell: ";
                string sellItem = ReadString(sellItemPrompt).ToUpper();

                string sellQuantityPrompt = $"Enter how many \"{sellItem}\" you want to sell: ";
                int sellQuantity = ReadIntNoMax(sellQuantityPrompt, 0);

                if (itemShop.Listing.ContainsKey(sellItem))
                {
                    player1.Sell(sellItem, sellQuantity, itemShop.Listing[sellItem]);
                }
                else {Console.WriteLine($"There are no {sellItem} in the shop");}
            }


            else if (command == 4) 
            {
                player1.DisplayInventory();
            }


            else if (command == 5) 
            {
                Console.WriteLine($"Player has {player1.Gold} gold!");
            }
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

    public static int ReadIntNoMax(string prompt, int min)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min) return result;
                Console.WriteLine($"Must be at least {min}. Try again.");
            }
            else
                Console.WriteLine("Enter an integer. Try again.");
        }
    }//end of ReadIntNoMax method


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


}//end of Program method