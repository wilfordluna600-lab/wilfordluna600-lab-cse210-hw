using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Word w1 = new Word("State");
        Console.WriteLine(w1.GetDisplayText());

        Word w2 = new Word("State");
        w2.Hide();
        Console.WriteLine(w2.GetDisplayText());
    }
}