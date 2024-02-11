namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint? ToNullableUInt32(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToUInt32(provider, out uint result) ? result : null;
    }

    public static uint? ToNullableUInt(this string? value, IFormatProvider? provider)
    {
        return value.ToNullableUInt32(provider);
    }
}
