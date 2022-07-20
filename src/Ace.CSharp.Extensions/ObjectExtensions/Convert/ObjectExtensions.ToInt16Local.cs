namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short ToInt16Local(this object? value)
    {
        return ToInt16(value, CultureInfo.CurrentCulture);
    }

    public static short ToInt16OrDefaultLocal(this object? value, short defaultValue = default)
    {
        return ToInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt16Local(this object? value, out short result)
    {
        return TryConvertToInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
