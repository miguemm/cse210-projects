class JournalApp
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?"
    };

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        WriteNewEntry();
                        break;
                    case 2:
                        DisplayJournal();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private void WriteNewEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        entries.Add(entry);
        Console.WriteLine("Entry saved successfully!\n");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }
}