namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint? ToNullableUInt32(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToUInt32(provider, out uint result)
                ? result
                : null;
    }

    public static uint? ToNullableUInt(this object? value, IFormatProvider? provider)
    {
        return value.ToNullableUInt32(provider);
    }
}
