namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte ToSByteLocal(this string value)
    {
        return ToSByte(value, CultureInfo.CurrentCulture);
    }

    public static sbyte ToSByteOrDefaultLocal(this string value, sbyte defaultValue = default)
    {
        return ToSByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToSByteLocal(this string value, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.CurrentCulture, out result);
    }
}
