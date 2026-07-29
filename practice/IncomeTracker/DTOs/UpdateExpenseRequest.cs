public record UpdateExpenseRequest
{
    public decimal Amount {get; set;}
    public DateTime Date {get; set;}
}