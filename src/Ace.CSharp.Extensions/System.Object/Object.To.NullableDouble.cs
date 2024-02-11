namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double? ToNullableDouble(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToDouble(provider, out double result)
                ? result
                : null;
    }
}
