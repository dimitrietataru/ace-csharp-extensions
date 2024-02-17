namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ToSingle(this string? @this, IFormatProvider? provider)
    {
        return Convert.ToSingle(@this, provider);
    }

    public static float ToSingleOrDefault(this string? @this, IFormatProvider? provider, float @default = default)
    {
        bool isSingle = TryConvertToSingle(@this, provider, out float result);

        return isSingle ? result : @default;
    }

    public static float? ToSingleOrNull(this string? @this, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(@this))
        {
            return null;
        }

        bool isSingle = TryConvertToSingle(@this, provider, out float result);

        return isSingle ? result : null;
    }

    public static bool TryConvertToSingle(this string? @this, IFormatProvider? provider, out float result)
    {
        try
        {
            result = Convert.ToSingle(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
        catch (OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static float ToFloat(this string? @this, IFormatProvider? provider)
    {
        return ToSingle(@this, provider);
    }

    public static float ToFloatOrDefault(this string? @this, IFormatProvider? provider, float @default = default)
    {
        return ToSingleOrDefault(@this, provider, @default);
    }

    public static bool TryConvertToFloat(this string? @this, IFormatProvider? provider, out float result)
    {
        return TryConvertToSingle(@this, provider, out result);
    }
}
