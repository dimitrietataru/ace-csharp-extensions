namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ConvertToSingleLocal(this string? value)
    {
        return ConvertToSingle(value, CultureInfo.CurrentCulture);
    }

    public static float ConvertToSingleOrDefaultLocal(this string? value, float defaultValue = default)
    {
        return ConvertToSingleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static float SafeConvertToSingleLocal(this string? value)
    {
        return SafeConvertToSingle(value, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToSingleLocal(this string? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.CurrentCulture, out result);
    }

    public static float ConvertToFloatLocal(this string? value)
    {
        return ConvertToSingleLocal(value);
    }

    public static float ConvertToFloatOrDefaultLocal(this string? value, float defaultValue = default)
    {
        return ConvertToSingleOrDefaultLocal(value, defaultValue);
    }

    public static float SafeConvertToFloatLocal(this string? value)
    {
        return SafeConvertToSingleLocal(value);
    }

    public static bool TryConvertToFloatLocal(this string? value, out float result)
    {
        return TryConvertToSingleLocal(value, out result);
    }
}
