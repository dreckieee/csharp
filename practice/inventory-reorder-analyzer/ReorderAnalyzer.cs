public static class ReorderAnalyzer
{
    public static IEnumerable<IInventoryItem> GetLowStock (List<IInventoryItem> inventory, int threshold)
    {
        if (inventory == null)
        {
            throw new ArgumentNullException (nameof(inventory), "Cannot get low stocked-item of non-existent inventory.");
        }
        return inventory.Where(i => i.Stock < threshold);
    }

    public static IEnumerable<IGrouping<string, IInventoryItem>> GroupByCategory (List<IInventoryItem> inventory)
    {
        if (inventory == null)
        {
            throw new ArgumentNullException (nameof(inventory), "Cannot categorize non-existent inventory.");
        }
        return inventory.GroupBy(c => c.Category);
    }

    public static IEnumerable<CategorySummary> GetCategorySummary (List<IInventoryItem> inventory, int threshold)
    {
        if (inventory == null)
        {
            throw new ArgumentNullException (nameof(inventory), "Cannot summarize non-existent inventory.");
        }
        return GroupByCategory(inventory).Select (group => new CategorySummary 
            (
                group.Key,
                group.Sum (i => i.Stock),
                group.Sum (i => i.Stock * i.Price),
                group.Count (i => i.Stock < threshold)
            )
        );
    }

    public static CategorySummary GetMostUrgentCategory (IEnumerable<CategorySummary> categorySummaries)
    {
        if (categorySummaries == null)
        {
            throw new ArgumentNullException (nameof(categorySummaries), "Cannot get most urgent category for non-existent inventories.");
        }
        if (!categorySummaries.Any (group => group.LowStockItems > 0))
        {
            throw new InvalidOperationException ("No categories have low stock items");
        }
            return categorySummaries.MaxBy(cs => cs.LowStockItems)!;
    }
}