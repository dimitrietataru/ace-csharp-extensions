namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte ToByteInvariant(this string? @this)
    {
        return ToByte(@this, CultureInfo.InvariantCulture);
    }

    public static byte ToByteOrDefaultInvariant(this string? @this, byte @default = default)
    {
        return ToByteOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static byte? ToByteOrNullInvariant(this string? @this)
    {
        return ToByteOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToByteInvariant(this string? @this, out byte result)
    {
        return TryConvertToByte(@this, CultureInfo.InvariantCulture, out result);
    }
}
