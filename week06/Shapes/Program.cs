using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [
            new Square("red", 5),
            new Rectangle("blue", 10, 5),
            new Circle("green", 10)
        ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}