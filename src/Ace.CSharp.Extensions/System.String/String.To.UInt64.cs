namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong ToUInt64(this string? @this, IFormatProvider? provider)
    {
        return Convert.ToUInt64(@this, provider);
    }

    public static ulong ToUInt64OrDefault(this string? @this, IFormatProvider? provider, ulong @default = default)
    {
        bool isUInt64 = TryConvertToUInt64(@this, provider, out ulong result);

        return isUInt64 ? result : @default;
    }

    public static ulong? ToUInt64OrNull(this string? @this, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(@this))
        {
            return null;
        }

        bool isUInt64 = TryConvertToUInt64(@this, provider, out ulong result);

        return isUInt64 ? result : null;
    }

    public static bool TryConvertToUInt64(this string? @this, IFormatProvider? provider, out ulong result)
    {
        try
        {
            result = Convert.ToUInt64(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
        catch (OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static ulong ToULong(this string? @this, IFormatProvider? provider)
    {
        return ToUInt64(@this, provider);
    }

    public static ulong ToULongOrDefault(this string? @this, IFormatProvider? provider, ulong @default = default)
    {
        return ToUInt64OrDefault(@this, provider, @default);
    }

    public static ulong? ToULongOrNull(this string? @this, IFormatProvider? provider)
    {
        return ToUInt64OrNull(@this, provider);
    }

    public static bool TryConvertToULong(this string? @this, IFormatProvider? provider, out ulong result)
    {
        return TryConvertToUInt64(@this, provider, out result);
    }
}
