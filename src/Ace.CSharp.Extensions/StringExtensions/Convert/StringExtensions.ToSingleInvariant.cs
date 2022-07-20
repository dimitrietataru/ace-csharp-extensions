namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ToSingleInvariant(this string? value)
    {
        return ToSingle(value, CultureInfo.InvariantCulture);
    }

    public static float ToSingleOrDefaultInvariant(this string? value, float defaultValue = default)
    {
        return ToSingleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToSingleInvariant(this string? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.InvariantCulture, out result);
    }

    public static float ToFloatInvariant(this string? value)
    {
        return ToSingleInvariant(value);
    }

    public static float ToFloatOrDefaultInvariant(this string? value, float defaultValue = default)
    {
        return ToSingleOrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToFloatInvariant(this string? value, out float result)
    {
        return TryConvertToSingleInvariant(value, out result);
    }
}
