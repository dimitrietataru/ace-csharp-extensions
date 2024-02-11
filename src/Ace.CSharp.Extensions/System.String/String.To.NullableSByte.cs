namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte? ToNullableSByte(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToSByte(provider, out sbyte result) ? result : null;
    }
}
