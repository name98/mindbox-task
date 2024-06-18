using Task.Geometry.Abstractions;
using Task.Geometry.Extentions;

namespace Task.Geometry.Shapes;

public class Triangle : Shape
{
    public Triangle(double a, double b, double c)
    {
        if (a.IsNegative() || b.IsNegative() || c.IsNegative())
        {
            throw new Exception();
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new Exception();
        }

        A = a;
        B = b;
        C = c;
    }

    public Triangle(double a) : this(a, a, a)
    {
    }

    public Triangle(double baseSide, double equalSides) : this(equalSides, equalSides, baseSide)
    {
    }

    public double A { get; private init; }

    public double B { get; private init; }

    public double C { get; private init; }

    public bool IsRigth()
    {
        var (hypotenuse, leg1, leg2) = (A, B, C) switch
        {
            (double a, double b, double c) when a > b && a > c => (a, b, c),
            (double a, double b, double c) when b > a && b > c => (b, a, c),
            _ => (C, A, B)
        };

        return Math.Pow(leg1, 2) + Math.Pow(leg2, 2) == Math.Pow(hypotenuse, 2);
    }

    public override double GetArea()
    {
        var p = GetPerimeter() / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override double GetPerimeter() => A + B + C;
}