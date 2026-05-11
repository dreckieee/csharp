using System;
public class Triangle : Shape
{

    public decimal TriangleBase{get; set;}
    public decimal Height {get; set;}

    public Triangle (string name, decimal triangleBase, decimal height) : base (name)
    {
        TriangleBase = triangleBase;
        Height = height;
    }

    public override decimal GetArea()
    {
        return 0.5m * TriangleBase * Height;
    }//end of GetArea method
    
}//end of Triangle class