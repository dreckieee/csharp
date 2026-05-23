using System;

class Program
{
    static void Main()
    {
        Console.Write("\nHello, ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Dreckieee");
        Console.ResetColor();
        Console.WriteLine("!");

        
        
    }//end of Main method


    public static string ReadString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be empty. Try again.");
            }
            else
            {
                return input;
            }
        }
    }//end of ReadString method


}//end of Program method