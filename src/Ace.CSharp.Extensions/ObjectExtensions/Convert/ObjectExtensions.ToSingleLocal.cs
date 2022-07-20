namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float ToSingleLocal(this object? value)
    {
        return ToSingle(value, CultureInfo.CurrentCulture);
    }

    public static float ToSingleOrDefaultLocal(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToSingleLocal(this object? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.CurrentCulture, out result);
    }

    public static float ToFloatLocal(this object? value)
    {
        return ToSingleLocal(value);
    }

    public static float ToFloatOrDefaultLocal(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToFloatLocal(this object? value, out float result)
    {
        return TryConvertToSingleLocal(value, out result);
    }
}
