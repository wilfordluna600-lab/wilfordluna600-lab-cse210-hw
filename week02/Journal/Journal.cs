using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;


    string file = "journal.txt";

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }


    }

    public void LoadFromFile(string file)
    {

    }
}