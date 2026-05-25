using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction firstFraction = new Fraction();
        Console.WriteLine($"{firstFraction.GetTop()}/{firstFraction.GetBottom()}");

        Fraction secondFraction = new Fraction();
        secondFraction.SetTop(5);
        Console.WriteLine($"{secondFraction.GetTop()}/{secondFraction.GetBottom()}");

        Fraction thirdFraction = new Fraction();
        thirdFraction.SetTop(6);
        thirdFraction.SetBottom(7);
        Console.WriteLine($"{thirdFraction.GetTop()}/{thirdFraction.GetBottom()}");


    }
}