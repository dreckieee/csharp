public record CreateExpenseRequest
{
    public decimal Amount {get; set;}
    public DateTime Date {get; set;}
}