class Program
{
    static void Main ()
    {
        Console.WriteLine("\nGAME CONFIGURATION:");
        Console.WriteLine($"• Tax Rate: {GameConfig.TaxRate}");
        Console.WriteLine($"• Max Party Size: {GameConfig.MaxPartySize}");
        Console.WriteLine("\n> Creating players...");

        var player1 = new Player ("Dreck");
        Console.WriteLine("Successfully created player1!");
        Console.WriteLine("Name: ".PadRight(12) + $"{player1.Name}");
        Console.WriteLine("Level: ".PadRight(12) + $"{player1.Level}");
        Console.WriteLine("ID: ".PadRight(12) + $"{player1.Id}");
        Console.WriteLine("Created At: ".PadRight(12) + $"{player1.CreatedAt:yyyy-MM-dd HH:mm:ss.fff}");
        Console.WriteLine();

        var player2 = new Player ("Lynn");
        Console.WriteLine("Successfully created player2!");
        Console.WriteLine("Name: ".PadRight(12) + $"{player2.Name}");
        Console.WriteLine("Level: ".PadRight(12) + $"{player2.Level}");
        Console.WriteLine("ID: ".PadRight(12) + $"{player2.Id}");
        Console.WriteLine("Created At: ".PadRight(12) + $"{player2.CreatedAt:yyyy-MM-dd HH:mm:ss.fff}");
        Console.WriteLine();
    }
}