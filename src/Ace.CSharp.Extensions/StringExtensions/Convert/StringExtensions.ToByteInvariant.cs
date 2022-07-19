namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte ToByteInvariant(this string? value)
    {
        return ToByte(value, CultureInfo.InvariantCulture);
    }

    public static byte ToByteOrDefaultInvariant(this string? value, byte defaultValue = default)
    {
        return ToByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToByteInvariant(this string? value, out byte result)
    {
        return TryConvertToByte(value, CultureInfo.InvariantCulture, out result);
    }
}
