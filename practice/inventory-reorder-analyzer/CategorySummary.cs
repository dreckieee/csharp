public class CategorySummary
{
    public string Category {get; private set;}
    public int TotalStocks {get; private set;}
    public decimal TotalValue {get; private set;}
    public int LowStockItems {get; private set;}
    public CategorySummary (string category, int totalStocks, decimal totalValue, int lowStockItems)
    {
        Category = category;
        TotalStocks = totalStocks;
        TotalValue = totalValue;
        LowStockItems = lowStockItems;
    }
}