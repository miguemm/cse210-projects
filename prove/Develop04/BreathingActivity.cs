public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        SetDuration(int.Parse(Console.ReadLine()));

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath in... ");
            ShowCountDown(4);
            Console.Write("\nBreath out... ");
            ShowCountDown(6);
            Console.Write("\n");
        }        

        DisplayEndingMessage();
        ShowSpinner(5);
    }
}