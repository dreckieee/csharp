using System;
public class Player
{
    public string Name {get; private set;}
    public int Gold {get; private set;}
    public Dictionary<string, int> Inventory {get; private set;}
    public Player (string name, int gold, Dictionary<string, int> inventory)
    {
        Name = name;
        Gold = gold;
        Inventory = inventory;
    }

    public void Buy (string itemName, int itemPrice)
    {
        Console.WriteLine($"Buying 1 \"{itemName}\"...\n");
        if (Gold >= itemPrice)
        {
            if (Inventory.ContainsKey(itemName)) 
            {
                Inventory[itemName] ++;
            }
            else 
            {
                Inventory.Add(itemName, 1);
            }
            Gold -= itemPrice;
            Console.WriteLine($"You have successfully bought 1 {itemName}!");
        }
        else {Console.WriteLine($"You do not have enough gold to buy \"{itemName}\"");}
    }


    public void Sell (string itemName, int itemQuantity, int itemPrice)
    {
        Console.WriteLine($"Selling {itemQuantity} \"{itemName}\"...\n");
        if (Inventory.ContainsKey(itemName))
        {
            if (Inventory[itemName] < itemQuantity) {Console.WriteLine($"Insufficient quantity. You only have {Inventory[itemName]} left in your inventory.");}
            else
            {
                Inventory[itemName] -= itemQuantity;
                Gold += (itemPrice / 2) * itemQuantity;
                Console.WriteLine($"Successfully sold {itemQuantity} {itemName}!");
                if (Inventory[itemName] == 0) {Inventory.Remove(itemName);}
            }
        }
        else {Console.WriteLine($"You do not have \"{itemName}\" in your inventory");}
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Displaying inventory...\n");
        if (Inventory.Count == 0) {Console.WriteLine("Your inventory bag is empty.");}
        else
        {
            int count = 1;
            foreach (KeyValuePair<string, int> inventory in Inventory)
            {
                Console.WriteLine($"> {count}. {inventory.Key} -- {inventory.Value} left");
                count ++;
            }            
        }
    }
}