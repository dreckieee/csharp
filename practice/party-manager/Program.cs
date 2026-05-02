using System;

class Program
{//start of Class Program
    static void Main ()
    {//start of Main Method
        
        Party party1 = new Party();
        party1.AddHero();
        party1.DisplayParty();
        party1.AddHero();
        party1.DisplayParty();

        party1.LevelUpHero();
        party1.DisplayParty();

        party1.DisplayTotalHP();

        party1.RemoveHero();
        party1.DisplayParty();
        Console.WriteLine();




    }//end of Main Method
}//end of Class Program

