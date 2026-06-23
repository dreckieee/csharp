class Program
{
    static void Main ()
    {
        //initializing first variables
        var sampleStruct = new PointStruct (5, 11);
        var sampleClass = new PointClass(6, 12);

        //displaying first variables
        Console.WriteLine("\n> Displaying First PointStruct variable and First PointClass variable...");
        Console.WriteLine($"First Struct -- {sampleStruct.X} & {sampleStruct.Y}");
        Console.WriteLine($"First Class -- {sampleClass.X} & {sampleClass.Y}");

        //assigning first variables to second variables
        var mutateStruct = sampleStruct;
        var mutateClass = sampleClass;

        //displaying all variables after assignment to second variables
        Console.WriteLine("\n> Displaying all variables after assignment to second variables...");
        Console.WriteLine($"First Struct -- {sampleStruct.X} & {sampleStruct.Y}");
        Console.WriteLine($"First Class -- {sampleClass.X} & {sampleClass.Y}");
        Console.WriteLine($"Second Struct -- {mutateStruct.X} & {mutateStruct.Y}");
        Console.WriteLine($"Second Class -- {mutateClass.X} & {mutateClass.Y}");

        //mutating second variables
        mutateStruct.X = 88;
        mutateStruct.Y = 98;

        mutateClass.X = 58;
        mutateClass.Y = 68;

        //displaying all variables after mutation of second variables
        Console.WriteLine("\n> Displaying all variables after mutation of second variables...");
        Console.WriteLine($"First Struct -- {sampleStruct.X} & {sampleStruct.Y}");
        Console.WriteLine($"First Class -- {sampleClass.X} & {sampleClass.Y}");
        Console.WriteLine($"Second Struct -- {mutateStruct.X} & {mutateStruct.Y}");
        Console.WriteLine($"Second Class -- {mutateClass.X} & {mutateClass.Y}");



    }//end of Main method
}//end of Program class