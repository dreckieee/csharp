using System;

class Program
{
    static void Main()
    {
        
        Warrior newWarrior = new Warrior("WARRIOR1", 100m);
        Unit newEnemy = new Enemy("Goblin", 100m);
        Console.WriteLine($"{newEnemy.Name} HP: {newEnemy.HP}");
        //Console.WriteLine("HELLO DRECKIEEJUR");
        newWarrior.Attack(newEnemy);
        Console.WriteLine($"{newEnemy.Name} HP: {newEnemy.HP}");

    }//end of Main method


}//end of Program class
