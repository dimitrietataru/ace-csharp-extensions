namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double ToDoubleInvariant(this object? value)
    {
        return ToDouble(value, CultureInfo.InvariantCulture);
    }

    public static double ToDoubleOrDefaultInvariant(this object? value, double defaultValue = default)
    {
        return ToDoubleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDoubleInvariant(this object? value, out double result)
    {
        return TryConvertToDouble(value, CultureInfo.InvariantCulture, out result);
    }
}
