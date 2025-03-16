using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool running = true;
        
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (running)
        {
            DisplayMenu();
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
                    journal.LoadFromFile();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            
            Console.WriteLine();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
    }
}

// Dummy Journal class for now
class Journal
{
    public void WriteNewEntry() => Console.WriteLine("Writing new journal entry...");
    public void DisplayAllEntries() => Console.WriteLine("Displaying all entries...");
    public void SaveToFile() => Console.WriteLine("Saving journal to file...");
    public void LoadFromFile() => Console.WriteLine("Loading journal from file...");
}
