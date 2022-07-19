namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte ToByteLocal(this string? value)
    {
        return ToByte(value, CultureInfo.CurrentCulture);
    }

    public static byte ToByteOrDefaultLocal(this string? value, byte defaultValue = default)
    {
        return ToByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToByteLocal(this string? value, out byte result)
    {
        return TryConvertToByte(value, CultureInfo.CurrentCulture, out result);
    }
}
