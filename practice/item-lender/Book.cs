public class Book : ILendable
{
    public string Title {get; private set;}
    public bool IsCheckedOut {get; private set;} = false;
    public Book (string title)
    {
        Title = title;
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
        Console.Write("Status: ".PadRight(10));
        if (IsCheckedOut) 
        {
            Console.WriteLine("Book is not available.");
        }
        else
        {
            Console.WriteLine("Book is available");
        }

    }
}