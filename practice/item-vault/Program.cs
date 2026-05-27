class Program
{
    static void Main()
    {
        Console.WriteLine();
        var vaultW = new Vault <Weapon>();
        var vaultP = new Vault <Potion>();
        var vaultC = new Vault <Currency>();

        var weapon1 = new Weapon("Iron Sword", WeaponType.Sword);
        var weapon2 = new Weapon("Mythril Bow", WeaponType.Bow);
        var weapon3 = new Weapon("Platinum Axe", WeaponType.Axe);

        var potion1 = new Potion("HP Potion", "+50 HP");
        var potion2 = new Potion("MP Potion", "+50 MP");
        var potion3 = new Potion("SP Potion", "+50 SP");

        var currency1 = new Currency("Gold", 100);
        var currency2 = new Currency("Credits", 100);
        var currency3 = new Currency("Money", 100);

        Console.WriteLine("> Add Iron Sword in the vault");
        vaultW.Add(weapon1);
        Console.WriteLine("> Add Mythril Bow in the vault");
        vaultW.Add(weapon2);
        Console.WriteLine("> Add Platinum Axe in the vault");
        vaultW.Add(weapon3);

        Console.WriteLine("> Add HP Potion in the vault");
        vaultP.Add(potion1);
        Console.WriteLine("> Add MP Potion in the vault");
        vaultP.Add(potion2);
        Console.WriteLine("> Add SP Potion in the vault");
        vaultP.Add(potion3);

        Console.WriteLine("> Add 100 Gold in the vault");
        vaultC.Add(currency1);
        Console.WriteLine("> Add 100 Credits in the vault");
        vaultC.Add(currency2);
        Console.WriteLine("> Add 100 Money in the vault");
        vaultC.Add(currency3);

        Console.WriteLine("> Remove Mythril Bow in the vault");
        vaultW.Remove(weapon2);
        Console.WriteLine("> Remove SP Potion in the vault");
        vaultP.Remove(potion3);
        Console.WriteLine("> Remove 100 Gold in the vault");
        vaultC.Remove(currency1);


        Console.WriteLine("> Find Iron Sword in the vault");
        Weapon? weapon4 = vaultW.Find(x => x.Name == "Iron Sword");
        if (weapon4 != null) 
        {
            Console.WriteLine("Successful Search!");
        }
        else {Console.WriteLine("Unsuccessful Search.");}


        Console.WriteLine("\n> Find Mythril Sword in the vault");
        Weapon? weapon5 = vaultW.Find(x => x.Name == "Mythril Sword");
        if (weapon5 != null) 
        {
            Console.WriteLine("Successful Search!");
        }
        else {Console.WriteLine("Unsuccessful Search.");}
        


        Console.WriteLine("\n> Find HP Potion in the vault");
        Potion? potion4 = vaultP.Find(x => x.Name == "HP Potion");
        if (potion4 != null) 
        {
            Console.WriteLine("Successful Search!");
        }
        else {Console.WriteLine("Unsuccessful Search.");}


        Console.WriteLine("\n> Find Elixir in the vault");
        Potion? potion5 = vaultP.Find(x => x.Name == "Elixir");
        if (potion5 != null) 
        {
            Console.WriteLine("Successful Search!");
        }
        else {Console.WriteLine("Unsuccessful Search.");}


        Console.WriteLine("\n> Find Credits in the vault");
        Currency? currency4 = vaultC.Find(x => x.Name == "Credits");
        if (currency4 != null) 
        {
            Console.WriteLine("Successful Search!");
        }
        else {Console.WriteLine("Unsuccessful Search.");}


        Console.WriteLine("\n> Find Honor in the vault");
        Currency? currency5 = vaultC.Find(x => x.Name == "Honor");
        if (currency5 != null) 
        {
            Console.WriteLine("Successful Search!");
        }
        else {Console.WriteLine("Unsuccessful Search.");}

        Console.WriteLine("\nListing Vaults...");
        Console.WriteLine("> Weapon Vault:\n");
        vaultW.ListAll();
        Console.WriteLine("> Potion Vault:\n");
        vaultP.ListAll();
        Console.WriteLine("> Currency Vault:\n");
        vaultC.ListAll();
        

    }//end of Main method



}//end of Program class