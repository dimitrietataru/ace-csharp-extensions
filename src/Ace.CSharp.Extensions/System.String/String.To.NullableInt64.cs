namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long? ToNullableInt64(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToInt64(provider, out long result) ? result : null;
    }
}
