using System;
public class Rectangle : Shape
{

    public decimal Width {get; set;}
    public decimal Height {get; set;}

    public Rectangle (string name, decimal width, decimal height) : base (name)
    {
        Width = width;
        Height = height;
    }

    public override decimal GetArea()
    {
        return Width * Height;
    }//end of GetArea method
    
}//end of Rectangle class