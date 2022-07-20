namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
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
}
