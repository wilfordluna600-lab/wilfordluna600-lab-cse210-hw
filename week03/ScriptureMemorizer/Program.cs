using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        Reference reference1 = new Reference("2 Nephi", 2, 27);

        string words1 = "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.";

        Scripture scripture1 = new Scripture(reference1, words1);

        Console.WriteLine(scripture1.GetDisplayText());

        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        string userInput = Console.ReadLine();
        while (userInput != "quit" && scripture1.IsCompletelyHidden() == false)
        {
            Console.Clear();
            scripture1.HideRandomWords(3);
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();
        }
    }
}