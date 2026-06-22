public class Dvd : ILendable
{
    public string Title {get; private set;}
    public int DurationInMinutes {get; private set;}
    public bool IsCheckedOut {get; private set;} = false;
    public Dvd (string title, int durationInMinutes)
    {
        Title = title;
        DurationInMinutes = durationInMinutes;
    }
    public bool CheckOut ()
    {
        if (IsCheckedOut)
        {
            return false;
        }
        else
        {
            IsCheckedOut = true;
            return true;
        }
    }
    public bool ReturnItem ()
    {
        if (IsCheckedOut)
        {
            IsCheckedOut = false;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void GetDetails ()
    {
        Console.WriteLine("Title: ".PadRight(10) + $"{Title}");
        Console.WriteLine("Duration: ".PadRight(10) + $"{DurationInMinutes} mins");
        Console.Write("Status: ".PadRight(10));
        if (IsCheckedOut) 
        {
            Console.WriteLine("Dvd is not available.");
        }
        else
        {
            Console.WriteLine("Dvd is available");
        }

    }
}