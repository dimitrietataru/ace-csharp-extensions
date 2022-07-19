namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ConvertToInt32(this string? value, IFormatProvider? provider)
    {
        return Convert.ToInt32(value, provider);
    }

    public static int ConvertToInt32OrDefault(this string? value, IFormatProvider provider, int defaultValue = default)
    {
        bool isInt32 = TryConvertToInt32(value, provider, out int result);

        return isInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static int SafeConvertToInt32(this string? value, IFormatProvider provider)
    {
        bool isInt32 = TryConvertToInt32(value, provider, out int result);

        return isInt32 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt32(this string? value, IFormatProvider? provider, out int result)
    {
        try
        {
            result = Convert.ToInt32(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static int ConvertToInt(this string? value, IFormatProvider? provider)
    {
        return ConvertToInt32(value, provider);
    }

    public static int ConvertToIntOrDefault(this string? value, IFormatProvider provider, int defaultValue = default)
    {
        return ConvertToInt32OrDefault(value, provider, defaultValue);
    }

    public static int SafeConvertToInt(this string? value, IFormatProvider provider)
    {
        return SafeConvertToInt32(value, provider);
    }

    public static bool TryConvertToInt(this string? value, IFormatProvider? provider, out int result)
    {
        return TryConvertToInt32(value, provider, out result);
    }
}
