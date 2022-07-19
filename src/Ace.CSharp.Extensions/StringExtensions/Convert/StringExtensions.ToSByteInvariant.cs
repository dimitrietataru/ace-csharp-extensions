namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte ConvertToSByteInvariant(this string value)
    {
        return ConvertToSByte(value, CultureInfo.InvariantCulture);
    }

    public static sbyte ConvertToSByteOrDefaultInvariant(this string value, sbyte defaultValue = default)
    {
        return ConvertToSByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static sbyte SafeConvertToSByteInvariant(this string value, IFormatProvider provider)
    {
        return SafeConvertToSByte(value, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToSByteInvariant(this string value, IFormatProvider? provider, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.InvariantCulture, out result);
    }
}
