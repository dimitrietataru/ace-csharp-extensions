namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ToBooleanInvariant(this string? @this)
    {
        return ToBoolean(@this, CultureInfo.InvariantCulture);
    }

    public static bool ToBooleanOrDefaultInvariant(this string? @this, bool @default = default)
    {
        return ToBooleanOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static bool? ToBooleanOrNullInvariant(this string? @this)
    {
        return ToBooleanOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToBooleanInvariant(this string? @this, out bool result)
    {
        return TryConvertToBoolean(@this, CultureInfo.InvariantCulture, out result);
    }
}
