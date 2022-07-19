namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ToBooleanLocal(this string? value)
    {
        return ToBoolean(value, CultureInfo.CurrentCulture);
    }

    public static bool ToBooleanOrDefaultLocal(this string? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToBooleanLocal(this string? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.CurrentCulture, out result);
    }
}
