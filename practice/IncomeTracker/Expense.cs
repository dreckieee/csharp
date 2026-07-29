public class Expense
{
    public int Id {get; private set;}
    public decimal Amount {get; private set;}
    public DateTime Date {get; private set;}
    public Expense(decimal amount, DateTime date)
    {
        GuardExpense(amount,date);
        Amount = amount;
        Date = date;
    }
    public void Update(decimal amount, DateTime date)
    {
        GuardExpense(amount, date);
        Amount = amount;
        Date = date;
    }
    private void GuardExpense(decimal amount, DateTime date)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Amount for an expense cannot be zero(0) or less.", nameof(amount));
        }
        if(date == default)
        {
            throw new ArgumentException("Date of expense must be provided.", nameof(date));
        }
    }
}