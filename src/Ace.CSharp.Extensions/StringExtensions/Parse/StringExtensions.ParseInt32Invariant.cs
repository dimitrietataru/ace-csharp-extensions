namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ParseInt32Invariant(this string value)
    {
        return ParseInt32(value, CultureInfo.InvariantCulture);
    }

    public static int ParseInt32Invariant(this string value, NumberStyles style)
    {
        return ParseInt32(value, style, CultureInfo.InvariantCulture);
    }

    public static int ParseInt32OrDefaultInvariant(this string value, int defaultValue = default)
    {
        return ParseInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static int ParseInt32OrDefaultInvariant(this string value, NumberStyles style, int defaultValue = default)
    {
        return ParseInt32OrDefault(value, style, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryParseInt32Invariant(this string value, out int result)
    {
        return TryParseInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static bool TryParseInt32Invariant(this string value, NumberStyles style, out int result)
    {
        return TryParseInt32(value, style, CultureInfo.InvariantCulture, out result);
    }

    public static int ParseIntInvariant(this string value)
    {
        return ParseInt32Invariant(value);
    }

    public static int ParseIntInvariant(this string value, NumberStyles style)
    {
        return ParseInt32Invariant(value, style);
    }

    public static int ParseIntOrDefaultInvariant(this string value, int defaultValue = default)
    {
        return ParseInt32OrDefaultInvariant(value, defaultValue);
    }

    public static int ParseIntOrDefaultInvariant(this string value, NumberStyles style, int defaultValue = default)
    {
        return ParseInt32OrDefaultInvariant(value, style, defaultValue);
    }

    public static bool TryParseIntInvariant(this string value, out int result)
    {
        return TryParseInt32Invariant(value, out result);
    }

    public static bool TryParseIntInvariant(this string value, NumberStyles style, out int result)
    {
        return TryParseInt32Invariant(value, style, out result);
    }
}
