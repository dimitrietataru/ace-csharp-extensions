namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int? ToNullableInt32(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToInt32(provider, out int result) ? result : null;
    }

    public static int? ToNullableInt(this string? value, IFormatProvider? provider)
    {
        return value.ToNullableInt32(provider);
    }
}
