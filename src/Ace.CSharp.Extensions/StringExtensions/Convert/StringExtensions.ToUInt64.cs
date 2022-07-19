namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong ConvertToUInt64(this string? value, IFormatProvider? provider)
    {
        return Convert.ToUInt64(value, provider);
    }

    public static ulong ConvertToUInt64OrDefault(this string? value, IFormatProvider provider, ulong defaultValue = default)
    {
        bool isUInt64 = TryConvertToUInt64(value, provider, out ulong result);

        return isUInt64 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static ulong SafeConvertToUInt64(this string? value, IFormatProvider provider)
    {
        bool isUInt64 = TryConvertToUInt64(value, provider, out ulong result);

        return isUInt64 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToUInt64(this string? value, IFormatProvider? provider, out ulong result)
    {
        try
        {
            result = Convert.ToUInt64(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static ulong ConvertToULong(this string? value, IFormatProvider? provider)
    {
        return ConvertToUInt64(value, provider);
    }

    public static ulong ConvertToULongOrDefault(this string? value, IFormatProvider provider, ulong defaultValue = default)
    {
        return ConvertToUInt64OrDefault(value, provider, defaultValue);
    }

    public static ulong SafeConvertToULong(this string? value, IFormatProvider provider)
    {
        return SafeConvertToUInt64(value, provider);
    }

    public static bool TryConvertToULong(this string? value, IFormatProvider? provider, out ulong result)
    {
        return TryConvertToUInt64(value, provider, out result);
    }
}
