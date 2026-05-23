using System;
using System.Collections.Generic;
public class PromptGenerator

{
    public List<string> _prompts = new List<string>()
    {
        "What conversation or interaction impacted me today?",
        "What did I do today that brought me (even a little) closer to my goals?",
        "What small victory did I have today that would normally go unnoticed?",
        "With what feeling do I want to end this day?",
        "What was the first thing I thought or felt upon waking up today?"
    };

    Random random = new Random();
    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

}