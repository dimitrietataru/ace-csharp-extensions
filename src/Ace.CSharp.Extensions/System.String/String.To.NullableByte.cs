namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte? ToNullableByte(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToByte(provider, out byte result) ? result : null;
    }
}
