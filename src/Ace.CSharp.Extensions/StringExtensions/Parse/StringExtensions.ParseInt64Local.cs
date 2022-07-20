namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ParseInt64Local(this string value)
    {
        return ParseInt64(value, CultureInfo.CurrentCulture);
    }

    public static long ParseInt64Local(this string value, NumberStyles style)
    {
        return ParseInt64(value, style, CultureInfo.CurrentCulture);
    }

    public static long ParseInt64OrDefaultLocal(this string value, long defaultValue = default)
    {
        return ParseInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static long ParseInt64OrDefaultLocal(this string value, NumberStyles style, long defaultValue = default)
    {
        return ParseInt64OrDefault(value, style, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryParseInt64Local(this string value, out long result)
    {
        return TryParseInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static bool TryParseInt64Local(this string value, NumberStyles style, out long result)
    {
        return TryParseInt64(value, style, CultureInfo.CurrentCulture, out result);
    }

    public static long ParseLongLocal(this string value)
    {
        return ParseInt64Local(value);
    }

    public static long ParseLongLocal(this string value, NumberStyles style)
    {
        return ParseInt64Local(value, style);
    }

    public static long ParseLongOrDefaultLocal(this string value, long defaultValue = default)
    {
        return ParseInt64OrDefaultLocal(value, defaultValue);
    }

    public static long ParseLongOrDefaultLocal(this string value, NumberStyles style, long defaultValue = default)
    {
        return ParseInt64OrDefaultLocal(value, style, defaultValue);
    }

    public static bool TryParseLongLocal(this string value, out long result)
    {
        return TryParseInt64Local(value, out result);
    }

    public static bool TryParseLongLocal(this string value, NumberStyles style, out long result)
    {
        return TryParseInt64Local(value, style, out result);
    }
}
