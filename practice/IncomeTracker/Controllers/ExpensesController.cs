using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ExpensesController : ControllerBase
{
    private readonly IncomeTrackerDbContext _context;
    public ExpensesController(IncomeTrackerDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ExpenseResponse>>> GetExpenses()
    {
        var expenses = await _context.Expenses.ToListAsync();
        var expenseResponses = expenses.Select(expense => ExpenseResponse.FromExpense(expense)).ToList();
        return Ok(expenseResponses);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<ExpenseResponse>> GetExpense(int id)
    {
        var expense = await _context.Expenses.FindAsync(id);
        if (expense == null)
        {
            return NotFound();
        }

        var expenseResponse = ExpenseResponse.FromExpense(expense);
        return Ok(expenseResponse);
    }

    [HttpPost]
    public async Task<ActionResult<ExpenseResponse>> CreateExpense([FromBody] CreateExpenseRequest request)
    {
        var expense = new Expense(request.Amount, request.Date);
        _context.Expenses.Add(expense);
        await _context.SaveChangesAsync();
            
        var expenseResponse = ExpenseResponse.FromExpense(expense);
        return CreatedAtAction(nameof(GetExpense), new {id = expense.Id}, expenseResponse);
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<ExpenseResponse>> UpdateExpense(int id, [FromBody] UpdateExpenseRequest request)
    {
        var expense = await _context.Expenses.FindAsync(id);
        if(expense == null)
        {
            return NotFound();
        }
        
        expense.Update(request.Amount, request.Date);
        await _context.SaveChangesAsync();
        
        var expenseResponse = ExpenseResponse.FromExpense(expense);
        return Ok(expenseResponse);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExpense(int id)
    {
        var expense = await _context.Expenses.FindAsync(id);
        if(expense == null)
        {
            return NotFound();
        }
        _context.Expenses.Remove(expense);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}