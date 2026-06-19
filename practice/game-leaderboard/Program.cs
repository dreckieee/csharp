class Program
{
    static void Main ()
    {
        var rng = new Random();
        var players = new List<Player>();
        
        var usernames = new List<string> {"dreckieee", "sexycurves", "zergeiii", "liyummy", "dosing", "tattee", "wantot"};
        var scores = new List<int> {rng.Next(0,50000), rng.Next(0,50000), rng.Next(0,50000), rng.Next(0,50000), rng.Next(0,50000), rng.Next(0,50000), rng.Next(0,50000)};
        var wins = new List<int> {rng.Next(0,101), rng.Next(0,101), rng.Next(0,101), rng.Next(0,101), rng.Next(0,101), rng.Next(0,101), rng.Next(0,101)};
        var playTimes = new List<double> {rng.NextDouble() * 100, rng.NextDouble() * 100, rng.NextDouble() * 100, rng.NextDouble() * 100, rng.NextDouble() * 100, rng.NextDouble() * 100, rng.NextDouble() * 100};

        for (int x = 0; x < usernames.Count; x++)
        {
            var player = new Player(usernames[x], scores[x], wins[x], playTimes[x]);
            players.Add(player);
        }


        //displaying all players (for visualization and evaluation if code works)
        Console.WriteLine("> Displaying all players...");
        for (int x = 0; x < players.Count; x++)
        {
            Console.WriteLine($"\nPlayer #{x+1}");
            DisplayPlayerInfo(players[x]);
        }


        //displaying by descending order based on score
        Console.WriteLine("\n> Displaying leaderboard [username (score)]...");
        List<Player> filterDescending = players.OrderByDescending(p => p.Score).ToList();
        for (int x = 0; x < filterDescending.Count; x++)
        {
            Console.WriteLine($"{x+1} ".PadRight(3) + $"-- {filterDescending[x].Username} ({filterDescending[x].Score:N0})");
        }


        //displaying top 3 players
        Console.WriteLine("\n> Displaying top 3 players [username (score)]...");
        List<Player> filterTop3 = players.OrderByDescending(p => p.Score).Take(3).ToList();
        for (int x = 0; x < filterTop3.Count; x++)
        {
            Console.WriteLine($"{x+1} ".PadRight(3) + $"-- {filterTop3[x].Username} ({filterTop3[x].Score:N0})");
        }


        //displaying highest scorer
        Console.WriteLine("\n> Displaying top player...");
        Player topPlayer = players.MaxBy(p => p.Score)!;
        DisplayPlayerInfo(topPlayer);


        //displaying least scorer
        Console.WriteLine("\n> Displaying bottom player...");
        Player bottomPlayer = players.MinBy(p => p.Score)!;
        DisplayPlayerInfo(bottomPlayer);


        //displaying average
        Console.WriteLine("\n> Displaying average score of all players...");
        double average = players.Average(p => p.Score);
        Console.WriteLine($"Average: {average:N2}");


        //displaying players with over 20 hrs playtime
        Console.WriteLine("\n> Displaying players with over 20hrs of playtime [username (playtime)]...");
        List<Player> filterPlayTime = players.FindAll(p => p.PlayTime > 20);
        for (int x = 0; x < filterPlayTime.Count; x++)
        {
            Console.WriteLine($"{x+1} ".PadRight(3) + $"-- {filterPlayTime[x].Username} ({filterPlayTime[x].PlayTime:F2} hrs)");
        }
        

        //displaying players with over 5 wins
        Console.WriteLine("\n> Displaying players with over 5 wins [username (wins)]...");
        List<Player> filterWins = players.FindAll(p => p.Wins > 5);
        for (int x = 0; x < filterWins.Count; x++)
        {
            Console.WriteLine($"{x+1} ".PadRight(3) + $"-- {filterWins[x].Username} ({filterWins[x].Wins})");
        }
    }//end of Main method

    static void DisplayPlayerInfo (Player p)
    {
        Console.WriteLine("Username: ".PadRight(12) + $"{p.Username}");
        Console.WriteLine("Score: ".PadRight(12) + $"{p.Score:N0}");
        Console.WriteLine("Wins: ".PadRight(12) + $"{p.Wins}");
        Console.WriteLine("Playtime: ".PadRight(12) + $"{p.PlayTime:F2} hr/s");
    }
}//end of Program class