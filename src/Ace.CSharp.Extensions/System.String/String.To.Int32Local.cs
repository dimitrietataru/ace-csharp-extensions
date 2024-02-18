namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ToInt32Local(this string? @this)
    {
        return ToInt32(@this, CultureInfo.CurrentCulture);
    }

    public static int ToInt32OrDefaultLocal(this string? @this, int @default = default)
    {
        return ToInt32OrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static int? ToInt32OrNullLocal(this string? @this)
    {
        return ToInt32OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToInt32Local(this string? @this, out int result)
    {
        return TryConvertToInt32(@this, CultureInfo.CurrentCulture, out result);
    }

    public static int ToIntLocal(this string? @this)
    {
        return ToInt32Local(@this);
    }

    public static int ToIntOrDefaultLocal(this string? @this, int @default = default)
    {
        return ToInt32OrDefaultLocal(@this, @default);
    }

    public static int? ToIntOrNullLocal(this string? @this)
    {
        return ToInt32OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToIntLocal(this string? @this, out int result)
    {
        return TryConvertToInt32Local(@this, out result);
    }
}
