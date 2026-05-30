using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Word w1 = new Word("Encapsulation");
        Console.WriteLine(w1.GetDisplayText());

        Word w2 = new Word("Encapsulation");
        w2.Hide();
        Console.WriteLine(w2.GetDisplayText());
    }
}