using System;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        Journal journalApp = new Journal();
        JournalFile journalFile = new JournalFile();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        journalApp.WriteNewEntry();
                        break;
                    case 2:
                        Console.Clear();
                        journalApp.DisplayJournal();
                        break;
                    case 3:
                        Console.Clear();
                        journalApp._entries = journalFile.SaveJournal(journalApp._entries);
                        break;
                    case 4:
                        Console.Clear();
                        journalApp._entries = journalFile.LoadJournal(journalApp._entries);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

