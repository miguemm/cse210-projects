public class JournalFile
{
    public void SaveJournal(List<JournalEntry> entries)
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }

            Console.WriteLine($"Journal saved to {filename} successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the journal: {ex.Message}\n");
        }
    }

    public void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                Console.WriteLine($"Journal loaded from {filename} successfully!\n");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Console.WriteLine($"Date: {date}, Prompt: {parts[1]}");
                        Console.WriteLine($"Response: {parts[2]}\n");
                    }
                }
            }

           
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}\n");
        }
    }
}