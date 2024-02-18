namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64Invariant(this object? @this)
    {
        return ToUInt64(@this, CultureInfo.InvariantCulture);
    }

    public static ulong ToUInt64OrDefaultInvariant(this object? @this, ulong @default = default)
    {
        return ToUInt64OrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static ulong? ToUInt64OrNullInvariant(this object? @this)
    {
        return ToUInt64OrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToUInt64Invariant(this object? @this, out ulong result)
    {
        return TryConvertToUInt64(@this, CultureInfo.InvariantCulture, out result);
    }

    public static ulong ToULongLocalInvariant(this object? @this)
    {
        return ToUInt64Invariant(@this);
    }

    public static ulong ToULongOrDefaultInvariant(this object? @this, ulong @default = default)
    {
        return ToUInt64OrDefaultInvariant(@this, @default);
    }

    public static ulong? ToULongOrNullInvariant(this object? @this)
    {
        return ToUInt64OrNullInvariant(@this);
    }

    public static bool TryConvertToULongInvariant(this object? @this, out ulong result)
    {
        return TryConvertToUInt64Invariant(@this, out result);
    }
}
