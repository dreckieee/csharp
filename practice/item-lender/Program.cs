class Program
{
    static void Main ()
    {
        var lendables = new List<ILendable>();
        lendables.Add (new Book ("Game of Thrones"));
        lendables.Add (new Book ("Noli me Tangere"));
        lendables.Add (new Dvd ("Avengers", 180));
        lendables.Add (new Dvd ("Conjuring", 130));

        //check out a book
        Console.WriteLine("> Checking out a book...");
        if (lendables[0].CheckOut())
        {
            Console.WriteLine("Successfully checked out!");
        }
        else
        {
            Console.WriteLine($"Book is still checked out!");
        }
        Console.WriteLine();

        //check out same book
        Console.WriteLine("> Checking out the same book...");
        if (lendables[0].CheckOut())
        {
            Console.WriteLine("Successfully checked out!");
        }
        else
        {
            Console.WriteLine($"Book is still checked out!");
        }
        Console.WriteLine();

        //return a book
        Console.WriteLine("> Returning a book...");
        if (lendables[0].ReturnItem())
        {
            Console.WriteLine("Successfully returned a book!");
        }
        else
        {
            Console.WriteLine($"Book is already returned!");
        }
        Console.WriteLine();


        //get details on everything
        Console.WriteLine("> Displaying everything...");
        for (int x = 0; x < lendables.Count; x++)
        {
            Console.WriteLine($"{x+1}");
            lendables[x].GetDetails();
            Console.WriteLine();
        }

    }//end of Main method
}//end of Program class