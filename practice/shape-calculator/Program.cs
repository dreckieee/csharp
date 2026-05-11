using System;

class Program
{
    
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        Circle newCircle = new Circle ( "circle1", 2.91m) ;
        Rectangle newRectangle = new Rectangle( "rectangle1", 3.31m, 4.22m );
        Triangle newTriangle = new Triangle ( "triangle1", 2.5m, 2.88m );

        shapes.Add(newCircle);
        shapes.Add(newRectangle);
        shapes.Add(newTriangle);

        Console.WriteLine();

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape name: {s.Name} -- Area: { Math.Round(s.GetArea(), 2) }");
        }
        Console.Write("Press enter key to continue..");
        Console.ReadLine();
        Console.WriteLine();

    }//end of Main method

}//end of Program class