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
static void DisplayMenu()
{
    Console.WriteLine("\nPlease select one of the following choices:");
    Console.WriteLine("1. Write a new entry (or type 'write new entry')");
    Console.WriteLine("2. Display the journal (or type 'display journal')");
    Console.WriteLine("3. Save the journal to a file (or type 'save journal')");
    Console.WriteLine("4. Load the journal from a file (or type 'load journal')");
    Console.WriteLine("5. Quit (or type 'quit')");
}

}
}