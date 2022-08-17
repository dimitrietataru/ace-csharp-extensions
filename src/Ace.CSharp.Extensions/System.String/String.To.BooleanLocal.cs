namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ToBooleanLocal(this string? @this)
    {
        return ToBoolean(@this, CultureInfo.CurrentCulture);
    }

    public static bool ToBooleanOrDefaultLocal(this string? @this, bool @default = default)
    {
        return ToBooleanOrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static bool TryConvertToBooleanLocal(this string? @this, out bool result)
    {
        return TryConvertToBoolean(@this, CultureInfo.CurrentCulture, out result);
    }
}
