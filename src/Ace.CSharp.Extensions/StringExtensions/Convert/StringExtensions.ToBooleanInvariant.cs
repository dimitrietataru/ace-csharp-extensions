namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ToBooleanInvariant(this string? value)
    {
        return ToBoolean(value, CultureInfo.InvariantCulture);
    }

    public static bool ToBooleanOrDefaultInvariant(this string? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToBooleanInvariant(this string? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.InvariantCulture, out result);
    }
}
