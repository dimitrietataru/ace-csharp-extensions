namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double? ToNullableDouble(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToDouble(provider, out double result) ? result : null;
    }
}
