namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ConvertToInt64Local(this string? value)
    {
        return ConvertToInt64(value, CultureInfo.CurrentCulture);
    }

    public static long ConvertToInt64OrDefaultLocal(this string? value, long defaultValue = default)
    {
        return ConvertToInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static long SafeConvertToInt64Local(this string? value)
    {
        return SafeConvertToInt64(value, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToInt64Local(this string? value, out long result)
    {
        return TryConvertToInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static long ConvertToLongLocal(this string? value)
    {
        return ConvertToInt64Local(value);
    }

    public static long ConvertToLongOrDefaultLocal(this string? value, long defaultValue = default)
    {
        return ConvertToInt64OrDefaultLocal(value, defaultValue);
    }

    public static long SafeConvertToLongLocal(this string? value)
    {
        return SafeConvertToInt64Local(value);
    }

    public static bool TryConvertToLongLocal(this string? value, out long result)
    {
        return TryConvertToInt64Local(value, out result);
    }
}
