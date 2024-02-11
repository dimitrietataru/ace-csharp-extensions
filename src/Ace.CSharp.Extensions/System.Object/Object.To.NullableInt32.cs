namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static int? ToNullableInt32(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToInt32(provider, out int result)
                ? result
                : null;
    }

    public static int? ToNullableInt(this object? value, IFormatProvider? provider)
    {
        return value.ToNullableInt32(provider);
    }
}
