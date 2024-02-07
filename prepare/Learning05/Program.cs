using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 5);
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle("red", 3, 7);
        Console.WriteLine(r1.GetColor());
        Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle("green", 3);
        Console.WriteLine(c1.GetColor());
        Console.WriteLine(c1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(c1);
        shapes.Add(s1);
        shapes.Add(r1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}