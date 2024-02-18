namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte ToByteInvariant(this object? @this)
    {
        return ToByte(@this, CultureInfo.InvariantCulture);
    }

    public static byte ToByteOrDefaultInvariant(this object? @this, byte @default = default)
    {
        return ToByteOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static byte? ToByteOrNullInvariant(this object? @this)
    {
        return ToByteOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToByteInvariant(this object? @this, out byte result)
    {
        return TryConvertToByte(@this, CultureInfo.InvariantCulture, out result);
    }
}
