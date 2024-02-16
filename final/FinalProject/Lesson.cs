public class Lesson
{
    private string _name;
    private bool _completed;

    // Constructor with parameters
    public Lesson(string name, string description, bool completed)
    {
        _name = name;
        _completed = completed;
    }

    // Getter and setter for '_name' attribute
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getter and setter for '_completed' attribute
    public bool Completed
    {
        get { return _completed; }
        set { _completed = value; }
    }
}