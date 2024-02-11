namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort? ToNullableUInt16(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToUInt16(provider, out ushort result) ? result : null;
    }
}
