public record IncomeResponse
{
    public decimal TotalSales {get; init;}
    public decimal TotalExpenses {get; init;}
    public decimal NetIncome {get; init;}
    public static IncomeResponse FromTotalSaleAndExpenses(decimal totalSales,decimal totalExpenses) => new()
    {
        TotalSales = totalSales,
        TotalExpenses = totalExpenses,
        NetIncome = totalSales - totalExpenses
    };
}