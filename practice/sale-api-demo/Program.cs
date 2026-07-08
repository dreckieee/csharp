class Program
{
    static void Main()
    {
        //initialize objects for first sale
        var sale1 = new Sale(new DateTime(2026, 5, 11, 2, 0, 30));
        var saleItem1 = new SaleItem(11, 5, 50.99m);
        var saleItem2 = new SaleItem(12, 15, 150.99m);
        var saleItem3 = new SaleItem(13, 25, 250.99m);
        var saleItem4 = new SaleItem(13, 25, 251.99m);
        
        //add items
        Console.WriteLine("\n> Adding sale items to sale1...");
        TryAddSaleItem(sale1,saleItem1);
        TryAddSaleItem(sale1,saleItem2);
        TryAddSaleItem(sale1,saleItem3);
        TryAddSaleItem(sale1,saleItem4);

        //display sale
        DisplaySale(sale1);

        //remove item
        Console.WriteLine("\n> Removing sale items from sale1...");
        TryRemoveSaleItem(sale1, saleItem4);

        //display sale again
        DisplaySale(sale1);

        //remove non-existent item
        Console.WriteLine("\n> Removing sale items from sale1...");
        TryRemoveSaleItem(sale1, saleItem4);

        //close sale
        TryCloseSale(sale1);
        
        //add item on closed sale
        Console.WriteLine("\n> Adding sale items to sale1...");
        TryAddSaleItem(sale1,saleItem4);

        //display sale again
        DisplaySale(sale1);

        //initialize objects for second sale
        Console.WriteLine("============================================================");
        Console.WriteLine("> Attempting to close on an empty sale");
        var sale2 = new Sale(new DateTime(2025, 5, 11, 2, 0, 30));
        DisplaySale(sale2);
        TryCloseSale(sale2);

        //add previously removed sale
        TryAddSaleItem(sale2, saleItem4);

        //show if added previously removed sale
        DisplaySale(sale2);
        
    }

    public static void DisplaySale (Sale sale)
    {
        try
        {
            Console.WriteLine("\n> Displaying Sample Sale...");
            if (sale.SaleItems.Count == 0)
            {
                throw new ArgumentException("Cannot display a sale without any items.", nameof(sale));
            }
            Console.WriteLine("   Sale Id: ".PadRight(16) + $"{sale.Id}");
            Console.WriteLine("   Sale Date: ".PadRight(16) + $"{sale.SaleDate.ToString("G")}");
            Console.WriteLine("   Created At: ".PadRight(16) + $"{sale.CreatedAt}");
            Console.WriteLine("   Sale Items: ".PadRight(16) + $"{sale.SaleItems.Count}");
            Console.WriteLine();
            int count = 0;
            foreach(SaleItem si in sale.SaleItems)
            {
                count ++;
                Console.WriteLine($"     -> Item #{count}");
                Console.WriteLine("        -- Sale Id: ".PadRight(16) + $"{si.SaleId}");
                Console.WriteLine("        -- Transaction#: ".PadRight(16) + $"{si.TransactionNumber}");
                Console.WriteLine("        -- Product Id: ".PadRight(16) + $"{si.ProductId}");
                Console.WriteLine("        -- Quantity: ".PadRight(16) + $"{si.Quantity}");
                Console.WriteLine("        -- Unit Price: ".PadRight(16) + $"{si.UnitPriceAtSale:C}");
                Console.WriteLine();
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
    }

    public static void TryAddSaleItem (Sale sale, SaleItem saleItem)
    {        
        try
        {
            Console.WriteLine($"    Adding saleItem with the product Id {saleItem.ProductId} to sale1...");
            sale.AddSaleItem(saleItem);
            Console.WriteLine($"      Successfully Added product {saleItem.ProductId}!");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
        finally
        {
            Console.WriteLine("      Adding sale item attempt complete!");
        }
    }

    public static void TryRemoveSaleItem (Sale sale, SaleItem saleItem)
    {
        try
        {
            Console.WriteLine($"    Removing saleItem with the Transaction# {saleItem.TransactionNumber} from sale...");
            sale.RemoveSaleItem(saleItem);
            Console.WriteLine($"      Successfully Removed product with Transaction# {saleItem.TransactionNumber}!");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
        finally
        {
            Console.WriteLine("      Removing sale item attempt complete!");
        }
    }

    public static void TryCloseSale (Sale sale)
    {
        try
        {
            Console.WriteLine("\n> Closing Sample Sale...");
            sale.CloseSale();
            Console.WriteLine($"      Successfully closed Sample Sale!");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("      " + ex.Message);
        }
        finally
        {
            Console.WriteLine("      Closing sale attempt complete!");
        }
    }
}