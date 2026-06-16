class Program
{
    static void Main ()
    {
        var exceptions = new List<Exception>();
        var database = new List<string>();
        string username = "dreckieee";
        database.Add(username);
        username = "dreckieee";
        database.Add(username);
        username = "zergeibiik";
        database.Add(username);
        username = "dd";
        database.Add(username);
        username = "  ";
        database.Add(username);
        username = "dreckrichardjpascual";
        database.Add(username);
        username = "drjpas cual";
        database.Add(username);
        username = "09177777";
        database.Add(username);
        username = "dreckrichard j pascual";
        database.Add(username);

        Console.WriteLine("\n> Checking usernames in database...");
        foreach (string s in database)
        {
            //check username length
            try
            {
                UsernameValidator.UsernameLengthValidator(s);
            }
            catch (InvalidUsernameException ex)
            {
                exceptions.Add(ex);
            }

            //check username for whitespace
            try
            {
                UsernameValidator.UsernameCharacterValidator(s);
            }
            catch (InvalidUsernameException ex)
            {
                exceptions.Add(ex);
            }
        }

        if (exceptions.Count > 0)
        {
            Console.WriteLine("Invalid usernames detected!");
            Console.WriteLine("\n> Displaying invalid usernames...");
            try
            {
                throw new AggregateException(exceptions);
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    Console.WriteLine($" ---- " + ex.Message);

                }
            }
        }
    }//end of Main method
}//end of Program class