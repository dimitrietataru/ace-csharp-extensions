namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short ConvertToInt16(this string? value, IFormatProvider? provider)
    {
        return Convert.ToInt16(value, provider);
    }

    public static short ConvertToInt16OrDefault(this string? value, IFormatProvider provider, short defaultValue = default)
    {
        bool isInt16 = TryConvertToInt16(value, provider, out short result);

        return isInt16 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static short SafeConvertToInt16(this string? value, IFormatProvider provider)
    {
        bool isInt16 = TryConvertToInt16(value, provider, out short result);

        return isInt16 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt16(this string? value, IFormatProvider? provider, out short result)
    {
        try
        {
            result = Convert.ToInt16(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
