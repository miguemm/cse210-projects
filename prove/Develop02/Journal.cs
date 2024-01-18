public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void WriteNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry();

        entry._prompt = prompt;
        entry._response = response;
        entry._date = DateTime.Now;


        _entries.Add(entry);
        Console.WriteLine("Entry saved successfully!\n");
    }


    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    
}