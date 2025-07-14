public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(string c, double l, double w) : base(c)
    {
        _length = l;
        _width = w;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}