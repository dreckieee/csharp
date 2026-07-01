class Program
{
    static void Main ()
    {
        List<IInventoryItem> inventory = new ()
        { 
            new InventoryItem ("Soya Milk", "Beverages", 9, 19.99m),
            new InventoryItem ("San Miguel Light", "Beverages", 15, 64.5m),
            new InventoryItem ("Red Horse Stallion", "Beverages", 12, 55.0m),
            new InventoryItem ("Absolute Mineral Water 330ml", "Beverages", 20, 12.5m),
            new InventoryItem ("Bear Brand 220ml", "Beverages", 1, 25m),
            new InventoryItem ("Iced Coffee", "Beverages", 6, 32.5m),
            new InventoryItem ("Milk Tea", "Beverages", 8, 45.99m),
            new InventoryItem ("Frappe", "Beverages", 15, 56.75m),
            new InventoryItem ("Coca Cola", "Beverages", 30, 15m),
            new InventoryItem ("C2", "Beverages", 10, 19.95m),
            new InventoryItem ("Gin", "Beverages", 2, 65m),
            new InventoryItem ("Emperador", "Beverages", 7, 130.5m),

            new InventoryItem ("555 Sardines", "Canned Goods", 30, 35.75m),
            new InventoryItem ("San Marino Corned Tuna", "Canned Goods", 1, 32.99m),
            new InventoryItem ("Century Tuna", "Canned Goods", 2, 40m),
            new InventoryItem ("Young's Town Sardines", "Canned Goods", 15, 33m),
            new InventoryItem ("Argentina Corned Beef", "Canned Goods", 25, 41m),
            new InventoryItem ("Delimondo Corned Beef", "Canned Goods", 10, 45m),
            new InventoryItem ("Hokaido Mackerel", "Canned Goods", 2, 42m),
            new InventoryItem ("Ma-Ling", "Canned Goods", 7, 70m),
            new InventoryItem ("Wow Ulam", "Canned Goods", 55, 31.99m),
            new InventoryItem ("Spam", "Canned Goods", 20, 75.5m),
            new InventoryItem ("Ligo Sardines", "Canned Goods", 5, 32.75m),
            new InventoryItem ("Vienna Sausage", "Canned Goods", 5, 30m),

            new InventoryItem ("Cracklings", "Junk Foods", 1, 32m),
            new InventoryItem ("Pillows", "Junk Foods", 2, 19.75m),
            new InventoryItem ("Loaded", "Junk Foods", 5, 18m),
            new InventoryItem ("Okeji", "Junk Foods", 4, 30.75m),
            new InventoryItem ("Nagaraya", "Junk Foods", 20, 41.5m),
            new InventoryItem ("Piatos", "Junk Foods", 25, 45m),
            new InventoryItem ("Oishi", "Junk Foods", 30, 39.99m),
            new InventoryItem ("Pica", "Junk Foods", 15, 35m),
            new InventoryItem ("Mang Juan", "Junk Foods", 12, 32.75m),
            new InventoryItem ("Fish-da", "Junk Foods", 55, 35m),
            new InventoryItem ("Growers", "Junk Foods", 35, 38m),
            new InventoryItem ("Munchers", "Junk Foods", 1, 33m)
        };

        //getlowstock
        try
        {
            Console.WriteLine("\n> Attempting to display low stock items...\n");
            foreach (IInventoryItem item in ReorderAnalyzer.GetLowStock(inventory, 10))
            {
                Console.WriteLine("\tName: ".PadRight(18) + $"{item.Name}");
                Console.WriteLine("\tCategory: ".PadRight(18) + $"{item.Category}");
                Console.WriteLine("\tPrice: ".PadRight(18) + $"{item.Price:C2}");
                Console.WriteLine("\tStock: ".PadRight(18) + $"{item.Stock}");
                Console.WriteLine();
            }
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("ArgumentNull Error: " + $"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("== Attempt to get low stocks finished ==");
        }
        

        //getcategorysummary
        List<CategorySummary> categorySummaries = ReorderAnalyzer.GetCategorySummary(inventory, 10).ToList();
        try
        {
            Console.WriteLine("\n> Displaying category summary...\n");
            foreach ( CategorySummary cs in categorySummaries)
            {
                Console.WriteLine("\tCategory: ".PadRight(18) + $"{cs.Category}");
                Console.WriteLine("\tTotal Stocks: ".PadRight(18) + $"{cs.TotalStocks}");
                Console.WriteLine("\tTotal Value: ".PadRight(18) + $"{cs.TotalValue:C2}");
                Console.WriteLine("\tLow Stock Items: ".PadRight(18) + $"{cs.LowStockItems}");
                Console.WriteLine();
            }
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("ArgumentNull Error: " + $"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("== Attempt to get category summary finished ==");
        }


        

        //getmosturgentcategory
        try
        {
            Console.WriteLine("\n> Displaying most urgent category summary...\n");
            CategorySummary mostUrgentCategory = ReorderAnalyzer.GetMostUrgentCategory(categorySummaries);
            Console.WriteLine("\tCategory: ".PadRight(18) + $"{mostUrgentCategory.Category}");
            Console.WriteLine("\tTotal Stocks: ".PadRight(18) + $"{mostUrgentCategory.TotalStocks}");
            Console.WriteLine("\tTotal Value: ".PadRight(18) + $"{mostUrgentCategory.TotalValue:C2}");
            Console.WriteLine("\tLow Stock Items: ".PadRight(18) + $"{mostUrgentCategory.LowStockItems}");
            Console.WriteLine();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("ArgumentNull Error: " + $"{ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("InvalidOperation Error: " + $"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("== Attempt to get most urgent category summary finished ==");
        }




        
        

    }
}