namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte ToByteLocal(this object? value)
    {
        return ToByte(value, CultureInfo.CurrentCulture);
    }

    public static byte ToByteOrDefaultLocal(this object? value, byte defaultValue = default)
    {
        return ToByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToByteLocal(this object? value, out byte result)
    {
        return TryConvertToByte(value, CultureInfo.CurrentCulture, out result);
    }
}
