public static class ReceiptCalculator
{
    public static Receipt MakeReceipt (List<Item> items)
    {

        //sub-total
        decimal subTotal = 0m;
        foreach (Item i in items)
        {
            subTotal += i.Price * i.Quantity;
        }

        //discount
        decimal discountRate = 0m;
        if (subTotal > 15000)
        {
            discountRate = 0.2m;
        }
        else if (subTotal > 10000)
        {
            discountRate = 0.1m;
        }
        decimal discountedTotal = subTotal - (subTotal * discountRate);

        //tax
        decimal taxRate = 0.1m;
        decimal finalTotal = discountedTotal - (discountedTotal * taxRate);

        return new Receipt(items, subTotal, discountRate, discountedTotal, taxRate, finalTotal); 
    }
    
}