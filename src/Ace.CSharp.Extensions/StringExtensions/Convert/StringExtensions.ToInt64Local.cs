namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
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
