using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        string userFile = "";
        Journal userJournal = new Journal();
        userJournal._entries = new List<Entry>();
        PromptGenerator newPrompt = new PromptGenerator();
        string randomPrompt = "";


        string userChoice = "0";
        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();


            if (userChoice == "1")
            {
                randomPrompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string userEntry = Console.ReadLine();
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                String dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = userEntry;
                userJournal._entries.Add(newEntry);
            }
            else if (userChoice == "2")
            {
                userJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename? ");
                userFile = Console.ReadLine();
                userJournal.SaveToFile(userFile);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename? ");
                userFile = Console.ReadLine();
                userJournal.LoadFromFile(userFile);
            }
        }
    }
}