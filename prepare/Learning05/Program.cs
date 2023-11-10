using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("red", 2);
        Rectangle s2 = new Rectangle("yellow", 2, 3);
        Circle s3 = new Circle("green", 1);
        shapes.Add(s1);shapes.Add(s2);shapes.Add(s3);
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape is {area:.1f} big");
        }
    }
}