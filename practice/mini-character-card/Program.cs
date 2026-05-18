using System;


class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║           C H A R A C T E R            ║");
        Console.WriteLine("║                C A R D                 ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.ResetColor();

        string name = ReadString("Enter the NAME of your Character: ").ToUpper().Trim();
        Console.WriteLine($"Generating Character Card for \"{name}\"..\n");
        
        //Header
        string border = DisplayHeader(name);
        
        //Stats
        int [] statsArray = DisplayStatsArray(border);

        //Power Rating
        DisplayPowerRating(statsArray,border);

    }//end of Main method



    public static string DisplayHeader(string name)
    {
        string characterWord = "CHARACTER: ";
        int padding = name.Length + characterWord.Length;
        string border = "";
        for (int i = 0; i < padding * 2; i ++)
        {
            border += "═";
        }
        int middle = Convert.ToInt32((decimal) border.Length / 4);
        Console.WriteLine(border);
        Console.Write($"{characterWord.PadLeft(characterWord.Length+middle)}");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{name}");
        Console.ResetColor();
        Console.WriteLine(border);
        return border;
    }



    public static int [] DisplayStatsArray(string border)
    {
        int [] statsArray = new int [4];
        string [] statsLabel = {"HP","Attack","Defense","Speed"};

        Random rng = new Random();

        for(int s = 0; s < statsArray.Length; s++)
        {
            statsArray[s] = rng.Next(10,100);     
            Console.WriteLine(statsLabel[s].PadRight(15) + $": {statsArray[s]}");
        }
        Console.WriteLine(border);
        return statsArray;
    }//end of DisplayStatsArray method




    public static void DisplayPowerRating(int[] stats, string border)
    {
        decimal powerRating = 0;
        foreach (int s in stats)
        {
            powerRating += s;
        }
        powerRating = powerRating / stats.Length;
        Console.Write("Power Rating".PadRight(15) + $": {powerRating:F2} ");
        if (powerRating < 21) {Console.WriteLine("(Poor)");}
        else if (powerRating < 41) {Console.WriteLine("(Below Average)");}
        else if (powerRating < 61) {Console.WriteLine("(Average)");}
        else if (powerRating < 81) {Console.WriteLine("(Above Average)");}
        else if (powerRating < 101) {Console.WriteLine("(Excellent)");}
        Console.WriteLine(border);
    }//end of DisplayStatsWithoutArray method


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



}//end of Program class