using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new()
        {
            new Square("Blue", 2),
            new Rectangle("Red", 2, 4),
            new Circle("Yellow", 6)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}. Area: {shape.GetArea()}");
        }
    }
}