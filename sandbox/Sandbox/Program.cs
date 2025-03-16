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

public class Program
{
    public static void Main()
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
