namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ToDecimalInvariant(this string? value)
    {
        return ToDecimal(value, CultureInfo.InvariantCulture);
    }

    public static decimal ToDecimalOrDefaultInvariant(this string? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDecimalInvariant(this string? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.InvariantCulture, out result);
    }
}
