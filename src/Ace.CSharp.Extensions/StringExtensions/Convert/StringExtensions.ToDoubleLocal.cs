namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ToDoubleLocal(this string? value)
    {
        return ToDouble(value, CultureInfo.CurrentCulture);
    }

    public static double ToDoubleOrDefaultLocal(this string? value, double defaultValue = default)
    {
        return ToDoubleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDoubleLocal(this string? value, out double result)
    {
        return TryConvertToDouble(value, CultureInfo.CurrentCulture, out result);
    }
}
