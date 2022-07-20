namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort ToUInt16Local(this string? value)
    {
        return ToUInt16(value, CultureInfo.CurrentCulture);
    }

    public static ushort ToUInt16OrDefaultLocal(this string? value, ushort defaultValue = default)
    {
        return ToUInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt16Local(this string? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
