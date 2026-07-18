class Program
{
    static void Main()
    {
        try
        {
            var cart = new List<Item>();
            cart.Add(new Item ("Relx", 5, 200.99m));
            cart.Add(new Item ("Xvape", 8, 251.99m));
            cart.Add(new Item ("Chillax", 10, 300.99m));
            cart.Add(new Item ("Watta", 12, 351.99m));

            Receipt receipt = ReceiptCalculator.MakeReceipt(cart);
            receipt.DisplayReceipt();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Unexpected Error!!");
        }
    }

}