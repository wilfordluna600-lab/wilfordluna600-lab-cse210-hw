using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int listUserCount;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        ;
    }



    public List<string> GetPrompt()
    {
        return _prompts;
    }

    public int GetCount()
    {
        return _count = listUserCount;
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine();


        List<string> entries = GetListFromUser();
        listUserCount = entries.Count;

        Console.WriteLine($"You listed {GetCount()} items!");

    }

    Random randomP = new Random();

    public void GetRandomPrompt()
    {
        int randomIndex = randomP.Next(GetPrompt().Count);
        string randomPrompt = GetPrompt()[randomIndex];
        Console.WriteLine($" --- {randomPrompt} --- ");
    }


    public List<string> GetListFromUser()
    {
        List<string> Entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            Entries.Add(userEntry);
        }

        return Entries;
    }

}