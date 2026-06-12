using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        BreathingActivity Ba1 = new BreathingActivity("new", "new", 30);
        Ba1.Run();
    }
}