using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int iMagicNumber = randomGenerator.Next(1, 101);
        string sGuessNumber = "";
        int iGuessNumber = 0;
        while (iGuessNumber != iMagicNumber)
        {
            Console.Write("What is your guess? ");
            sGuessNumber = Console.ReadLine();
            iGuessNumber = int.Parse(sGuessNumber);
            if (iGuessNumber == iMagicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (iGuessNumber < iMagicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }

    }
}