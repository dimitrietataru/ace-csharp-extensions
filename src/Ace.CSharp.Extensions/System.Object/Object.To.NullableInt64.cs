namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static long? ToNullableInt64(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToInt64(provider, out long result)
                ? result
                : null;
    }
}
