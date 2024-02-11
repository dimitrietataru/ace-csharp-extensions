namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte? ToNullableByte(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToByte(provider, out byte result)
                ? result
                : null;
    }
}
