namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64(this object? value, IFormatProvider? provider)
    {
        return Convert.ToUInt64(value, provider);
    }

    public static ulong ToUInt64OrDefault(this object? value, IFormatProvider? provider, ulong defaultValue = default)
    {
        bool isUInt64 = TryConvertToUInt64(value, provider, out ulong result);

        return isUInt64 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToUInt64(this object? value, IFormatProvider? provider, out ulong result)
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

    public static ulong ToULong(this object? value, IFormatProvider? provider)
    {
        return ToUInt64(value, provider);
    }

    public static ulong ToULongOrDefault(this object? value, IFormatProvider? provider, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToULong(this object? value, IFormatProvider? provider, out ulong result)
    {
        return TryConvertToUInt64(value, provider, out result);
    }
}
