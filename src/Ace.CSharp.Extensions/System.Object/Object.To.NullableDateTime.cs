namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime? ToNullableDateTime(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToDateTime(provider, out var result)
                ? result
                : null;
    }
}
