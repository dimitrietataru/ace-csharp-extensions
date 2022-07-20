namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte ConvertToSByteInvariant(this string value)
    {
        return ToSByte(value, CultureInfo.InvariantCulture);
    }

    public static sbyte ConvertToSByteOrDefaultInvariant(this string value, sbyte defaultValue = default)
    {
        return ToSByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToSByteInvariant(this string value, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.InvariantCulture, out result);
    }
}
