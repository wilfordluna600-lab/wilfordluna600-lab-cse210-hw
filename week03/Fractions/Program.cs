using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();

        Fraction f2 = new Fraction();
        f2.SetTop(5);

        Fraction f3 = new Fraction();
        f3.SetTop(6);
        f3.SetBottom(7);

        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(3);

        // Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        // Console.WriteLine($"{f2.GetTop()}/{f2.GetBottom()}");
        // Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}