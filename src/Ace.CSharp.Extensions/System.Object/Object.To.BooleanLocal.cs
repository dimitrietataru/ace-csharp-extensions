namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool ToBooleanLocal(this object? @this)
    {
        return ToBoolean(@this, CultureInfo.CurrentCulture);
    }

    public static bool ToBooleanOrDefaultLocal(this object? @this, bool @default = default)
    {
        return ToBooleanOrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static bool TryConvertToBooleanLocal(this object? @this, out bool result)
    {
        return TryConvertToBoolean(@this, CultureInfo.CurrentCulture, out result);
    }
}
