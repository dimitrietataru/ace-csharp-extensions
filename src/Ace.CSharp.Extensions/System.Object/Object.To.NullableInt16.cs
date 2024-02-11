namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short? ToNullableInt16(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToInt16(provider, out short result)
                ? result
                : null;
    }
}
