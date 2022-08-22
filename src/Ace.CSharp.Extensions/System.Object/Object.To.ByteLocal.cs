namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte ToByteLocal(this object? @this)
    {
        return ToByte(@this, CultureInfo.CurrentCulture);
    }

    public static byte ToByteOrDefaultLocal(this object? @this, byte @default = default)
    {
        return ToByteOrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static bool TryConvertToByteLocal(this object? @this, out byte result)
    {
        return TryConvertToByte(@this, CultureInfo.CurrentCulture, out result);
    }
}
