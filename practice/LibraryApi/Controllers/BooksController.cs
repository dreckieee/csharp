using LibraryApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace LibraryApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly LibraryDbContext _context;
    private readonly ILogger<BooksController> _logger;

    public BooksController(LibraryDbContext context, ILogger<BooksController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BookResponse>> GetBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound(new { message = $"Book with an Id of \"{id}\" was not found." });
        }

        var bookResponse = BookResponse.FromBook(book);
        return Ok(bookResponse);
    }

    [HttpPost]
    public async Task<ActionResult<BookResponse>> CreateBook([FromBody] CreateBookRequest request)
    {
        Book book;
        try
        {
            book = new Book(request.Title, request.Author, request.CopiesAvailable);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }

        _context.Books.Add(book);
        await _context.SaveChangesAsync();

        var bookResponse = BookResponse.FromBook(book);
        return CreatedAtAction(nameof(GetBook), new { id = book.Id }, bookResponse);
    }
}
