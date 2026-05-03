using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
        List <string> list1 = new List <string> ();
        while(true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Add an item");
            Console.WriteLine("2 - Remove an item");
            Console.WriteLine("3 - Display all items");
            Console.WriteLine("4 - Clear the entire list");
            Console.WriteLine("5 - End Program");

            string input = Console.ReadLine();
            if (input == 1){}
            else if (input == 2){}
            else if (input == 3){}
            else if (input == 4){}
            else if (input == 5){break;}
            else 
            {
                Console.WriteLine("Enter 1, 2, 3, 4, or 5 only.");
                Continue;
            }
        }//end of loop
    }//end of Main()

    static void DisplayItems (List<string> list)
    {
        int count = 1;
        foreach (string items in list)
        {
            Console.WriteLine($"Item#{count}: {items}");
            count ++;
        }
    }

    static List<string> AddItem (List<string> list)
    {
        Console.WriteLine("Add an item: ");

    }
}//end of class Program