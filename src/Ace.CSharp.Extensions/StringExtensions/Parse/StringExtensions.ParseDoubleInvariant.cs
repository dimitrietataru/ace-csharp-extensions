namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ParseDoubleInvariant(this string value)
    {
        return ParseDouble(value, CultureInfo.InvariantCulture);
    }

    public static double ParseDoubleInvariant(this string value, NumberStyles style)
    {
        return ParseDouble(value, style, CultureInfo.InvariantCulture);
    }

    public static double ParseDoubleOrDefaultInvariant(this string value, double defaultValue = default)
    {
        return ParseDoubleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static double ParseDoubleOrDefaultInvariant(this string value, NumberStyles style, double defaultValue = default)
    {
        return ParseDoubleOrDefault(value, style, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryParseDoubleInvariant(this string value, out double result)
    {
        return TryParseDouble(value, CultureInfo.InvariantCulture, out result);
    }

    public static bool TryParseDoubleInvariant(this string value, NumberStyles style, out double result)
    {
        return TryParseDouble(value, style, CultureInfo.InvariantCulture, out result);
    }
}
