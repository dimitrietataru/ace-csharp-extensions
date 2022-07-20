namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ToDecimal(this string? value)
    {
        return ToDecimal(value, CultureInfo.CurrentCulture);
    }

    public static decimal ToDecimalOrDefaultLocal(this string? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDecimalLocal(this string? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.CurrentCulture, out result);
    }
}
