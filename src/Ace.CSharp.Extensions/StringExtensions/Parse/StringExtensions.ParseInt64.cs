namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ParseInt64(this string value, IFormatProvider? provider)
    {
        return long.Parse(value, provider);
    }

    public static long ParseInt64OrDefault(this string value, IFormatProvider? provider, long defaultValue = default)
    {
        bool isInt64 = TryParseInt64(value, provider, out long result);

        return isInt64 switch
        {
            true => result,
            false => defaultValue,
        };
    }

    public static bool TryParseInt64(this string value, IFormatProvider? provider, out long result)
    {
        try
        {
            result = long.Parse(value, provider);

            return true;
        }
        catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static long ParseLong(this string value, IFormatProvider? provider)
    {
        return ParseInt64(value, provider);
    }

    public static long ParseLongOrDefault(this string value, IFormatProvider? provider, long defaultValue = default)
    {
        return ParseInt64OrDefault(value, provider, defaultValue);
    }

    public static bool TryParseLong(this string value, IFormatProvider? provider, out long result)
    {
        return TryParseInt64(value, provider, out result);
    }
}
