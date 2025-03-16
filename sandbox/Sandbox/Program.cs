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

    public void LoadFromFile()
    {
        // Implement file loading logic here
    Console.WriteLine("\nPlease select one of the following choices:");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save the journal to a file");
    Console.WriteLine("4. Load the journal from a file");
    Console.WriteLine("5. Quit");
    }
}








using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("\nPlease select one of the following choices:");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save the journal to a file");
    Console.WriteLine("4. Load the journal from a file");
    Console.WriteLine("5. Quit");
    }
}
