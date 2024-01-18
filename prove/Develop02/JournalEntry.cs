
public class JournalEntry
{
    public string _prompt;
    public string _response;
    public DateTime _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }
}