public static class SalesAnalyzer
{
    public static void PrintReport (List<Sale> sales)
    {
        Console.WriteLine($"\nDisplaying SALES REPORT for \"{DateOnly.FromDateTime(DateTime.Now)}\"...");

        

        if (sales.Count == 0)
        {
            Console.WriteLine("\nSales are 0! There is nothing to report.");
        }
        else
        {
            //Number of Sales
            Console.WriteLine("> NUMBER OF SALES: ".PadRight(19) + $"{sales.Count}");

            //Total Revenue
            double revenue = sales.Sum(s => s.Amount);
            Console.WriteLine("> TOTAL SALES: ".PadRight(19) + $"{revenue:C2}");

            //Average of Sales
            double average = sales.Average(s => s.Amount);
            Console.WriteLine("> AVERAGE SALES: ".PadRight(19) + $"{average:C2}");

            //Highest Sale
            Sale highest = sales.MaxBy(s => s.Amount)!;
            Console.WriteLine("> HIGHEST SALE");
            Console.WriteLine("".PadLeft(5) + "Date/Time: ".PadRight(11) + $"{highest.CreatedAt:yyyy-MM-dd HH:mm:ss.fff}");
            Console.WriteLine("".PadLeft(5) + "Product: ".PadRight(11) + $"{highest.Product}");
            Console.WriteLine("".PadLeft(5) + "Region: ".PadRight(11) + $"{highest.Region}");
            Console.WriteLine("".PadLeft(5) + "Amount: ".PadRight(11) + $"{highest.Amount:C2}");

            //Lowest Sale
            Sale lowest = sales.MinBy(s => s.Amount)!;
            Console.WriteLine("> LOWEST SALE");
            Console.WriteLine("".PadLeft(5) + "Date/Time: ".PadRight(11) + $"{lowest.CreatedAt:yyyy-MM-dd HH:mm:ss.fff}");
            Console.WriteLine("".PadLeft(5) + "Product: ".PadRight(11) + $"{lowest.Product}");
            Console.WriteLine("".PadLeft(5) + "Region: ".PadRight(11) + $"{lowest.Region}");
            Console.WriteLine("".PadLeft(5) + "Amount: ".PadRight(11) + $"{lowest.Amount:C2}");

            //Group by Region
            var grouped = sales.GroupBy(s => s.Region);
            Console.WriteLine("> REGIONAL SALES");
            foreach (var r in grouped)
            {
                double regionalRevenue = r.Sum(s => s.Amount);
                Console.WriteLine("".PadLeft(5) + $"{r.Key}: ".PadRight(11) + $"{regionalRevenue:C2}");

            }
        }
    }
}