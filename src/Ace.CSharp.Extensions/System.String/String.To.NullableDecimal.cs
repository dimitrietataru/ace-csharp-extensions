namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal? ToNullableDecimal(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToDecimal(provider, out decimal result) ? result : null;
    }
}
