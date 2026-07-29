using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class IncomeController : ControllerBase
{
    private readonly IncomeTrackerDbContext _context;
    public IncomeController(IncomeTrackerDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IncomeResponse>> GetNetIncome()
    {
        var totalSales = await _context.Sales.SumAsync(s => s.Amount);
        var totalExpenses = await _context.Sales.SumAsync(e => e.Amount);
        var netIncomeResponse = IncomeResponse.FromTotalSaleAndExpenses(totalSales, totalExpenses);    
        return Ok(netIncomeResponse);
    }
}