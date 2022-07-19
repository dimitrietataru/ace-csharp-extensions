namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort ConvertToUInt16Invariant(this string? value)
    {
        return ConvertToUInt16(value, CultureInfo.InvariantCulture);
    }

    public static ushort ConvertToUInt16OrDefaultInvariant(this string? value, ushort defaultValue = default)
    {
        return ConvertToUInt16OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static ushort SafeConvertToUInt16Invariant(this string? value)
    {
        return SafeConvertToUInt16(value, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToUInt16Invariant(this string? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.InvariantCulture, out result);
    }
}
