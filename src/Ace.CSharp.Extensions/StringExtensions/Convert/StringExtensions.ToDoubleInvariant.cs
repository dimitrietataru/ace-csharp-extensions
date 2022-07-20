namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ToDoubleInvariant(this string? value)
    {
        return ToDouble(value, CultureInfo.InvariantCulture);
    }

    public static double ToDoubleOrDefaultInvariant(this string? value, double defaultValue = default)
    {
        return ToDoubleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDoubleInvariant(this string? value, out double result)
    {
        return TryConvertToDouble(value, CultureInfo.InvariantCulture, out result);
    }
}
