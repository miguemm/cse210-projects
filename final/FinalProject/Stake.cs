public class Stake
{
    private string _name;
    private List<Ward> _wards;

    // Constructor with parameters
    public Stake(string name, List<Ward> wards)
    {
        _name = name;
        _wards = wards;
    }

    // Getter and setter for '_name' attribute
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getter and setter for '_wards' attribute
    public List<Ward> Wards
    {
        get { return _wards; }
        set { _wards = value; }
    }
}
