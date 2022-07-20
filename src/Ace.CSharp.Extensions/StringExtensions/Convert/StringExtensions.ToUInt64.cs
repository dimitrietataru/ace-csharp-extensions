namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong ToUInt64(this string? value, IFormatProvider? provider)
    {
        return Convert.ToUInt64(value, provider);
    }

    public static ulong ToUInt64OrDefault(this string? value, IFormatProvider? provider, ulong defaultValue = default)
    {
        bool isUInt64 = TryConvertToUInt64(value, provider, out ulong result);

        return isUInt64 switch
        {
            true => result,
            false => defaultValue
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

    public static ulong ToULong(this string? value, IFormatProvider? provider)
    {
        return ToUInt64(value, provider);
    }

    public static ulong ToULongOrDefault(this string? value, IFormatProvider? provider, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToULong(this string? value, IFormatProvider? provider, out ulong result)
    {
        return TryConvertToUInt64(value, provider, out result);
    }
}
