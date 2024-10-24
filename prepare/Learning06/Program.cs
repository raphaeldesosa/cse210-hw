using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square(6, "brown");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(5, 10, "red");
        shapes.Add(s2);

        Circle s3 = new Circle(8, "yellow");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}