class Program
{
    static void Main ()
    {
        var product2 = new Product ("Mouse", 1249.5m, 5);
        var product3 = new Product ("Keyboard", 500m, 5);

        //valid quantity order for "Mouse"
        try
        {
            int quantity = 5;
            Console.WriteLine($"> Purchasing {quantity} {product2.Name}...");
            product2.PlaceOrder(quantity);
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
            Console.WriteLine("\n>> Order attempt complete!\n");
        }


        //invalid quantity order for "Keyboard"
        try
        {
            int quantity = -1;
            Console.WriteLine($"> Purchasing {quantity} {product3.Name}...");
            product3.PlaceOrder(quantity);
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
            Console.WriteLine("\n>> Order attempt complete!\n");
        }


        //insufficient stock order for "Mouse"
        try
        {
            int quantity = 555;
            Console.WriteLine($"> Purchasing {quantity} {product2.Name}...");
            product2.PlaceOrder(quantity);
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
            Console.WriteLine("\n>> Order attempt complete!\n");
        }


        //valid order for "Keyboard"
        try
        {
            int quantity = 5;
            Console.WriteLine($"> Purchasing {quantity} {product3.Name}...");
            product3.PlaceOrder(quantity);
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
            Console.WriteLine("\n>> Order attempt complete!\n");
        }


    }
}