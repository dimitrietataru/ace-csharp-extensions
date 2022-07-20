namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ParseInt32Invariant(this string value)
    {
        return ParseInt32(value, CultureInfo.InvariantCulture);
    }

    public static int ParseInt32OrDefaultInvariant(this string value, int defaultValue = default)
    {
        return ParseInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryParseInt32Invariant(this string value, out int result)
    {
        return TryParseInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static int ParseIntInvariant(this string value)
    {
        return ParseInt32Invariant(value);
    }

    public static int ParseIntOrDefaultInvariant(this string value, int defaultValue = default)
    {
        return ParseInt32OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryParseIntInvariant(this string value, out int result)
    {
        return TryParseInt32Invariant(value, out result);
    }
}
