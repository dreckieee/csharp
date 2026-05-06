using System;


class Item
{
    
    public string Name {get; set;}
    public string Type {get; set;}
    public int Quantity {get; set;}
    public Item (string name, string type, int quantity)
    {
        Name = name;
        Type = type;
        Quantity = quantity;
    }

}//end of Item class
