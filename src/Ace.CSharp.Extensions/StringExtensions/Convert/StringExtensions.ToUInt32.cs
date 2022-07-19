namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ConvertToUInt32(this string? value, IFormatProvider? provider)
    {
        return Convert.ToUInt32(value, provider);
    }

    public static uint ConvertToUInt32OrDefault(this string? value, IFormatProvider provider, uint defaultValue = default)
    {
        bool isUInt32 = TryConvertToUInt32(value, provider, out uint result);

        return isUInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static uint SafeConvertToUInt32(this string? value, IFormatProvider provider)
    {
        bool isUInt32 = TryConvertToUInt32(value, provider, out uint result);

        return isUInt32 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToUInt32(this string? value, IFormatProvider? provider, out uint result)
    {
        try
        {
            result = Convert.ToUInt32(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static uint ConvertToUInt(this string? value, IFormatProvider? provider)
    {
        return ConvertToUInt32(value, provider);
    }

    public static uint ConvertToUIntOrDefault(this string? value, IFormatProvider provider, uint defaultValue = default)
    {
        return ConvertToUInt32OrDefault(value, provider, defaultValue);
    }

    public static uint SafeConvertToUInt(this string? value, IFormatProvider provider)
    {
        return SafeConvertToUInt32(value, provider);
    }

    public static bool TryConvertToUInt(this string? value, IFormatProvider? provider, out uint result)
    {
        return TryConvertToUInt32(value, provider, out result);
    }
}
