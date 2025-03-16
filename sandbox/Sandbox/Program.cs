static void Main()
{
    Journal journal = new Journal();
    bool running = true;

    Console.WriteLine("Welcome to the Journal Program!");

    while (running)
    {
        DisplayMenu();
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "write new entry":
                journal.WriteNewEntry();
                break;
            case "2":
            case "display journal":
                journal.DisplayAllEntries();
                break;
            case "3":
            case "save journal":
                journal.SaveToFile();
                break;
            case "4":
            case "load journal":
                journal.LoadFromFile();
                break;
            case "5":
            case "quit":
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
