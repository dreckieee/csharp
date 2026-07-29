public record ExpenseResponse
{
    public int Id {get; init;}
    public decimal Amount {get; init;}
    public DateTime Date {get; init;}
    public static ExpenseResponse FromExpense(Expense expense) => new()
    {
        Id = expense.Id,
        Amount = expense.Amount,
        Date = expense.Date
    };
}