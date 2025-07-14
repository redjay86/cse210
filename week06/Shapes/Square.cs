public class Square : Shape
{
    private double _side;

    public Square(string c, double l) : base(c)
    {
        _side = l;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}