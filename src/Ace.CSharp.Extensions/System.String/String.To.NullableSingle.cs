namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float? ToNullableSingle(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToSingle(provider, out float result) ? result : null;
    }
}
