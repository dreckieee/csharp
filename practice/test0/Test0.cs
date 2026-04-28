using System;
using System.ComponentModel.DataAnnotations;

class Test0
{
    static void Main()
    {
        decimal x = 0m;
        bool valid = false;
        decimal min = 0m;
        decimal max = 0m;
        while(!valid)
        {
            Console.Write("Input a number: ");
            string input = Console.ReadLine();
            if(!decimal.TryParse(input,out x))
            {
                Console.WriteLine("Invalid input, not a number.");
                continue;
            }
            if(x < min || x > max)
            {
                Console.WriteLine("Invalid input, exceeds the limit.");
                continue;
            }
            valid = true;
        }
    }
}


