namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short ToInt16Local(this object? @this)
    {
        return ToInt16(@this, CultureInfo.CurrentCulture);
    }

    public static short ToInt16OrDefaultLocal(this object? @this, short @default = default)
    {
        return ToInt16OrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static bool TryConvertToInt16Local(this object? @this, out short result)
    {
        return TryConvertToInt16(@this, CultureInfo.CurrentCulture, out result);
    }
}
