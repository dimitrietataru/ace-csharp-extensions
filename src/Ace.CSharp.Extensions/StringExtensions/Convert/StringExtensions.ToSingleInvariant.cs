namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ConvertToSingleInvariant(this string? value)
    {
        return ConvertToSingle(value, CultureInfo.InvariantCulture);
    }

    public static float ConvertToSingleOrDefaultInvariant(this string? value, float defaultValue = default)
    {
        return ConvertToSingleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static float SafeConvertToSingleInvariant(this string? value)
    {
        return SafeConvertToSingle(value, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToSingleInvariant(this string? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.InvariantCulture, out result);
    }

    public static float ConvertToFloatInvariant(this string? value)
    {
        return ConvertToSingleInvariant(value);
    }

    public static float ConvertToFloatOrDefaultInvariant(this string? value, float defaultValue = default)
    {
        return ConvertToSingleOrDefaultInvariant(value, defaultValue);
    }

    public static float SafeConvertToFloatInvariant(this string? value)
    {
        return SafeConvertToSingleInvariant(value);
    }

    public static bool TryConvertToFloatInvariant(this string? value, out float result)
    {
        return TryConvertToSingleInvariant(value, out result);
    }
}
