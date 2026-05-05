using System;


class Program
{

    public static List <Movie> watchlist = new List<Movie>();
    static void Main()
    {
        
        string menu = "\n=================== MOVIE WATCHLIST ===================\n1 -- Add a movie (title, genre, rating 1-10)\n2 -- Mark a movie as watched\n3 -- Display all movies\n4 -- Display only unwatched movies\n5 -- Display top rated movies (rating >= 8)\n6 -- End program\n(refer to the options above)\n\n";
        string menuPrompt = "Enter a command: ";
        while(true)
        {
            Console.Write(menu);
            int command = ReadInt(menuPrompt,1,6);
        
            if(command == 1)
            {
                AddMovie();
            }
            else if (command == 2)
            {
                MarkWatched();
            }
            else if (command == 3)
            {
                DisplayMovies();
            }
            else if (command == 4)
            {
                DisplayUnwatchedMovies();
            }
            else if (command == 5)
            {
                DisplayTopRatedMovies();
            }
            else if (command == 6)
            {
                Console.WriteLine("\nEnding program..\n");
                break;
            }
        }
    }//end of Main method



    public static void AddMovie()
    {
            Console.WriteLine("Enter the following information: ");
            Movie newMovie = new Movie(ReadString("Title: "),ReadString("Genre: "),ReadDecimal("Rating: ",0,10), YesOrNo("Have you watched it? (Y/N): "));
            watchlist.Add(newMovie);
            Console.WriteLine("You have successfully added a movie to the watchlist!\n");
    }//end of AddMovie method

    public static void MarkWatched()
    {
            if (watchlist.Count == 0)
            {
                Console.WriteLine("\nThere are no movies in the Watchlist, Add a movie first.\n");
            }
            else
            {
                string input = ReadString("Enter the title of the movie you want to mark as WATCHED: ");
                Movie? found = watchlist.Find(f => f.Title == input);           
                if (found == null)
                {
                    Console.WriteLine("Movie title not found.");
                }
                else 
                {
                    if(found.IsWatched)
                    {
                        Console.WriteLine("It is already marked as Watched");
                    } 
                    else
                    {
                        found.IsWatched = true;
                        Console.WriteLine($"You have successfully marked {input} as WATCHED!");
                    }  
                }                
            }   
    }//end of MarkWatched method



    public static void DisplayMovies()
    {
        if (watchlist.Count == 0)
        {
            Console.WriteLine("\nThere are no movies in the Watchlist, Add a movie first.\n");
        }

        else
        {
            Console.WriteLine("Displaying Movies in the Watchlist.. ");        
            int count = 1;
            foreach (Movie m in watchlist)
            {
                Console.Write($"\nMovie#{count}:\nTitle: {m.Title}\nGenre: {m.Genre}\nRating: {m.Rating}\nStatus: ");
                if(m.IsWatched){Console.WriteLine("Watched\n");}
                else {Console.WriteLine("Unwatched\n");}
                count ++;
            }            
        }
    }//end of DisplayMovies method


    public static void DisplayUnwatchedMovies()
    {
        if (watchlist.Count == 0)
        {
            Console.WriteLine("\nThere are no movies in the Watchlist, Add a movie first.\n");
        }

        else
        {
            List<Movie> unwatched = watchlist.FindAll(m => !m.IsWatched);
            if(unwatched.Count == 0)
            {
                Console.WriteLine("You have watched all the movies in list!");
            }
            else
            {
                int count = 1;
                Console.WriteLine("Displaying Unwatched Movies in the Watchlist.. ");  
                foreach (Movie mm in unwatched)
                {
                    Console.WriteLine($"\nMovie#{count}:\nTitle: {mm.Title}\nGenre: {mm.Genre}\nRating: {mm.Rating}\nStatus: Unwatched");
                    count ++;
                }

            }
        }
    }//end of DisplayUnwatchedMovies method


    public static void DisplayTopRatedMovies()
    {
        if (watchlist.Count == 0)
        {
            Console.WriteLine("\nThere are no movies in the Watchlist, Add a movie first.\n");
        }

        else
        {
            List<Movie> topRated = watchlist.FindAll(m => m.Rating >= 8);
            if(topRated.Count == 0)
            {
                Console.WriteLine("There are no movies with a rating of 8 or above in your list!");
            }
            else
            {
                int count = 1;
                Console.WriteLine("Displaying Top Rated Movies in the Watchlist.. ");  
                foreach (Movie mm in topRated)
                {
                    Console.Write($"\nMovie#{count}:\nTitle: {mm.Title}\nGenre: {mm.Genre}\nRating: {mm.Rating}\nStatus: ");
                    if(mm.IsWatched){Console.WriteLine("Watched\n");}
                    else {Console.WriteLine("Unwatched\n");}
                    count ++;
                }
            }    
        }
    }//end of DisplayTopRatedMovies method




    public static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Must be between {min} and {max}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }//end ReadInt method


    public static decimal ReadDecimal(string prompt, decimal min, decimal max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Must be between {min} and {max}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter a decimal number. Try again.");
            }
        }
    }//end of ReadDecimal method


    public static string ReadString(string prompt)
    {
        while(true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be empty. Try again.");
            }
            else
            {
                return input;
            }
        }
    }//end of ReadString method


    public static bool YesOrNo (string prompt)
    {
        while(true)
        {
            Console.Write(prompt);
            string? yesOrNo = Console.ReadLine();
            if(string.IsNullOrWhiteSpace ( yesOrNo ) )
            {
                Console.WriteLine("Cannot be empty. Try again.");
            }
            else if (yesOrNo == "Y") {return true;}
            else if (yesOrNo == "N") {return false;}
            else {Console.WriteLine("Invalid. Enter Y or N only.");}
        }
    }//end of IsBool method


}//end of Program class
