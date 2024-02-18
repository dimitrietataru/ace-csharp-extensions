namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ToSingleInvariant(this string? @this)
    {
        return ToSingle(@this, CultureInfo.InvariantCulture);
    }

    public static float ToSingleOrDefaultInvariant(this string? @this, float @default = default)
    {
        return ToSingleOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static float? ToSingleOrNullInvariant(this string? @this)
    {
        return ToSingleOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToSingleInvariant(this string? @this, out float result)
    {
        return TryConvertToSingle(@this, CultureInfo.InvariantCulture, out result);
    }

    public static float ToFloatLocalInvariant(this string? @this)
    {
        return ToSingleInvariant(@this);
    }

    public static float ToFloatOrDefaultInvariant(this string? @this, float @default = default)
    {
        return ToSingleOrDefaultInvariant(@this, @default);
    }

    public static float? ToFloatOrNullInvariant(this string? @this)
    {
        return ToSingleOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToFloatInvariant(this string? @this, out float result)
    {
        return TryConvertToSingleInvariant(@this, out result);
    }
}
