namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short ToInt16Invariant(this object? @this)
    {
        return ToInt16(@this, CultureInfo.InvariantCulture);
    }

    public static short ToInt16OrDefaultInvariant(this object? @this, short @default = default)
    {
        return ToInt16OrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static short? ToInt16OrNullInvariant(this object? @this)
    {
        return ToInt16OrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToInt16Invariant(this object? @this, out short result)
    {
        return TryConvertToInt16(@this, CultureInfo.InvariantCulture, out result);
    }
}
