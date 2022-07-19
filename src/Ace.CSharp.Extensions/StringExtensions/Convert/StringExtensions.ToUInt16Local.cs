namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort ConvertToUInt16Local(this string? value)
    {
        return ConvertToUInt16(value, CultureInfo.CurrentCulture);
    }

    public static ushort ConvertToUInt16OrDefaultLocal(this string? value, ushort defaultValue = default)
    {
        return ConvertToUInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static ushort SafeConvertToUInt16Local(this string? value)
    {
        return SafeConvertToUInt16(value, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToUInt16Local(this string? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
