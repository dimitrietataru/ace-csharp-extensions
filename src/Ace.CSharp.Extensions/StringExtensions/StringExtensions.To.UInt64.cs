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

    public static ulong ToUInt64Invariant(this string? value)
    {
        return ToUInt64(value, CultureInfo.InvariantCulture);
    }

    public static ulong ToUInt64OrDefaultInvariant(this string? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt64Invariant(this string? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static ulong ToULongInvariant(this string? value)
    {
        return ToUInt64Invariant(value);
    }

    public static ulong ToULongOrDefaultInvariant(this string? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToULongInvariant(this string? value, out ulong result)
    {
        return TryConvertToUInt64Invariant(value, out result);
    }

    public static ulong ToUInt64Local(this string? value)
    {
        return ToUInt64(value, CultureInfo.CurrentCulture);
    }

    public static ulong ToUInt64OrDefaultLocal(this string? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt64Local(this string? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static ulong ToULongLocal(this string? value)
    {
        return ToUInt64Local(value);
    }

    public static ulong ToULongOrDefaultLocal(this string? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToULongLocal(this string? value, out ulong result)
    {
        return TryConvertToUInt64Local(value, out result);
    }
}
