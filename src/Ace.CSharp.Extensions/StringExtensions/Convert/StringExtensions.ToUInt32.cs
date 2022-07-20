namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ToUInt32(this string? value, IFormatProvider? provider)
    {
        return Convert.ToUInt32(value, provider);
    }

    public static uint ToUInt32OrDefault(this string? value, IFormatProvider? provider, uint defaultValue = default)
    {
        bool isUInt32 = TryConvertToUInt32(value, provider, out uint result);

        return isUInt32 switch
        {
            true => result,
            false => defaultValue
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

    public static uint ToUInt(this string? value, IFormatProvider? provider)
    {
        return ToUInt32(value, provider);
    }

    public static uint ToUIntOrDefault(this string? value, IFormatProvider? provider, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToUInt(this string? value, IFormatProvider? provider, out uint result)
    {
        return TryConvertToUInt32(value, provider, out result);
    }
}
