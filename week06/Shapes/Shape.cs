public abstract class Shape
{
    private string _color;

    public abstract double GetArea();
    public Shape(string c)
    {
        _color = c;
    }

    public void SetColot(string c)
    {
        _color = c;
    }

    public string GetColor()
    {
        return _color;
    }
}