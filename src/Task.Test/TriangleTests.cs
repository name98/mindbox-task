using Task.Geometry.Shapes;

namespace Task.Test;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(10, 10, 16, 48)]
    [TestCase(12, 16, 20, 96)]
    [TestCase(5, 5, 6, 12)]
    public void TriangleArea_AreaEqual_ReturnTrue(double a, double b, double c, double area)
    {
        var triangle = new Triangle(a, b, c);
        var result = triangle.GetArea();
        Assert.That(result, Is.EqualTo(area));
    }

    [TestCase(10, -10, 16)]
    [TestCase(12, 6, 20)]
    [TestCase(5, 0, 0)]
    public void InvalidTriangle_HasException(double a, double b, double c)
    {
        Assert.Throws<Exception>(() => new Triangle(a, b, c));
    }

    [TestCase(3, 4, 5, true)]
    [TestCase(5, 3, 4, true)]
    [TestCase(16, 20, 12, true)]
    [TestCase(5, 5, 4, false)]
    public void CheckRigthTriangle_ReturnFlag(double a, double b, double c, bool isRigth)
    {
        var triangle = new Triangle(a, b, c);
        var result = triangle.IsRigth();
        Assert.That(isRigth, Is.EqualTo(result));
    }
}
