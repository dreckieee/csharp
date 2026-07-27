public class Sale
{
    public int Id {get; private set;}
    public decimal Amount {get; private set;}
    public DateTime Date {get; private set;}
    public Sale (decimal amount, DateTime date)
    {
        GuardSale(amount, date);
        Amount = amount;
        Date = date;
    }
    private void GuardSale(decimal amount, DateTime date)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Amount for a sale cannot be zero(0) or less.", nameof(amount));
        }
        if(date == default)
        {
            throw new ArgumentException("Date of sale must be provided.", nameof(date));
        }
        if(date > DateTime.Now)
        {
            throw new ArgumentException("Date of sale cannot be in the future", nameof(date));
        }
    }
}