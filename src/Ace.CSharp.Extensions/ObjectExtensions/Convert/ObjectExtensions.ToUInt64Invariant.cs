namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64Invariant(this object? value)
    {
        return ToUInt64(value, CultureInfo.InvariantCulture);
    }

    public static ulong ToUInt64OrDefaultInvariant(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt64Invariant(this object? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static ulong ToULongInvariant(this object? value)
    {
        return ToUInt64Invariant(value);
    }

    public static ulong ToULongOrDefaultInvariant(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToULongInvariant(this object? value, out ulong result)
    {
        return TryConvertToUInt64Invariant(value, out result);
    }
}
