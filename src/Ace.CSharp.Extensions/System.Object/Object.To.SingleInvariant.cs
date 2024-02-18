namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float ToSingleInvariant(this object? @this)
    {
        return ToSingle(@this, CultureInfo.InvariantCulture);
    }

    public static float ToSingleOrDefaultInvariant(this object? @this, float @default = default)
    {
        return ToSingleOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static float? ToSingleOrNullInvariant(this object? @this)
    {
        return ToSingleOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToSingleInvariant(this object? @this, out float result)
    {
        return TryConvertToSingle(@this, CultureInfo.InvariantCulture, out result);
    }

    public static float ToFloatLocalInvariant(this object? @this)
    {
        return ToSingleInvariant(@this);
    }

    public static float ToFloatOrDefaultInvariant(this object? @this, float @default = default)
    {
        return ToSingleOrDefaultInvariant(@this, @default);
    }

    public static float? ToFloatOrNullInvariant(this object? @this)
    {
        return ToSingleOrNullInvariant(@this);
    }

    public static bool TryConvertToFloatInvariant(this object? @this, out float result)
    {
        return TryConvertToSingleInvariant(@this, out result);
    }
}
