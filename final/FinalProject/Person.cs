public abstract class Person
{
    private string _name;
    private int _age;
    private string _gender;

    public abstract string ShowMembershipStatus();

    // Constructor with parameters
    public Person(string name, int age, string gender)
    {
        _name = name;
        _age = age;
        _gender = gender;
    }

    // Getter and setter for '_name' attribute
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getter and setter for '_age' attribute
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Getter and setter for '_gender' attribute
    public string Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
}
