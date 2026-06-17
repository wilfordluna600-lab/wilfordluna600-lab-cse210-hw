using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        RunningActivity a1 = new RunningActivity("Running", 3600, 30);

        CyclingActivity a2 = new CyclingActivity("Cycling", 5000, 30);

        SwimmingActivity a3 = new SwimmingActivity("Swimming", 30, 25);
    }
}