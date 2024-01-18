public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who did you find most intriguing in your interactions today?",
        "What made today the best part of your day?",
        "In what ways did you observe the impact of the Lord in your life today?",
        "Which emotion resonated with you the most today?",
        "If you could redo one thing from today, what would it be?",
        "What new skill or knowledge did you acquire today?",
        "Can you recall a moment that brought laughter into your day?",
        "What challenge did you successfully overcome today?",
        "How did you extend kindness or assistance to someone today?",
        "Describe a mistake you made today and the lessons learned."
    };

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "Tell me more about your day.";
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];

        _prompts.RemoveAt(index);

        return selectedPrompt;
    }
}