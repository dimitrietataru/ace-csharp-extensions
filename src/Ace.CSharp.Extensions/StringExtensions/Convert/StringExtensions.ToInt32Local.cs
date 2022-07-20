namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ToInt32Local(this string? value)
    {
        return ToInt32(value, CultureInfo.CurrentCulture);
    }

    public static int ToInt32OrDefaultLocal(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt32Local(this string? value, out int result)
    {
        return TryConvertToInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static int ToIntLocal(this string? value)
    {
        return ToInt32Local(value);
    }

    public static int ToIntOrDefaultLocal(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToIntLocal(this string? value, out int result)
    {
        return TryConvertToInt32Local(value, out result);
    }
}
