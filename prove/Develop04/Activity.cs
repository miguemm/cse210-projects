public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;
    
    public Activity()
    {
    }


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to the {_name}.\n\n{_description}.\n\nHow long, in second, would you like for your session? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\n\n You have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine("Done.");
    } 

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    } 
}