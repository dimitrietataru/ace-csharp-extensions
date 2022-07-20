namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short ToInt16Invariant(this object? value)
    {
        return ToInt16(value, CultureInfo.InvariantCulture);
    }

    public static short ToInt16OrDefaultInvariant(this object? value, short defaultValue = default)
    {
        return ToInt16OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt16Invariant(this object? value, out short result)
    {
        return TryConvertToInt16(value, CultureInfo.InvariantCulture, out result);
    }
}
