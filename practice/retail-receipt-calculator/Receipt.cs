public class Receipt
{
    
    public List<Item> Items {get; private set;}
    public decimal SubTotal {get; private set;}
    public decimal DiscountRate {get; private set;}
    public decimal DiscountedTotal {get; private set;}
    public decimal TaxRate {get; private set;}
    public decimal FinalTotal {get; private set;}
    public Receipt(List<Item> items, decimal subTotal, decimal discountRate, decimal discountedTotal, decimal taxRate,decimal finalTotal)
    {
        Items = items;
        SubTotal = subTotal;
        DiscountRate = discountRate;
        DiscountedTotal = discountedTotal;
        TaxRate = taxRate;
        FinalTotal = finalTotal;
    }

    public void DisplayReceipt()
    {
        Console.WriteLine("Name".PadRight(14) + "Quantity".PadRight(14) + "Price".PadRight(14) + "Total".PadLeft(14));
        foreach (Item i in Items)
        {
            Console.WriteLine($">{i.Name}".PadRight(14) + $"> {i.Quantity}".PadRight(14) + $"> {i.Price:C2}".PadRight(14) + $"{i.Quantity * i.Price:C2}".PadLeft(14));
        }
        Console.WriteLine();
        Console.WriteLine("Sub-total: ".PadRight(42) + $"{SubTotal:C2}".PadLeft(14));
        if(DiscountRate == 0.1m)
        {
            Console.WriteLine($"Discounted Total ({DiscountRate * 100}% Tier 1 Discount): ".PadRight(42) + $"{DiscountedTotal:C2}".PadLeft(14));
        }
        else if(DiscountRate == 0.2m)
        {
            Console.WriteLine($"Discounted Total ({DiscountRate * 100}% Tier 2 Discount): ".PadRight(42) + $"{DiscountedTotal:C2}".PadLeft(14));
        }
        Console.WriteLine();
        Console.WriteLine($"Final Total ({TaxRate * 100}% Tax): ".PadRight(42) + $"{FinalTotal:C2}".PadLeft(14));
    }
}