namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ParseInt32(this string value, IFormatProvider? provider)
    {
        return int.Parse(value, provider);
    }

    public static int ParseInt32OrDefault(this string value, IFormatProvider? provider, int defaultValue = default)
    {
        bool isInt32 = TryParseInt32(value, provider, out int result);

        return isInt32 switch
        {
            true => result,
            false => defaultValue,
        };
    }

    public static bool TryParseInt32(this string value, IFormatProvider? provider, out int result)
    {
        try
        {
            result = int.Parse(value, provider);

            return true;
        }
        catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static int ParseInt(this string value, IFormatProvider? provider)
    {
        return ParseInt32(value, provider);
    }

    public static int ParseIntOrDefault(this string value, IFormatProvider? provider, int defaultValue = default)
    {
        return ParseInt32OrDefault(value, provider, defaultValue);
    }

    public static bool TryParseInt(this string value, IFormatProvider? provider, out int result)
    {
        return TryParseInt32(value, provider, out result);
    }
}
