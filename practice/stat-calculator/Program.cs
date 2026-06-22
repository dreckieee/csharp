class Program
{
    static void Main ()
    {
        var calculator = new StatCalculator();
        Console.WriteLine("> Calculating sum of 2 ints (983 & 721)");
        int sumInt = calculator.Calculate(983, 721);
        Console.WriteLine($"Result -- {sumInt:n0}\n");

        Console.WriteLine("> Calculating sum of 2 doubles (983.921 & 721.456)");
        double sumDouble = calculator.Calculate(983.921D, 721.456D);
        Console.WriteLine($"Result -- {sumDouble:N2}\n");

        Console.WriteLine("> Calculating average of ints (389, 4390, 109, 439)");
        var ints = new int[] {389, 4390, 109, 439};
        double averageInts = calculator.Calculate(ints);
        Console.WriteLine($"Result -- {averageInts:N2}\n");
    }//end of Main method
}//end of Program class