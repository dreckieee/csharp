using System;

class Program
{
    static void Main ()
    {
        
        var orders = new List<string> { "5", "abc", "3", "xyz", "10" };
        try
        {
            Console.WriteLine("\nPROCESSING ORDERS...");
            List<int> processedOrders = CheckOrders(orders);
        }
        catch (OrderProcessingException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException?.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nProcessing complete.\n");
        }

    }//end of Main method

    static List<int> CheckOrders (List<string> orders)
    {
        var checkedOrders = new List<int>();
        for (int x = 0; x < orders.Count; x++)
        {
            try
            {
                int result = int.Parse(orders[x]);
                Console.WriteLine($"> Order#{x+1} \"{orders[x]}\" processed!");
                checkedOrders.Add(result);
            }
            catch (FormatException ex)
            {
                throw new OrderProcessingException($"> Order Processing Failed. Order#{x+1} \"{orders[x]}\" is not an integer.", ex);
            }
        }
        return checkedOrders;
    }
}//end of Program class