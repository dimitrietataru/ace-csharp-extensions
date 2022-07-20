namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ParseDecimalLocal(this string value)
    {
        return ParseDecimal(value, CultureInfo.CurrentCulture);
    }

    public static decimal ParseDecimalLocal(this string value, NumberStyles style)
    {
        return ParseDecimal(value, style, CultureInfo.CurrentCulture);
    }

    public static decimal ParseDecimalOrDefaultLocal(this string value, decimal defaultValue = default)
    {
        return ParseDecimalOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static decimal ParseDecimalOrDefaultLocal(this string value, NumberStyles style, decimal defaultValue = default)
    {
        return ParseDecimalOrDefault(value, style, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryParseDecimalLocal(this string value, out decimal result)
    {
        return TryParseDecimal(value, CultureInfo.CurrentCulture, out result);
    }

    public static bool TryParseDecimalLocal(this string value, NumberStyles style, out decimal result)
    {
        return TryParseDecimal(value, style, CultureInfo.CurrentCulture, out result);
    }
}
