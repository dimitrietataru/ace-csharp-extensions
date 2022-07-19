namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ConvertToInt64Invariant(this string? value)
    {
        return ConvertToInt64(value, CultureInfo.InvariantCulture);
    }

    public static long ConvertToInt64OrDefaultInvariant(this string? value, long defaultValue = default)
    {
        return ConvertToInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static long SafeConvertToInt64Invariant(this string? value)
    {
        return SafeConvertToInt64(value, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToInt64Invariant(this string? value, out long result)
    {
        return TryConvertToInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static long ConvertToLongLocalInvariant(this string? value)
    {
        return ConvertToInt64Invariant(value);
    }

    public static long ConvertToLongOrDefaultInvariant(this string? value, long defaultValue = default)
    {
        return ConvertToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static long SafeConvertToLongInvariant(this string? value)
    {
        return SafeConvertToInt64Invariant(value);
    }

    public static bool TryConvertToLongInvariant(this string? value, out long result)
    {
        return TryConvertToInt64Invariant(value, out result);
    }
}
