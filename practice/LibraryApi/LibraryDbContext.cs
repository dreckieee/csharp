using Microsoft.EntityFrameworkCore;
namespace LibraryApi;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books {get; private set;}
    public LibraryDbContext (DbContextOptions<LibraryDbContext> options) : base (options){}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}