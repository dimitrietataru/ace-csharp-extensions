namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ToUInt32Local(this string? value)
    {
        return ToUInt32(value, CultureInfo.CurrentCulture);
    }

    public static uint ToUInt32OrDefaultLocal(this string? value, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt32Local(this string? value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static uint ToUIntLocal(this string? value)
    {
        return ToUInt32Local(value);
    }

    public static uint ToUIntOrDefaultLocal(this string? value, uint defaultValue = default)
    {
        return ToUInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToUIntLocal(this string? value, out uint result)
    {
        return TryConvertToUInt32Local(value, out result);
    }
}
