using System;

public class Shop
{
    public Dictionary<string, int> Listing {get; private set;}
    public Shop (Dictionary<string, int> listing)
    {
        Listing = listing;
    }
    public void AddItem(string newItem, int newItemPrice)
    {
        Console.WriteLine($"Adding {newItem} to shop listing..\n");
        Listing.Add(newItem, newItemPrice);
        Console.WriteLine($"Successfully added \"{newItem}\" to shop listing!");
    }

    public void RemoveItem(string item)
    {
        Console.WriteLine($"Removing {item} from shop listing..\n");
        if (Listing.Count == 0) {Console.WriteLine("Shop is empty.");}
        else if (!Listing.ContainsKey(item)) {Console.WriteLine($"There is no {item} in the listing.");}
        else 
        {
            Console.WriteLine($"Match found!");
            Listing.Remove(item);
            Console.WriteLine($"Successfully removed {item} from the listing!");
        }
    }

    public void DisplayListing ()
    {
        Console.WriteLine("Displaying SHOP LISTING..\n");

        if (Listing.Count == 0) {Console.WriteLine("Shop is empty.");}
        else
        {
            Console.WriteLine($"===============  SHOP LISTING  ===============");
            int count = 1;
            foreach(KeyValuePair<string, int> pair in Listing)
            {
                Console.WriteLine($"> {count}. {pair.Key} -- {pair.Value} gold");
                count ++;
            }            
        }
    }

    public int GetPrice (string item)
    {
        Console.WriteLine($"Getting the price of {item}..\n");
        if (Listing.Count == 0) {Console.WriteLine("Shop is empty."); return 0;}
        else if (!Listing.ContainsKey(item)) {Console.WriteLine($"There is no {item} in the listing."); return 0;}
        else 
        {
            Console.WriteLine($"Match found!");
            Console.WriteLine($"> {item} -- {Listing[item]} gold");
            return Listing[item];
        }
    }

    public void DisplayLowerOrEqualPrice (int price)
    {
        Console.WriteLine($"Displaying items with prices lower than or equal to {price}..\n");
        int count = 1;
        Console.WriteLine($"=========================  SHOP LISTING  =========================");
        foreach(KeyValuePair<string, int> pair in Listing)
        {
            if (pair.Value <= price)
            {
                Console.WriteLine($"> {count}. {pair.Key} -- {pair.Value} gold");
                count ++;
            }  
        }
        if (count == 1) {Console.WriteLine($"There are no items lower than or equal to {price}");}
    }

}