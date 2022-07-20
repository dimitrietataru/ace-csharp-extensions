namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ToInt32Invariant(this string? value)
    {
        return ToInt32(value, CultureInfo.InvariantCulture);
    }

    public static int ToInt32OrDefaultInvariant(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt32Invariant(this string? value, out int result)
    {
        return TryConvertToInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static int ToIntInvariant(this string? value)
    {
        return ToInt32Invariant(value);
    }

    public static int ToIntOrDefaultInvariant(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToIntInvariant(this string? value, out int result)
    {
        return TryConvertToInt32Invariant(value, out result);
    }
}
