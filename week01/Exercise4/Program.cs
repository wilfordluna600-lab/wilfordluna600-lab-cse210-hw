using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbersList = new List<int>();
        int userNumber = -1;
        float sumTotal = 0;
        int largestNumber = 0;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbersList.Add(userNumber);
            }
        }

        foreach (int numberList in numbersList)
        {
            sumTotal += numberList;
            if (numberList > largestNumber)
            {
                largestNumber = numberList;
            }
        }

        Console.WriteLine($"The sum is: {sumTotal}");

        float average = sumTotal / numbersList.Count;

        Console.WriteLine($"The average is: {average:F6}");

        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}