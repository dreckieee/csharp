namespace LibraryApi.DTOs;
public class CreateBookRequest
{
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required int CopiesAvailable { get; set; }
}