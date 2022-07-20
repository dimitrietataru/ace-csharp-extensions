namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short ToInt16Local(this string? value)
    {
        return ToInt16(value, CultureInfo.CurrentCulture);
    }

    public static short ToInt16OrDefaultLocal(this string? value, short defaultValue = default)
    {
        return ToInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt16Local(this string? value, out short result)
    {
        return TryConvertToInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
