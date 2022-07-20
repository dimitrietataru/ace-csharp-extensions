namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ParseDecimal(this string value, IFormatProvider? provider)
    {
        return decimal.Parse(value, provider);
    }

    public static decimal ParseDecimal(this string value, NumberStyles style, IFormatProvider? provider)
    {
        return decimal.Parse(value, style, provider);
    }

    public static decimal ParseDecimalOrDefault(this string value, IFormatProvider? provider, decimal defaultValue = default)
    {
        bool isDecimal = TryParseDecimal(value, provider, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue,
        };
    }

    public static decimal ParseDecimalOrDefault(this string value, NumberStyles style, IFormatProvider? provider, decimal defaultValue = default)
    {
        bool isDecimal = TryParseDecimal(value, style, provider, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue,
        };
    }

    public static bool TryParseDecimal(this string value, IFormatProvider? provider, out decimal result)
    {
        try
        {
            result = decimal.Parse(value, provider);

            return true;
        }
        catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static bool TryParseDecimal(this string value, NumberStyles style, IFormatProvider? provider, out decimal result)
    {
        try
        {
            result = decimal.Parse(value, style, provider);

            return true;
        }
        catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or OverflowException)
        {
            result = default;

            return false;
        }
    }
}
