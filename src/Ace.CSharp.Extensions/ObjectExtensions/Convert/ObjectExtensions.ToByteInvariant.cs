namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte ToByteInvariant(this object? value)
    {
        return ToByte(value, CultureInfo.InvariantCulture);
    }

    public static byte ToByteOrDefaultInvariant(this object? value, byte defaultValue = default)
    {
        return ToByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToByteInvariant(this object? value, out byte result)
    {
        return TryConvertToByte(value, CultureInfo.InvariantCulture, out result);
    }
}
