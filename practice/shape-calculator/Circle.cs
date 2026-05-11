using System;
public class Circle : Shape
{

    public decimal Radius {get; set;}

    public Circle (string name, decimal radius) : base (name)
    {
        Radius = radius;
    }

    public override decimal GetArea ()
    {
        return 3.14159m * Radius * Radius;
    }//end of GetArea method
    
}//end of Circle class