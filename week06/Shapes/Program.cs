using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square Square1 = new Square("Blue", 6);
        Console.WriteLine(Square1.GetColor());
        Console.WriteLine(Square1.GetArea());

        Rectangle Rectangle1 = new Rectangle("Red", 6, 12);
        Console.WriteLine(Rectangle1.GetColor());
        Console.WriteLine(Rectangle1.GetArea());

        Circle Circle1 = new Circle("Yellow", 8);
        Console.WriteLine(Circle1.GetColor());
        Console.WriteLine(Circle1.GetArea());

        List<Shape> Shapes1 = new List<Shape>();
        Shapes1.Add(Square1);
        Shapes1.Add(Rectangle1);
        Shapes1.Add(Circle1);

        foreach (Shape shapes in Shapes1)
        {
            Console.WriteLine($"The color is {shapes.GetColor()} and its area is {shapes.GetArea()}");
        }
    }
}