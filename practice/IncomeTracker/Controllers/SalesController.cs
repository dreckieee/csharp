using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("api/[controller]")]
public class SalesController : ControllerBase
{
    private readonly IncomeTrackerDbContext _context;
    public SalesController (IncomeTrackerDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task <ActionResult<IEnumerable<SaleResponse>>> GetSales()
    {
        var sales = await _context.Sales.ToListAsync();
        var saleResponses = sales.Select(sale => SaleResponse.FromSale(sale)).ToList();
        return Ok(saleResponses);
    }
    [HttpGet("{id}")]
    public async Task <ActionResult<SaleResponse>> GetSale(int id)
    {
        var sale = await _context.Sales.FindAsync(id);
        if(sale == null)
        {
            return NotFound();
        }
        var saleResponse = SaleResponse.FromSale(sale);
        
        return Ok(saleResponse);
    }
    [HttpPost]
    public async Task<ActionResult<SaleResponse>> CreateSale([FromBody] CreateSaleRequest request)
    {
        var sale = new Sale(request.Amount, request.Date);
        _context.Sales.Add(sale);
        await _context.SaveChangesAsync();

        var saleResponse = SaleResponse.FromSale(sale);
        return CreatedAtAction(nameof(GetSale), new {id = sale.Id}, saleResponse);
    }
}