namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float ConvertToSingle(this string? value, IFormatProvider? provider)
    {
        return Convert.ToSingle(value, provider);
    }

    public static float ConvertToSingleOrDefault(this string? value, IFormatProvider provider, float defaultValue = default)
    {
        bool isSingle = TryConvertToSingle(value, provider, out float result);

        return isSingle switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static float SafeConvertToSingle(this string? value, IFormatProvider provider)
    {
        bool isSingle = TryConvertToSingle(value, provider, out float result);

        return isSingle switch
        {
            true => result,
            false => default
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

    public static float ConvertToFloat(this string? value, IFormatProvider? provider)
    {
        return ConvertToSingle(value, provider);
    }

    public static float ConvertToFloatOrDefault(this string? value, IFormatProvider provider, float defaultValue = default)
    {
        return ConvertToSingleOrDefault(value, provider, defaultValue);
    }

    public static float SafeConvertToFloat(this string? value, IFormatProvider provider)
    {
        return SafeConvertToSingle(value, provider);
    }

    public static bool TryConvertToFloat(this string? value, IFormatProvider? provider, out float result)
    {
        return TryConvertToSingle(value, provider, out result);
    }
}
