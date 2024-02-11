namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool? ToNullableBoolean(this string? value, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.TryConvertToBoolean(provider, out bool result) ? result : null;
    }
}
