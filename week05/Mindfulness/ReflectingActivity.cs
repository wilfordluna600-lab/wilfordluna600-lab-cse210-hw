public class ReflectingActivity : Activity
{
    public List<string> _prompts;
    public List<string> _questions;

    public ReflectingActivity()
    {
        // It's very possible that I'm going to change this part later,
        // I'm going to check it more later
        _prompts = new List<string>();
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}