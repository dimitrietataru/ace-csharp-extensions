namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float? ToNullableSingle(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToSingle(provider, out float result)
                ? result
                : null;
    }
}
