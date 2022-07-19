namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong ConvertToUInt64Invariant(this string? value)
    {
        return ConvertToUInt64(value, CultureInfo.InvariantCulture);
    }

    public static ulong ConvertToUInt64OrDefaultInvariant(this string? value, ulong defaultValue = default)
    {
        return ConvertToUInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static ulong SafeConvertToUInt64Invariant(this string? value)
    {
        return SafeConvertToUInt64(value, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToUInt64Invariant(this string? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static ulong ConvertToULongInvariant(this string? value)
    {
        return ConvertToUInt64Invariant(value);
    }

    public static ulong ConvertToULongOrDefaultInvariant(this string? value, ulong defaultValue = default)
    {
        return ConvertToUInt64OrDefaultInvariant(value, defaultValue);
    }

    public static ulong SafeConvertToULongInvariant(this string? value)
    {
        return SafeConvertToUInt64Invariant(value);
    }

    public static bool TryConvertToULongInvariant(this string? value, out ulong result)
    {
        return TryConvertToUInt64Invariant(value, out result);
    }
}
