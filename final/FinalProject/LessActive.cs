public class LessActive : Person
{
    private List<Commitment> _commitments;

    // Constructor with parameters
    public LessActive(string name, int age, string gender, List<Commitment> commitments) : base(name, age, gender)
    {
        _commitments = commitments;
    }

    // Getter and setter for '_commitments' attribute
    public List<Commitment> Commitments
    {
        get { return _commitments; }
        set { _commitments = value; }
    }

    public override string ShowMembershipStatus()
    {
        throw new NotImplementedException();
    }
}
