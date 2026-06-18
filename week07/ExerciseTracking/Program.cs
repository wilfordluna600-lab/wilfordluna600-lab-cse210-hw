using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        RunningActivity a1 = new RunningActivity("Running", 4800, 30);

        CyclingActivity a2 = new CyclingActivity("Cycling", 5000, 30);

        SwimmingActivity a3 = new SwimmingActivity("Swimming", 25, 30);

        List<Activity> aList = new List<Activity>();
        aList.Add(a1);
        aList.Add(a2);
        aList.Add(a3);

        foreach (Activity aItem in aList)
        {
            Console.WriteLine(aItem.GetSummary());
        }
    }
}