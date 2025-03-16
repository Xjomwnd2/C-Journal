// See https://aka.ms/new-console-template for more information

        Console.WriteLine("\n===== JOURNAL MENU =====");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your choice: ");

        return Console.ReadLine().Trim();
