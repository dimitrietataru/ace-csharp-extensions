namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
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
}
