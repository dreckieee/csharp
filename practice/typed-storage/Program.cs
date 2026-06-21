class Program
{
    static void Main ()
    {
        var stringStorage = new TypedStorage<string>();
        var playerStorage = new TypedStorage<Player>();
        var productStorage = new TypedStorage<Product>();

        //Add() for strings
        stringStorage.Add("string number 1");
        stringStorage.Add("2nd string");
        stringStorage.Add("the third and last string");


        //Add() for players
        playerStorage.Add(new Player("dreckieee", 10000, 10, 1D));
        playerStorage.Add(new Player ("zergeiii", 20000, 20, 2D));
        playerStorage.Add(new Player ("sexycurves", 30000, 30, 3D));


        //Add() for products
        productStorage.Add(new Product ("Shampoo", 99m));
        productStorage.Add(new Product ("Soap", 89m));
        productStorage.Add(new Product ("Conditioner", 109m));

        
        //GetAll() for strings
        List<string> newStringStorage = stringStorage.GetAll();
        if (newStringStorage.Count == 0)
        {
            Console.WriteLine("String Storage is empty.");
        }
        else
        {
            Console.WriteLine("> Displaying string storage...");
            for (int x = 0; x < newStringStorage.Count; x++)
            {
                Console.WriteLine($"{x+1} -- {newStringStorage[x]}");
            }
        }
        Console.WriteLine();


        //Remove() for strings
        string? findString = stringStorage.Get(s => s == "string number 1");
        if (findString == null)
        {
            Console.WriteLine("There is no \"string number 1\" string in the storage");
        }
        else
        {
            stringStorage.Remove(findString);
            newStringStorage = stringStorage.GetAll();
            if (newStringStorage.Count == 0)
            {
                Console.WriteLine("String Storage is empty.");
            }
            else
            {
                Console.WriteLine("> Displaying string storage after removal...");
                for (int x = 0; x < newStringStorage.Count; x++)
                {
                    Console.WriteLine($"{x+1} -- {newStringStorage[x]}");
                }
            }
        }
        Console.WriteLine();


        //GetAll() for players
        List<Player> newPlayerStorage = playerStorage.GetAll();
        if (newPlayerStorage.Count == 0)
        {
            Console.WriteLine("Player Storage is empty.");
        }
        else
        {
            Console.WriteLine("> Displaying player storage (usernames)...");
            for (int x = 0; x < newPlayerStorage.Count; x++)
            {
                Console.WriteLine($"{x+1} -- {newPlayerStorage[x].Username}");
            }
        }
        Console.WriteLine();


        //Remove() for players
        Player? findPlayer = playerStorage.Get(p => p.Username == "sexycurves");
        if (findPlayer == null)
        {
            Console.WriteLine("No player with the username \"sexycurves\" in storage.");
        }
        else
        {
            playerStorage.Remove(findPlayer);
            newPlayerStorage = playerStorage.GetAll();
            if (newPlayerStorage.Count == 0)
            {
                Console.WriteLine("Player Storage is empty.");
            }
            else
            {
                Console.WriteLine("> Displaying player storage after removal...");
                for (int x = 0; x < newPlayerStorage.Count; x++)
                {
                    Console.WriteLine($"{x+1} -- {newPlayerStorage[x].Username}");
                }
            }
        }
        Console.WriteLine();


        //GetAll() for products
        List<Product> newProductStorage = productStorage.GetAll();
        if (newProductStorage.Count == 0)
        {
            Console.WriteLine("Product Storage is empty.");
        }
        else
        {
            Console.WriteLine("> Displaying product storage (product names)...");
            for (int x = 0; x < newProductStorage.Count; x++)
            {
                Console.WriteLine($"{x+1} -- {newProductStorage[x].Name}");
            }
        }
        Console.WriteLine();


        //Remove() for products
        Product? findProduct = productStorage.Get(p => p.Name == "Soap");
        if (findProduct == null)
        {
            Console.WriteLine("No product with the name \"Soap\" in storage.");
        }
        else
        {
            productStorage.Remove(findProduct);
            newProductStorage = productStorage.GetAll();
            if (newProductStorage.Count == 0)
            {
                Console.WriteLine("Product Storage is empty.");
            }
            else
            {
                Console.WriteLine("> Displaying product storage after removal...");
                for (int x = 0; x < newProductStorage.Count; x++)
                {
                    Console.WriteLine($"{x+1} -- {newProductStorage[x].Name}");
                }
            }
        }
        Console.WriteLine();


    }//end of Main method
}//end of Program class