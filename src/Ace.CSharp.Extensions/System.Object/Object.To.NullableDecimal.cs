namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static decimal? ToNullableDecimal(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToDecimal(provider, out decimal result)
                ? result
                : null;
    }
}
