using System;

public abstract class Potion : IRegularPotion
{
    public string Name {get; set;}
    public decimal Price {get; set;}
    public Potion (string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public abstract void Effect();
}