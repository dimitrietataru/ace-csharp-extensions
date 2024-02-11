namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char? ToNullableChar(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToChar(provider, out char result) ? result : null;
    }
}
