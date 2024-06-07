using Task.Geometry.Shapes;

namespace Task.Test;

public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(13, 530.93)]
    [TestCase(0.4, 0.5)]
    [TestCase(Math.PI, 31.01)]
    public void CircleArea_AreaEqual_ReturnTrue(double radius, double area)
    {
        var triangle = new Circle(radius);
        var result = Math.Round(triangle.GetArea(), 2);
        Assert.That(result, Is.EqualTo(area));
    }

    [TestCase(0)]
    [TestCase(-12)]
    public void InvalidCircle_HasException(double radius)
    {
       Assert.Throws<Exception>(() => new Circle(radius));
    }
}
