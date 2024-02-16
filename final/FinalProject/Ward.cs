public class Ward
{
    private string _name;
    private List<Person> _people;

    // Constructor with parameters
    public Ward(string name, List<Person> people)
    {
        _name = name;
        _people = people;
    }

    // Getter and setter for '_name' attribute
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getter and setter for '_people' attribute
    public List<Person> People
    {
        get { return _people; }
        set { _people = value; }
    }
}
