using System;
using System.Collections.Concurrent;

class Movie
{
    public Movie (string title, string genre, decimal rating, bool isWatched)
    {
        Title = title;
        Genre = genre;
        Rating = rating;
        IsWatched = isWatched;
    }

    public string? Title {get; set;}
    public string? Genre {get; set;}
    public decimal Rating {get; set;}
    public bool IsWatched {get; set;}
}