using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction firstFraction = new Fraction();

        Fraction secondFraction = new Fraction();
        secondFraction.SetTop(5);

        Fraction thirdFraction = new Fraction();
        thirdFraction.SetTop(6);
        thirdFraction.SetBottom(7);

        Console.WriteLine($"{firstFraction.GetTop()}/{firstFraction.GetBottom()}");
        Console.WriteLine($"{secondFraction.GetTop()}/{secondFraction.GetBottom()}");
        Console.WriteLine($"{thirdFraction.GetTop()}/{thirdFraction.GetBottom()}");
    }
}