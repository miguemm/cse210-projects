public class Commitment
{
    private string _description;
    private bool _completed;

    // Constructor with parameters
    public Commitment(string name, string description, bool completed)
    {
        _description = description;
        _completed = completed;
    }
    
    // Getter and setter for '_description' attribute
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    // Getter and setter for '_completed' attribute
    public bool Completed
    {
        get { return _completed; }
        set { _completed = value; }
    }
}
