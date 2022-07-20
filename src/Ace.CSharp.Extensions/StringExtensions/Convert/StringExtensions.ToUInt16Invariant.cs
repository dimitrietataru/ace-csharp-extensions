namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort ToUInt16Invariant(this string? value)
    {
        return ToUInt16(value, CultureInfo.InvariantCulture);
    }

    public static ushort ToUInt16OrDefaultInvariant(this string? value, ushort defaultValue = default)
    {
        return ToUInt16OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt16Invariant(this string? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.InvariantCulture, out result);
    }
}
