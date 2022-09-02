namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64Local(this object? @this)
    {
        return ToUInt64(@this, CultureInfo.CurrentCulture);
    }

    public static ulong ToUInt64OrDefaultLocal(this object? @this, ulong @default = default)
    {
        return ToUInt64OrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static bool TryConvertToUInt64Local(this object? @this, out ulong result)
    {
        return TryConvertToUInt64(@this, CultureInfo.CurrentCulture, out result);
    }

    public static ulong ToULongLocal(this object? @this)
    {
        return ToUInt64Local(@this);
    }

    public static ulong ToULongOrDefaultLocal(this object? @this, ulong @default = default)
    {
        return ToUInt64OrDefaultLocal(@this, @default);
    }

    public static bool TryConvertToULongLocal(this object? @this, out ulong result)
    {
        return TryConvertToUInt64Local(@this, out result);
    }
}
