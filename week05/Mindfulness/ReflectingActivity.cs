using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // It's very possible that I'm going to change this part later,
        // I'm going to check it more later
        ;
    }

    public List<string> GetPrompt()
    {
        return _prompts;
    }

    public List<string> GetQuestion()
    {
        return _questions;
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            base.ShowSpinner(15);
            Console.WriteLine();
        }
    }

    Random randomP = new Random();

    Random randomQ = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = randomP.Next(GetPrompt().Count);
        string randomPrompt = GetPrompt()[randomIndex];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        int randomIndex = randomQ.Next(GetQuestion().Count);
        string randomQuestion = GetQuestion()[randomIndex];
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}