namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ToInt64(this string? value, IFormatProvider? provider)
    {
        return Convert.ToInt64(value, provider);
    }

    public static long ToInt64OrDefault(this string? value, IFormatProvider? provider, long defaultValue = default)
    {
        bool isInt64 = TryConvertToInt64(value, provider, out long result);

        return isInt64 switch
        {
            true => result,
            false => defaultValue
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

    public static long ToLong(this string? value, IFormatProvider? provider)
    {
        return ToInt64(value, provider);
    }

    public static long ToLongOrDefault(this string? value, IFormatProvider? provider, long defaultValue = default)
    {
        return ToInt64OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToLong(this string? value, IFormatProvider? provider, out long result)
    {
        return TryConvertToInt64(value, provider, out result);
    }

    public static long ToInt64Invariant(this string? value)
    {
        return ToInt64(value, CultureInfo.InvariantCulture);
    }

    public static long ToInt64OrDefaultInvariant(this string? value, long defaultValue = default)
    {
        return ToInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt64Invariant(this string? value, out long result)
    {
        return TryConvertToInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static long ToLongLocalInvariant(this string? value)
    {
        return ToInt64Invariant(value);
    }

    public static long ToLongOrDefaultInvariant(this string? value, long defaultValue = default)
    {
        return ToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToLongInvariant(this string? value, out long result)
    {
        return TryConvertToInt64Invariant(value, out result);
    }

    public static long ToInt64Local(this string? value)
    {
        return ToInt64(value, CultureInfo.CurrentCulture);
    }

    public static long ToInt64OrDefaultLocal(this string? value, long defaultValue = default)
    {
        return ToInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt64Local(this string? value, out long result)
    {
        return TryConvertToInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static long ToLongLocal(this string? value)
    {
        return ToInt64Local(value);
    }

    public static long ToLongOrDefaultLocal(this string? value, long defaultValue = default)
    {
        return ToInt64OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToLongLocal(this string? value, out long result)
    {
        return TryConvertToInt64Local(value, out result);
    }
}
