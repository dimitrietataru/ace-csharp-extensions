namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime? ToNullableDateTime(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToDateTime(provider, out var result) ? result : null;
    }
}
