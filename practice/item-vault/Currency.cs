public class Currency
{
    public string Name {get; set;}
    public int Quantity {get; set;}

    public Currency (string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public override string ToString()
    {
        string result = $"\nName: {Name}\nQuantity: {Quantity:N0}\n";
        return result;
    }
}