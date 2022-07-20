namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float ToSingleInvariant(this object? value)
    {
        return ToSingle(value, CultureInfo.InvariantCulture);
    }

    public static float ToSingleOrDefaultInvariant(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToSingleInvariant(this object? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.InvariantCulture, out result);
    }

    public static float ToFloatInvariant(this object? value)
    {
        return ToSingleInvariant(value);
    }

    public static float ToFloatOrDefaultInvariant(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToFloatInvariant(this object? value, out float result)
    {
        return TryConvertToSingleInvariant(value, out result);
    }
}
