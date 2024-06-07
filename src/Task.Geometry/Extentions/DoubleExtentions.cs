namespace Task.Geometry.Extentions;

internal static class DoubleExtentions
{
    public static bool IsNegative(this double source)
    {
        return source.IsPositive() is false;
    }

    public static bool IsPositive(this double source)
    {
        return Math.Abs(source) == source;
    }
}