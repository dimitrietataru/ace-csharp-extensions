namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ToDateTimeLocal(this string? value)
    {
        return ToDateTime(value, CultureInfo.CurrentCulture);
    }

    public static DateTime ToDateTimeOrDefaultLocal(this string? value, DateTime defaultValue = default)
    {
        return ToDateTimeOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDateTimeLocal(this string? value, out DateTime result)
    {
        return TryConvertToDateTime(value, CultureInfo.CurrentCulture, out result);
    }
}
