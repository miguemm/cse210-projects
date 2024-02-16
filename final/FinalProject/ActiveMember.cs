public class ActiveMember : Person
{
    private bool _templeRecommendation;

    // Constructor with parameters
    public ActiveMember(string name, int age, string gender, bool templeRecommendation) : base(name, age, gender)
    {
        _templeRecommendation = templeRecommendation;
    }

    // Getter and setter for '_templeRecommendation' attribute
    public bool TempleRecommendation
    {
        get { return _templeRecommendation; }
        set { _templeRecommendation = value; }
    }

    public override string ShowMembershipStatus()
    {
        throw new NotImplementedException();
    }
}
