using System;

class NumberAnalyzer
{//start of class
    static void Main(){//start of main
    Console.WriteLine("==============================================");
        Console.WriteLine("               NUMBER ANALYZER");
        Console.WriteLine("==============================================");

        //used a method which uses while loop for checking user input on how many numbers to analyze
        string prompt = "Enter how many numbers you want to analyze: ";
        int x = ReadInt(prompt,0);

        //initializing the array "arrNum"
        decimal[] arrNum = new decimal[x];
        for(int i = 0;i<x;i++)
        {
            arrNum[i] = ReadDecimal($"Enter Number {i+1}: ");
            //Console.Write($"Enter Number {i+1}: ");
            //decimal.TryParse(Console.ReadLine(), out arrNum[i]);
        }

        //used methods to determine the sum, average, highest, lowest, and if it is above 50 or below
        Console.WriteLine($"\nThe SUM of all the numbers is: \t\t{Math.Round(Add(arrNum),2)}");
        Console.WriteLine($"The AVERAGE of all the numbers is: \t{Average(arrNum)}");
        Console.WriteLine($"The HIGHEST number is : \t\t{Math.Round(Highest(arrNum),2)}");
        Console.WriteLine($"The LOWEST number is : \t\t\t{Math.Round(Lowest(arrNum),2)}");
        Console.WriteLine($"The average number compared to 50 is: \t{Fifty(Average(arrNum))}");
        Console.WriteLine("==============================================\n");
    }//end of main

    //method for sum of values inside an array "Add"
    static decimal Add(decimal[] a)
    {
        decimal x = 0;
        for(int i = 0;i<a.Length;i++)
        {
            x = x+a[i];
        }
        return x;
    }

    //method for average of values inside an array "Average"
    static decimal Average(decimal[] a)
    {
        decimal x = Add(a) / a.Length;
        x = Math.Round(x,2);
        return x;
    }

    //method for searching for the highest value inside an array "Highest"
    static decimal Highest(decimal[] a)
    {
        decimal x = a[0];
        for(int i = 0;i<a.Length;i++)
        {
            if(a[i]>x)
            {
                x = a[i];             
            }
        }
        return x;
    }

    //method for searching for the lowest value inside an array "Lowest"
    static decimal Lowest(decimal[] a)
    {
        decimal x = a[0];
        for(int i = 0;i<a.Length;i++)
        {
            if(a[i]<x)
            {
                x = a[i];             
            }
        }
        return x;
    }

    //method for validating if a decimal is below or above 50 "Fifty"
    static string Fifty(decimal a)
    {
        string x = "Empty";
            if(a>50){x = "ABOVE";}
            else if(a<50){x = "BELOW";}
            else if(a==50){x = "EXACTLY";}
        return x;
    }//end of "Fifty" method

    //method for validating user input as a positive integer "ReadInt"
    static int ReadInt(string prompt, int min)
    {
    int result = 0;
    bool valid = false;

        while (!valid)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid. No input provided.");
                continue;
            }
            if (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid. Enter a positive integer.");
                continue;
            }

            if (result < min)
            {
                Console.WriteLine("Invalid. Enter a positive integer");
                continue;
            }
            valid = true;
        }
    return result;
    }//end of "ReadInt" method

    //method for validating user input as a decimal "ReadDecimal"
    static decimal ReadDecimal(string prompt)
    {
    decimal result = 0m;
    bool valid = false;

        while (!valid)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid. No input provided.");
                continue;
            }
            if (!decimal.TryParse(input, out result))
            {
                Console.WriteLine("Invalid. Enter a decimal or integer number.");
                continue;
            }
            valid = true;
        }
    return result;
    }//end of "ReadDecimal" method
}//end of class
