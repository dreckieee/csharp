namespace LibraryApi.DTOs;
public record BookResponse
{
    public required int Id { get; init;}
    public required string Title { get; init; }
    public required string Author { get; init; }
    public required int CopiesAvailable { get; init; }
    public static BookResponse FromBook(Book book) => new()
    {
        Id = book.Id,
        Title = book.Title,
        Author = book.Author,
        CopiesAvailable = book.CopiesAvailable 
    };
}