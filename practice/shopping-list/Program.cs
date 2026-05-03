using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
        List <string> list1 = new List <string> ();
        while(true)
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Add an item");
            Console.WriteLine("2 - Remove an item");
            Console.WriteLine("3 - Display all items");
            Console.WriteLine("4 - Clear the entire list");
            Console.WriteLine("5 - End Program");
            Console.Write("What do you want to do: ");

            string? input = Console.ReadLine();
            if (input == "1")
            {
                AddItem(list1);
                continue;
            }
            else if (input == "2")
            {
                RemoveItem(list1);
                continue;
            }
            else if (input == "3")
            {
                DisplayItems(list1);
                continue;
            }
            else if (input == "4")
            {
                list1.Clear();
                Console.WriteLine("You have successfully cleared all items in the list! Going back to menu..\n");
                continue;
            }
            else if (input == "5")
            {
                Console.WriteLine("\nEnding program...");
                break;
            }
            else 
            {
                Console.WriteLine("Invalid input. Choose from the option above.\n");
                continue;
            }
        }//end of loop
    }//end of Main()

    static void DisplayItems (List<string> list)
    {
        int count = 1;
        if (list.Count==0)
        {
            Console.WriteLine("\nThere are no items to display, Add an item first. Going back to menu..\n");
        }
        else 
        {
            foreach (string items in list)
            {
                Console.Write($"\nItem#{count}: {items}");
                count ++;
            }
            Console.WriteLine("\nDone displaying the list. Going back to menu..\n");
        }
    }


    static List<string> AddItem (List<string> list)
    {
        Console.Write("\nAdd an item to the list: ");
        string? input = Console.ReadLine();
        if(string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input. Going back to menu..\n");
            return list;
        }
        else
        {
            list.Add(input!);
            Console.WriteLine($"You have successfully added {input} to the list! Going back to menu..\n");
            return list;
        }    
    }//end of AddItem method


    static List<string> RemoveItem (List<string> list)
    {
        if (list.Count==0)
        {
            Console.WriteLine("\nThere are no items in the list, Add an item first. Going back to menu..\n");
            return list;
        }

        else
        {
            Console.Write("\nRemove an item from the list: ");
            string? input = Console.ReadLine();

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Going back to menu..\n");
                return list;
            }
            else
            {
                string? found = list.Find(f => f == input);
                if(found == null)
                {
                    Console.WriteLine("Item not found. going back to menu..\n");
                    return list;
                }
                else 
                {
                    list.Remove(input!);
                    Console.WriteLine($"You have successfully removed {input} from the list! Going back to menu..\n");
                    return list;
                }
            }//end of else


            
        } 
    }//end of RemoveItem method


}//end of class Program