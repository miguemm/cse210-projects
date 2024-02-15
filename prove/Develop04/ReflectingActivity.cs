public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void DisplayPrompt()
    {
        Console.Write($"Consider the following prompt:\n\t--- {GetRandomPrompt()} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        _prompts.RemoveAt(randomIndex);
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string question = _questions[randomIndex];
        _questions.RemoveAt(randomIndex);
        return question;
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        DisplayPrompt();

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }        

        DisplayEndingMessage();
        ShowSpinner(6);
    }
}