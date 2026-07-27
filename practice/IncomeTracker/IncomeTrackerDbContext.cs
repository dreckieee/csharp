using Microsoft.EntityFrameworkCore;

public class IncomeTrackerDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; private set; }
    public DbSet<Sale> Sales { get; private set; }
    public IncomeTrackerDbContext (DbContextOptions<IncomeTrackerDbContext> options) : base(options)
    {
        
    }    
}