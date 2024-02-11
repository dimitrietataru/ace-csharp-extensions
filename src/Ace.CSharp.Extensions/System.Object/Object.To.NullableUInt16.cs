namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ushort? ToNullableUInt16(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToUInt16(provider, out ushort result)
                ? result
                : null;
    }
}
