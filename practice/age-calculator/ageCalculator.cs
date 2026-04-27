using System;

class dreckieeeAgeCalculator
{//start of class Program
    static void Main()
    {//start of Main()
        //saka na yung string regex para sa input ng birthdate basta input accepts all int numbers and will have format errors accepting letters
        Console.WriteLine("Enter dreckieee's birthdate: ");
        Console.WriteLine("Month (enter only from 1-12): ");
        int birthMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Day (enter only from 1-31): ");
        int birthDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Year (enter only from 1-2026): ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered: "+birthMonth+"/"+birthDay+"/"+birthYear); 

        int currentMonth = DateTime.Today.Month;
        int currentDay = DateTime.Today.Day;
        int currentYear = DateTime.Today.Year;

        //To calculate age
        int currentAge = currentYear-birthYear;
        if(birthMonth>currentMonth)
        {currentAge = currentAge-1;
            }
        else if(birthMonth==currentMonth && birthDay>currentDay)
        {currentAge = currentAge-1;
            }

        Console.WriteLine("\nDreckieee should be "+currentAge+" years old today"+" ("+currentMonth+"/"+currentDay+"/"+currentYear+").");
        Console.WriteLine("Tama ka jan! Tanda ko na wahaha\n");      
    }//end of Main()
}//end of class Program


