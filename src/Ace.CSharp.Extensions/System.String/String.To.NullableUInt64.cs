namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong? ToNullableUInt64(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToUInt64(provider, out ulong result) ? result : null;
    }
}
