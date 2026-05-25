using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction firstFraction = new Fraction();
        Console.WriteLine($"{firstFraction._top}/{firstFraction._bottom}");

        Fraction secondFraction = new Fraction(5);
        Console.WriteLine($"{secondFraction._top}/{secondFraction._bottom}");

        Fraction thirdFraction = new Fraction(6, 7);
        Console.WriteLine($"{thirdFraction._top}/{thirdFraction._bottom}");

    }
}