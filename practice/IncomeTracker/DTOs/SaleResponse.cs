public record SaleResponse
{
    public int Id {get; init;}
    public decimal Amount {get; init;}
    public DateTime Date {get; init;}
    public static SaleResponse FromSale(Sale sale) => new()
    {
        Id = sale.Id,
        Amount = sale.Amount,
        Date = sale.Date
    };
}