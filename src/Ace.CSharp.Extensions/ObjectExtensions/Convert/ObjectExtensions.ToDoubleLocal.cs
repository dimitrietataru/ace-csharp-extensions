namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double ToDoubleLocal(this object? value)
    {
        return ToDouble(value, CultureInfo.CurrentCulture);
    }

    public static double ToDoubleOrDefaultLocal(this object? value, double defaultValue = default)
    {
        return ToDoubleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDoubleLocal(this object? value, out double result)
    {
        return TryConvertToDouble(value, CultureInfo.CurrentCulture, out result);
    }
}
