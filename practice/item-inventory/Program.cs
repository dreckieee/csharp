using System;


class Program
{
    private static List<Item> items = new List<Item>();
    static void Main()
    {
        
        string menu = "\n=================== ITEM INVENTORY ===================\n1 -- Add an Item\n2 -- Use an item\n3 -- Display all items\n4 -- Display items by type\n5 -- Display low stock items\n6 -- End program\n(refer to the options above)\n\n";
        string menuPrompt = "Enter a command: ";
        while(true)
        {
            Console.Write(menu);
            int command = ReadInt(menuPrompt,1,6);
        
            if(command == 1)
            {
                AddItem();
            }
            else if (command == 2)
            {
                UseItem();
            }
            else if (command == 3)
            {
                DisplayItems();
            }
            else if (command == 4)
            {
                DisplayByType();
            }
            else if (command == 5)
            {
                DisplayLowStock();
            }
            else if (command == 6)
            {
                Console.WriteLine("\nEnding program..\n");
                break;
            }
        }

    }//end of Main method

    public static void AddItem()
    {
        Console.WriteLine("\nEnter the following information:");
        Item newItem = new Item ( ReadString("Name: "), ReadString("Type: "), ReadIntNoMax("Quantity: ",1) );
        items.Add(newItem);
        Console.WriteLine($"You have successfully added \"{newItem.Name}\" to your inventory!\n\n");
    }//end of AddItem method



    public static void UseItem()
    {
        string input = ReadString("\nEnter the name of the item you want to use: ");
        Item? found = items.Find(f => f.Name == input);
        if(found == null)
        {
            Console.WriteLine($"There is no item named \"{input}\" in your inventory.");
        }
        else
        {
            Console.WriteLine($"You have {found.Quantity} {found.Name} in your inventory");
            int itemsUsed = ReadInt($"How many do you want to use: ", 1,found.Quantity);
            found.Quantity -= itemsUsed;
            Console.WriteLine($"You have successfully used {itemsUsed} of your \"{found.Name}\"!");
            if(found.Quantity == 0)
            {
                items.Remove(found);
            }
        }
    }//end of UseItem method


    public static void DisplayItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("You have an empty inventory. Add an item first.\n");
        }
        else
        {
            Console.WriteLine("\nDisplaying inventory..");
            int count = 1;
            Console.WriteLine("\n=================== ITEM INVENTORY ===================");
            foreach (Item i in items) 
            {
                Console.WriteLine($"Item#{count}");
                Console.WriteLine($"Name: {i.Name}\nType: {i.Type}\nQuantity: {i.Quantity}\n");
                count++;
            }            
        }
    }//end of DisplayItems method


    public static void DisplayByType()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("You have an empty inventory. Add an item first.\n");
        }
        else
        {
            string input = ReadString("Enter the type of item you want to display: ");
            List<Item> itemsByType = items.FindAll(f => f.Type == input);
            if(itemsByType.Count == 0)
            {
                Console.WriteLine($"There are no items with a type named \"{input}\"");
            }
            else
            {
                Console.WriteLine($"\nDisplaying \"{input}\" items..");
                int count = 1;
                Console.WriteLine("\n=================== ITEM INVENTORY ===================");
                foreach (Item i in itemsByType) 
                {
                    Console.WriteLine($"Item#{count}");
                    Console.WriteLine($"Name: {i.Name}\nType: {i.Type}\nQuantity: {i.Quantity}\n");
                    count++;
                }        
            }   
        }
    }//end of DisplayByType method



    public static void DisplayLowStock()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("You have an empty inventory. Add an item first.\n");
        }
        else
        {
            List<Item> itemsByLowStock = items.FindAll(f => f.Quantity <= 2);
            if(itemsByLowStock.Count == 0)
            {
                Console.WriteLine($"All items have good stock levels!\n");
            }
            else
            {
                Console.WriteLine($"\nDisplaying \"LOW STOCK\" items..");
                int count = 1;
                Console.WriteLine("\n=================== ITEM INVENTORY ===================");
                foreach (Item i in itemsByLowStock) 
                {
                    Console.WriteLine($"Item#{count}");
                    Console.WriteLine($"Name: {i.Name}\nType: {i.Type}\nQuantity: {i.Quantity}\n");
                    count++;
                }        
            }   
        }
    }//end of DisplayLowStock method


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
                    Console.WriteLine($"Invalid. Must be a minimum of {min} and maximum of {max}. Try again.");
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


}//end of Program class
