class Program
{
    static void Main ()
    {
        var inventory = new List<IInventoryItem>
        {
            new PhysicalProduct ("Marlboro Red", 35, 11m),
            new DigitalProduct ("Certificate of Appearance", 599.99m),
            new PhysicalProduct ("Max Candy", 20, 1.5m),
            new DigitalProduct ("Subscription", 900m),
            new PhysicalProduct ("330ml Mineral Water", 10, 15m),
            new DigitalProduct ("Autograph", 99.5m)
        };

        InventoryManager.PrintReport(inventory);

        //sell
        int sellQuantity = 11;
        Console.WriteLine($"\n> Selling {sellQuantity} of each item");
        foreach (IInventoryItem i in inventory)
        {
            try
            {
                Console.WriteLine($"Attempting to sell {i.Name}...");
                i.Sell(sellQuantity);
                Console.WriteLine($"Successfully sold {sellQuantity} {i.Name}!");
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine("Invalid Amount Error: " + ex.Message);
            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine("Insufficient Stock Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("= Sell attempt complete =\n");
            }
        }
        InventoryManager.PrintReport(inventory);


        //restock
        int restockQuantity = 5;
        Console.WriteLine($"\n> Restocking {restockQuantity} of each item");
        foreach (IInventoryItem i in inventory)
        {
            try
            {
                Console.WriteLine($"Attempting to restock {i.Name}...");
                i.Restock(restockQuantity);
                if (i is DigitalProduct)
                {
                    Console.WriteLine($"{i.Name} is a Digital Product. No need to restock");
                }
                else
                {
                    Console.WriteLine($"Successfully restocked {restockQuantity} {i.Name}!");
                }
                
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine("Invalid Amount Error: " + ex.Message);
            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine("Insufficient Stock Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("= Restock attempt complete =\n");
            }
        }
        InventoryManager.PrintReport(inventory);
    }
}