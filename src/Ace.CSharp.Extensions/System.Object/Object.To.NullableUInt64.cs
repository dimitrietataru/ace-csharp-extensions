namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong? ToNullableUInt64(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToUInt64(provider, out ulong result)
                ? result
                : null;
    }
}
