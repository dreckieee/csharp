using System;
using System.ComponentModel.DataAnnotations;

class Test0
{
    static void Main()
    {//start of main

        Console.WriteLine("==============================");

        //rolls 3 dice and records their values
        Random dice = new Random();
        int roll1 = dice.Next(1,7);
        int roll2 = dice.Next(1,7);
        int roll3 = dice.Next(1,7);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        //sum all the values to know the score and determine if there is a bonus points
        int total = roll1 + roll2 + roll3;
        if(roll1 == roll2 && roll2 == roll3)
        {
            Console.Write("TRIPLE! +6 to your SCORE!");
            total +=6;
        }
        else if(roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
        {
            Console.Write("\nDOUBLE! +2 to your SCORE!");
            total +=2;
        }

        Console.Write($"\n\nYour SCORE is {total}! ");

        //determine the prize according the the score
        if(total >= 16)
        {
            Console.WriteLine("\nYou WIN a new CAR!");
        }
        else if(total >= 10)
        {
            Console.WriteLine("\nYou WIN a new LAPTOP!");
        }
        else if(total >= 7)
        {
            Console.WriteLine("\nYou WIN a TRIP FOR TWO!");
        }
        else 
        {
            Console.WriteLine("\nYou WIN a new KITTEN!");
        }
        
        Console.WriteLine("==============================");
    
    }//end of main
}


