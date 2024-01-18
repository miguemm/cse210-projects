public class JournalFile
{
    public List<JournalEntry> SaveJournal(List<JournalEntry> entries)
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }

            Console.WriteLine($"Journal saved to {filename} successfully!\n");
            Console.WriteLine($"A new Journal has been creted!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the journal: {ex.Message}\n");
        }

        return new List<JournalEntry>();
    }

    public List<JournalEntry> LoadJournal(List<JournalEntry> entries)
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        List<JournalEntry> loadedEntries = entries;

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                loadedEntries.Clear();
                Console.WriteLine($"Journal loaded from {filename} successfully!\n");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        JournalEntry entry = new JournalEntry
                        {
                            _prompt = parts[1],
                            _response = parts[2],
                            _date = date
                        };
                        entry.Display();
                        loadedEntries.Add(entry);
                    }
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}\n");
        }

        return loadedEntries;
    }
}