public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
       _prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        _prompts.RemoveAt(randomIndex);
        return prompt;
    }


    public void Run()
    {
        DisplayStartingMessage();

        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();

        Console.Write($"List as many responses you can to the following prompt: \n\t--- {GetRandomPrompt()} ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }      
        Console.WriteLine($"You listed {_count}!");  

        DisplayEndingMessage();
        ShowSpinner(6);
    }
}