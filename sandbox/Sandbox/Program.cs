using System;
using System.Collections.Generic;

public class Journal
{
    private List<string> entries = new List<string>();

    public void WriteNewEntry()
    {
        Console.Write("Enter your journal entry: ");
        string entry = Console.ReadLine();
        entries.Add(entry);
        Console.WriteLine("Entry added.");
    }

    public void DisplayAllEntries()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"- {entry}");
        }
    }

    public void SaveToFile()
    {
        // Implement file saving logic here
        Console.WriteLine("Journal saved to file.");
    }
}