namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ParseInt32Local(this string value)
    {
        return ParseInt32(value, CultureInfo.CurrentCulture);
    }

    public static int ParseInt32OrDefaultLocal(this string value, int defaultValue = default)
    {
        return ParseInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryParseInt32Local(this string value, out int result)
    {
        return TryParseInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static int ParseIntLocal(this string value)
    {
        return ParseInt32Local(value);
    }

    public static int ParseIntOrDefaultLocal(this string value, int defaultValue = default)
    {
        return ParseInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryParseIntLocal(this string value, out int result)
    {
        return TryParseInt32Local(value, out result);
    }
}
