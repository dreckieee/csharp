using System;

class Program
{//start of Program Class
    static void Main()
    {//start of Main method
        
        Character hero1 = new Character("dreckieee", 1, 100.0m, 10.0m);
        hero1.DisplayStats();

        Character hero2 = new Character("lynn", 1, 100.0m, 15.0m);
        hero2.DisplayStats();

        hero2.LevelUp();
        hero2.DisplayStats();

        hero2.TakeDamage(14.3m);
        if(hero2.IsAlive())
        {
            Console.WriteLine($"• {hero2.Name} is still alive");
        }
        else 
        {
            Console.WriteLine($"• {hero2.Name} has died");
        }
        hero2.DisplayStats();
    }//end of Main method
}//end of Program Class
