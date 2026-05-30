using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        Reference reference1 = new Reference("2 Nephi", 2, 25);

        string words1 = "Adam fell that men might be; and men are, that they might have joy.";

        Scripture scripture1 = new Scripture(reference1, words1);

        Console.WriteLine(scripture1.GetDisplayText());

        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        string userInput = Console.ReadLine();
        while (userInput != "quit" && scripture1.IsCompletelyHidden() == false)
        {
            scripture1.HideRandomWords(3);
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();
        }
    }
}