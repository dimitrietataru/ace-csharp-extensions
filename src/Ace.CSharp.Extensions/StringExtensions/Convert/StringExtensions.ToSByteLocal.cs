namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte ConvertToSByteLocal(this string value)
    {
        return ConvertToSByte(value, CultureInfo.CurrentCulture);
    }

    public static sbyte ConvertToSByteOrDefaultLocal(this string value, sbyte defaultValue = default)
    {
        return ConvertToSByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static sbyte SafeConvertToSByteLocal(this string value, IFormatProvider provider)
    {
        return SafeConvertToSByte(value, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToSByteLocal(this string value, IFormatProvider? provider, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.CurrentCulture, out result);
    }
}
