namespace LibraryApi;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int CopiesAvailable { get; private set; }

    public Book(string title, string author, int copiesAvailable)
    {
        GuardBook(title, author, copiesAvailable);
        Title = TrimText(title);
        Author = TrimText(author);
        CopiesAvailable = copiesAvailable;
    }

    private static void GuardBook(string title, string author, int copiesAvailable)
    {
        if (title == null)
        {
            throw new ArgumentNullException(nameof(title), "Title of book is not provided");
        }
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title of book cannot be empty or whitespace", nameof(title));
        }

        if (author == null)
        {
            throw new ArgumentNullException(nameof(author), "Author of book is not provided");
        }
        if (string.IsNullOrWhiteSpace(author))
        {
            throw new ArgumentException("Author of book cannot be empty or whitespace", nameof(author));
        }

        if (copiesAvailable < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(copiesAvailable), "Copies available cannot be negative");
        }
    }

    private static string TrimText(string text)
    {
        return text.Trim();
    }
}