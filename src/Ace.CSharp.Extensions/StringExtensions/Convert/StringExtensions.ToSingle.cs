namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ToSingle(this string? value, IFormatProvider? provider)
    {
        return Convert.ToSingle(value, provider);
    }

    public static float ToSingleOrDefault(this string? value, IFormatProvider? provider, float defaultValue = default)
    {
        bool isSingle = TryConvertToSingle(value, provider, out float result);

        return isSingle switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToSingle(this string? value, IFormatProvider? provider, out float result)
    {
        try
        {
            result = Convert.ToSingle(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static float ToFloat(this string? value, IFormatProvider? provider)
    {
        return ToSingle(value, provider);
    }

    public static float ToFloatOrDefault(this string? value, IFormatProvider? provider, float defaultValue = default)
    {
        return ToSingleOrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToFloat(this string? value, IFormatProvider? provider, out float result)
    {
        return TryConvertToSingle(value, provider, out result);
    }
}
