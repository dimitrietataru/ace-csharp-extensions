namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ParseDoubleLocal(this string value)
    {
        return ParseDouble(value, CultureInfo.CurrentCulture);
    }

    public static double ParseDoubleLocal(this string value, NumberStyles style)
    {
        return ParseDouble(value, style, CultureInfo.CurrentCulture);
    }

    public static double ParseDoubleOrDefaultLocal(this string value, double defaultValue = default)
    {
        return ParseDoubleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static double ParseDoubleOrDefaultLocal(this string value, NumberStyles style, double defaultValue = default)
    {
        return ParseDoubleOrDefault(value, style, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryParseDoubleLocal(this string value, out double result)
    {
        return TryParseDouble(value, CultureInfo.CurrentCulture, out result);
    }

    public static bool TryParseDoubleLocal(this string value, NumberStyles style, out double result)
    {
        return TryParseDouble(value, style, CultureInfo.CurrentCulture, out result);
    }
}
