namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong ConvertToUInt64Local(this string? value)
    {
        return ConvertToUInt64(value, CultureInfo.CurrentCulture);
    }

    public static ulong ConvertToUInt64OrDefaultLocal(this string? value, ulong defaultValue = default)
    {
        return ConvertToUInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static ulong SafeConvertToUInt64Local(this string? value)
    {
        return SafeConvertToUInt64(value, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToUInt64Local(this string? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static ulong ConvertToULongLocal(this string? value)
    {
        return ConvertToUInt64Local(value);
    }

    public static ulong ConvertToULongOrDefaultLocal(this string? value, ulong defaultValue = default)
    {
        return ConvertToUInt64OrDefaultLocal(value, defaultValue);
    }

    public static ulong SafeConvertToULongLocal(this string? value)
    {
        return SafeConvertToUInt64Local(value);
    }

    public static bool TryConvertToULongLocal(this string? value, out ulong result)
    {
        return TryConvertToUInt64Local(value, out result);
    }
}
