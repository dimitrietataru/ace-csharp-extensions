namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ParseDecimalInvariant(this string value)
    {
        return ParseDecimal(value, CultureInfo.InvariantCulture);
    }

    public static decimal ParseDecimalInvariant(this string value, NumberStyles style)
    {
        return ParseDecimal(value, style, CultureInfo.InvariantCulture);
    }

    public static decimal ParseDecimalOrDefaultInvariant(this string value, decimal defaultValue = default)
    {
        return ParseDecimalOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static decimal ParseDecimalOrDefaultInvariant(this string value, NumberStyles style, decimal defaultValue = default)
    {
        return ParseDecimalOrDefault(value, style, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryParseDecimalInvariant(this string value, out decimal result)
    {
        return TryParseDecimal(value, CultureInfo.InvariantCulture, out result);
    }

    public static bool TryParseDecimalInvariant(this string value, NumberStyles style, out decimal result)
    {
        return TryParseDecimal(value, style, CultureInfo.InvariantCulture, out result);
    }
}
