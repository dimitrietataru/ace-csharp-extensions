namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong ToUInt64Invariant(this string? @this)
    {
        return ToUInt64(@this, CultureInfo.InvariantCulture);
    }

    public static ulong ToUInt64OrDefaultInvariant(this string? @this, ulong @default = default)
    {
        return ToUInt64OrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static ulong? ToUInt64OrNullInvariant(this string? @this)
    {
        return ToUInt64OrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToUInt64Invariant(this string? @this, out ulong result)
    {
        return TryConvertToUInt64(@this, CultureInfo.InvariantCulture, out result);
    }

    public static ulong ToULongLocalInvariant(this string? @this)
    {
        return ToUInt64Invariant(@this);
    }

    public static ulong ToULongOrDefaultInvariant(this string? @this, ulong @default = default)
    {
        return ToUInt64OrDefaultInvariant(@this, @default);
    }

    public static ulong? ToULongOrNullInvariant(this string? @this)
    {
        return ToUInt64OrNullInvariant(@this);
    }

    public static bool TryConvertToULongInvariant(this string? @this, out ulong result)
    {
        return TryConvertToUInt64Invariant(@this, out result);
    }
}
