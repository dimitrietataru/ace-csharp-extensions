namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ToDateTimeInvariant(this string? @this)
    {
        return ToDateTime(@this, CultureInfo.InvariantCulture);
    }

    public static DateTime ToDateTimeOrDefaultInvariant(this string? @this, DateTime @default = default)
    {
        return ToDateTimeOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static DateTime? ToDateTimeOrNullInvariant(this string? @this)
    {
        return ToDateTimeOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToDateTimeInvariant(this string? @this, out DateTime result)
    {
        return TryConvertToDateTime(@this, CultureInfo.InvariantCulture, out result);
    }
}
