namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ConvertToInt64(this string? value, IFormatProvider? provider)
    {
        return Convert.ToInt64(value, provider);
    }

    public static long ConvertToInt64OrDefault(this string? value, IFormatProvider provider, long defaultValue = default)
    {
        bool isInt64 = TryConvertToInt64(value, provider, out long result);

        return isInt64 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static long SafeConvertToInt64(this string? value, IFormatProvider provider)
    {
        bool isInt64 = TryConvertToInt64(value, provider, out long result);

        return isInt64 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt64(this string? value, IFormatProvider? provider, out long result)
    {
        try
        {
            result = Convert.ToInt64(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static long ConvertToLong(this string? value, IFormatProvider? provider)
    {
        return ConvertToInt64(value, provider);
    }

    public static long ConvertToLongOrDefault(this string? value, IFormatProvider provider, long defaultValue = default)
    {
        return ConvertToInt64OrDefault(value, provider, defaultValue);
    }

    public static long SafeConvertToLong(this string? value, IFormatProvider provider)
    {
        return SafeConvertToInt64(value, provider);
    }

    public static bool TryConvertToLong(this string? value, IFormatProvider? provider, out long result)
    {
        return TryConvertToInt64(value, provider, out result);
    }
}
