namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static long ToInt64(this object? value, IFormatProvider? provider)
    {
        return Convert.ToInt64(value, provider);
    }

    public static long ToInt64OrDefault(this object? value, IFormatProvider? provider, long defaultValue = default)
    {
        bool isInt64 = TryConvertToInt64(value, provider, out long result);

        return isInt64 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToInt64(this object? value, IFormatProvider? provider, out long result)
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

    public static long ToLong(this object? value, IFormatProvider? provider)
    {
        return ToInt64(value, provider);
    }

    public static long ToLongOrDefault(this object? value, IFormatProvider? provider, long defaultValue = default)
    {
        return ToInt64OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToLong(this object? value, IFormatProvider? provider, out long result)
    {
        return TryConvertToInt64(value, provider, out result);
    }
}
