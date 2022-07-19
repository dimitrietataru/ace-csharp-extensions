namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ConvertToUInt32Invariant(this string? value)
    {
        return ConvertToUInt32(value, CultureInfo.InvariantCulture);
    }

    public static uint ConvertToUInt32OrDefaultInvariant(this string? value, uint defaultValue = default)
    {
        return ConvertToUInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static uint SafeConvertToUInt32Invariant(this string? value)
    {
        return SafeConvertToUInt32(value, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToUInt32Invariant(this string? value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static uint ConvertToUIntInvariant(this string? value)
    {
        return ConvertToUInt32Invariant(value);
    }

    public static uint ConvertToUIntOrDefaultInvariant(this string? value, uint defaultValue = default)
    {
        return ConvertToUInt32OrDefaultInvariant(value, defaultValue);
    }

    public static uint SafeConvertToUIntInvariant(this string? value)
    {
        return SafeConvertToUInt32Invariant(value);
    }

    public static bool TryConvertToUIntInvariant(this string? value, out uint result)
    {
        return TryConvertToUInt32Invariant(value, out result);
    }
}
