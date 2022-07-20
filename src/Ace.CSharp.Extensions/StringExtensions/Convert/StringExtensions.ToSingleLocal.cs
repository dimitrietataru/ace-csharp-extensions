namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ToSingleLocal(this string? value)
    {
        return ToSingle(value, CultureInfo.CurrentCulture);
    }

    public static float ToSingleOrDefaultLocal(this string? value, float defaultValue = default)
    {
        return ToSingleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToSingleLocal(this string? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.CurrentCulture, out result);
    }

    public static float ToFloatLocal(this string? value)
    {
        return ToSingleLocal(value);
    }

    public static float ToFloatOrDefaultLocal(this string? value, float defaultValue = default)
    {
        return ToSingleOrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToFloatLocal(this string? value, out float result)
    {
        return TryConvertToSingleLocal(value, out result);
    }
}
