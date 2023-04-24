// Square.cs

public class Square : Shape
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double Side
    {
        get { return _side; }
        set { _side = value; }
    }

    public override double Perimeter()
    {
        return 4 * _side;
    }
}
