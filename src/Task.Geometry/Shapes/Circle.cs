using Task.Geometry.Abstractions;
using Task.Geometry.Extentions;

namespace Task.Geometry.Shapes;

public class Circle : IShape
{
    public Circle(double radius)
    {
        if (radius.IsNegative())
        {
            throw new Exception();
        }

        if (radius == 0)
        {
            throw new Exception();
        }

        Radius = radius;
    }

    public double Radius { get; private set; }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}