namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte? ToNullableSByte(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToSByte(provider, out sbyte result)
                ? result
                : null;
    }
}
