namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ToDecimalLocal(this string? @this)
    {
        return ToDecimal(@this, CultureInfo.CurrentCulture);
    }

    public static decimal ToDecimalOrDefaultLocal(this string? @this, decimal @default = default)
    {
        return ToDecimalOrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static decimal? ToDecimalOrNullLocal(this string? @this)
    {
        return ToDecimalOrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToDecimalLocal(this string? @this, out decimal result)
    {
        return TryConvertToDecimal(@this, CultureInfo.CurrentCulture, out result);
    }
}
