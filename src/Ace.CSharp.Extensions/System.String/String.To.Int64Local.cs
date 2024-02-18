namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long ToInt64Local(this string? @this)
    {
        return ToInt64(@this, CultureInfo.CurrentCulture);
    }

    public static long ToInt64OrDefaultLocal(this string? @this, long @default = default)
    {
        return ToInt64OrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static long? ToInt64OrNullLocal(this string? @this)
    {
        return ToInt64OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToInt64Local(this string? @this, out long result)
    {
        return TryConvertToInt64(@this, CultureInfo.CurrentCulture, out result);
    }

    public static long ToLongLocal(this string? @this)
    {
        return ToInt64Local(@this);
    }

    public static long ToLongOrDefaultLocal(this string? @this, long @default = default)
    {
        return ToInt64OrDefaultLocal(@this, @default);
    }

    public static long? ToLongOrNullLocal(this string? @this)
    {
        return ToInt64OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToLongLocal(this string? @this, out long result)
    {
        return TryConvertToInt64Local(@this, out result);
    }
}
