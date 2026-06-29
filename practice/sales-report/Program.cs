class Program
{
    static void Main ()
    {
        var sales = new List<Sale>
        {
            new Sale ("Cabinet", "Asia", 4000D),
            new Sale ("Driller", "Europe", 6500D),
            new Sale ("Door Hinges", "USA", 300D),
            new Sale ("Nails", "Asia", 50.5),
            new Sale ("Wood Glue", "Asia", 129.99)
        };

        SalesAnalyzer.PrintReport(sales);
        sales.Add(new Sale ("Dowel" , "USA", 24.99));
        sales.Add(new Sale ("Wood Doors" , "Europe", 8100D));
        sales.Add(new Sale ("Door Handles" , "Europe", 454.99));
        SalesAnalyzer.PrintReport(sales);

    }
}