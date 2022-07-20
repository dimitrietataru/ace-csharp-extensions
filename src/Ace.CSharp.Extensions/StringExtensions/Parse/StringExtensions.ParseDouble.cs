namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ParseDouble(this string value, IFormatProvider? provider)
    {
        return double.Parse(value, provider);
    }

    public static double ParseDouble(this string value, NumberStyles style, IFormatProvider? provider)
    {
        return double.Parse(value, style, provider);
    }

    public static double ParseDoubleOrDefault(this string value, IFormatProvider? provider, double defaultValue = default)
    {
        bool isDouble = TryParseDouble(value, provider, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue,
        };
    }

    public static double ParseDoubleOrDefault(this string value, NumberStyles style, IFormatProvider? provider, double defaultValue = default)
    {
        bool isDouble = TryParseDouble(value, style, provider, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue,
        };
    }

    public static bool TryParseDouble(this string value, IFormatProvider? provider, out double result)
    {
        try
        {
            result = double.Parse(value, provider);

            return true;
        }
        catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static bool TryParseDouble(this string value, NumberStyles style, IFormatProvider? provider, out double result)
    {
        try
        {
            result = double.Parse(value, style, provider);

            return true;
        }
        catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or OverflowException)
        {
            result = default;

            return false;
        }
    }
}
