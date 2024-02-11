namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short? ToNullableInt16(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToInt16(provider, out short result) ? result : null;
    }
}
