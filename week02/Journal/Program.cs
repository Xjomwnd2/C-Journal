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
            string choice = DisplayMenu(); // Get user input

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
                    Console.WriteLine("⚠ Invalid option. Please enter a number between 1-5.");
                    break;
            }
        }
    }

    static string DisplayMenu()
    {
        Console.WriteLine("\n===== JOURNAL MENU =====");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your choice: ");

        return Console.ReadLine().Trim();
    }
}
