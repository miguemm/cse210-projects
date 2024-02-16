public class RecentConvert : Person
{
    private List<Lesson> _lessons;

    // Constructor with parameters
    public RecentConvert(string name, int age, string gender, List<Lesson> lessons) : base(name, age, gender)
    {
        _lessons = lessons;
    }

    // Getter and setter for '_lessons' attribute
    public List<Lesson> Lessons
    {
        get { return _lessons; }
        set { _lessons = value; }
    }

    public override string ShowMembershipStatus()
    {
        throw new NotImplementedException();
    }
}
