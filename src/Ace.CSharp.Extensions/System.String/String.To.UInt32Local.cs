namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ToUInt32Local(this string? @this)
    {
        return ToUInt32(@this, CultureInfo.CurrentCulture);
    }

    public static uint ToUInt32OrDefaultLocal(this string? @this, uint @default = default)
    {
        return ToUInt32OrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static uint? ToUInt32OrNullLocal(this string? @this)
    {
        return ToUInt32OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToUInt32Local(this string? @this, out uint result)
    {
        return TryConvertToUInt32(@this, CultureInfo.CurrentCulture, out result);
    }

    public static uint ToUIntLocal(this string? @this)
    {
        return ToUInt32Local(@this);
    }

    public static uint ToUIntOrDefaultLocal(this string? @this, uint @default = default)
    {
        return ToUInt32OrDefaultLocal(@this, @default);
    }

    public static uint? ToUIntOrNullLocal(this string? @this)
    {
        return ToUInt32OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToUIntLocal(this string? @this, out uint result)
    {
        return TryConvertToUInt32Local(@this, out result);
    }
}
