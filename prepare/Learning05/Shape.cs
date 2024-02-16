public abstract class Shape
{
    private string _color {get; set;}

    protected Shape(string color)
    {
        this._color = color;
    }    

    public string GetColor()
    {
        return this._color;
    }

    public abstract double GetArea();
}