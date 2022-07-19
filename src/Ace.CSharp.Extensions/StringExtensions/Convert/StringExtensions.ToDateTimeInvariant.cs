namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ToDateTimeInvariant(this string? value)
    {
        return ToDateTime(value, CultureInfo.InvariantCulture);
    }

    public static DateTime ToDateTimeOrDefaultInvariant(this string? value, DateTime defaultValue = default)
    {
        return ToDateTimeOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDateTimeInvariant(this string? value, out DateTime result)
    {
        return TryConvertToDateTime(value, CultureInfo.InvariantCulture, out result);
    }
}
