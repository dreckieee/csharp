using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace IncomeTracker.Tests;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    private readonly SqliteConnection _connection = new("Data Source=:memory:");
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {

            var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<IncomeTrackerDbContext>));
            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            _connection.Open();

            services.AddDbContext<IncomeTrackerDbContext>(options => {options.UseSqlite(_connection);});

            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<IncomeTrackerDbContext>();
                db.Database.EnsureCreated();
            }
        });
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _connection.Dispose();
        }
        base.Dispose(disposing);
    }
}

