public static class InventoryManager
{
    public static void PrintReport (List<IInventoryItem> inventory)
    {
        Console.WriteLine("\n> Displaying Inventory...");
        for (int x = 0; x < inventory.Count; x++)
        {
            Console.WriteLine($"   Item #{x+1}");
            Console.WriteLine("     Name: ".PadRight(17) + $"{inventory[x].Name}");
            Console.WriteLine("     Price: ".PadRight(17) + $"{inventory[x].Price}");
            Console.WriteLine("     Stock: ".PadRight(17) + $"{inventory[x].Stock}");
            Console.WriteLine();
        }
    }
}