namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool? ToNullableBoolean(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToBoolean(provider, out bool result)
                ? result
                : null;
    }
}
