namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64Local(this object? value)
    {
        return ToUInt64(value, CultureInfo.CurrentCulture);
    }

    public static ulong ToUInt64OrDefaultLocal(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt64Local(this object? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static ulong ToULongLocal(this object? value)
    {
        return ToUInt64Local(value);
    }

    public static ulong ToULongOrDefaultLocal(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToULongLocal(this object? value, out ulong result)
    {
        return TryConvertToUInt64Local(value, out result);
    }
}
