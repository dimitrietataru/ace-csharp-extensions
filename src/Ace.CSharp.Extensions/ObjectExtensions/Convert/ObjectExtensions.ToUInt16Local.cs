namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ushort ToUInt16Local(this object? value)
    {
        return ToUInt16(value, CultureInfo.CurrentCulture);
    }

    public static ushort ToUInt16OrDefaultLocal(this object? value, ushort defaultValue = default)
    {
        return ToUInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt16Local(this object? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
