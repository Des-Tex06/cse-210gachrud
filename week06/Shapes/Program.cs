using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 4);
        square.GetColor();
        square.GetArea();
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("orange", 4, 6);
        rectangle.GetColor();
        rectangle.GetArea();
        shapes.Add(rectangle);

        Circle circle = new Circle("black", 3.4);
        circle.GetColor();
        circle.GetArea();
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape);
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }

    }
}