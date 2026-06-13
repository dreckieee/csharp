using System;

class Program
{
    static void Main ()
    {
        var errorLogs = new List<string>();
        var fileLines = new List<string>();
        fileLines.Add("Welcome,");
        fileLines.Add("dreckieee!");
        fileLines.Add("Today is Day 51!");
        fileLines.Add("");
        fileLines.Add("Coding file-reader-simulator");
        fileLines.Add("everything is going well.");
        fileLines.Add("");

        int count = 1;
        Console.WriteLine("\n> Printing File Lines...");
        foreach (string s in fileLines)
        {
            Console.WriteLine($"Line#{count} -- \"{s}\"");
            count ++;
        }


        try
        {
            Console.WriteLine("\n> Checking File Lines...");
            CheckFileLines(fileLines, errorLogs);
        }
        catch (InvalidLineException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            if (errorLogs.Count > 0)
            {
                Console.WriteLine("\n> Printing Error Logs...");
                count = 1;
                foreach (string s in errorLogs)
                {
                    Console.WriteLine($"Error#{count} -- {s}");
                    count ++;
                }
            }
            Console.WriteLine("\n> Checking finished!\n");
        }



    }//end of Main method

    static void CheckFileLines (List<string> fileLines, List<string> errorLogs)
    {
        int count = 1;
        foreach (string s in fileLines)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new InvalidLineException($"Invalid Line Detected! Line#{count} is empty.");
                }
            }
            catch (InvalidLineException ex)
            {
                errorLogs.Add(ex.Message);
            }
            count++;
        }
        if (errorLogs.Count > 0)
        {
            throw new InvalidLineException($"{errorLogs.Count} invalid line(s) detected.");
        }
    }
}//end of Program class