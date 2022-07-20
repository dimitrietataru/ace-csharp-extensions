namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short ToInt16Invariant(this string? value)
    {
        return ToInt16(value, CultureInfo.InvariantCulture);
    }

    public static short ToInt16OrDefaultInvariant(this string? value, short defaultValue = default)
    {
        return ToInt16OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt16Invariant(this string? value, out short result)
    {
        return TryConvertToInt16(value, CultureInfo.InvariantCulture, out result);
    }
}
