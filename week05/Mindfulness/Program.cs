using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = int.Parse(Console.ReadLine());


            if (userChoice == 1)
            {

                BreathingActivity Ba1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 1);
                Ba1.DisplayStartingMessage();
                Ba1.Run();
                Ba1.DisplayEndingMessage();
            }

            else if (userChoice == 2)
            {
                ReflectingActivity Ba2 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 1);
                Ba2.DisplayStartingMessage();
                Ba2.Run();
                Ba2.DisplayEndingMessage();
            }

            else if (userChoice == 3)
            {
                ListingActivity Ba3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 1);
                Ba3.DisplayStartingMessage();
                Ba3.Run();
                Ba3.DisplayEndingMessage();
            }
        }

    }
}