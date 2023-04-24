// Circle.cs
using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public override double Perimeter()
    {
        return 2 * 3.14 * _radius;
    }
}
