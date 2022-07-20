namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ParseInt64Invariant(this string value)
    {
        return ParseInt64(value, CultureInfo.InvariantCulture);
    }

    public static long ParseInt64Invariant(this string value, NumberStyles style)
    {
        return ParseInt64(value, style, CultureInfo.InvariantCulture);
    }

    public static long ParseInt64OrDefaultInvariant(this string value, long defaultValue = default)
    {
        return ParseInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static long ParseInt64OrDefaultInvariant(this string value, NumberStyles style, long defaultValue = default)
    {
        return ParseInt64OrDefault(value, style, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryParseInt64Invariant(this string value, out long result)
    {
        return TryParseInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static bool TryParseInt64Invariant(this string value, NumberStyles style, out long result)
    {
        return TryParseInt64(value, style, CultureInfo.InvariantCulture, out result);
    }

    public static long ParseLongInvariant(this string value)
    {
        return ParseInt64Invariant(value);
    }

    public static long ParseLongInvariant(this string value, NumberStyles style)
    {
        return ParseInt64Invariant(value, style);
    }

    public static long ParseLongOrDefaultInvariant(this string value, long defaultValue = default)
    {
        return ParseInt64OrDefaultInvariant(value, defaultValue);
    }

    public static long ParseLongOrDefaultInvariant(this string value, NumberStyles style, long defaultValue = default)
    {
        return ParseInt64OrDefaultInvariant(value, style, defaultValue);
    }

    public static bool TryParseLongInvariant(this string value, out long result)
    {
        return TryParseInt64Invariant(value, out result);
    }

    public static bool TryParseLongInvariant(this string value, NumberStyles style, out long result)
    {
        return TryParseInt64Invariant(value, style, out result);
    }
}
