namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ConvertToUInt32Local(this string? value)
    {
        return ConvertToUInt32(value, CultureInfo.CurrentCulture);
    }

    public static uint ConvertToUInt32OrDefaultLocal(this string? value, uint defaultValue = default)
    {
        return ConvertToUInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static uint SafeConvertToUInt32Local(this string? value)
    {
        return SafeConvertToUInt32(value, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToUInt32Local(this string? value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static uint ConvertToUIntLocal(this string? value)
    {
        return ConvertToUInt32Local(value);
    }

    public static uint ConvertToUIntOrDefaultLocal(this string? value, uint defaultValue = default)
    {
        return ConvertToUInt32OrDefaultLocal(value, defaultValue);
    }

    public static uint SafeConvertToUIntLocal(this string? value)
    {
        return SafeConvertToUInt32Local(value);
    }

    public static bool TryConvertToUIntLocal(this string? value, out uint result)
    {
        return TryConvertToUInt32Local(value, out result);
    }
}
