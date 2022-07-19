namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ConvertToDecimal(this string? value, IFormatProvider? provider)
    {
        return Convert.ToDecimal(value, provider);
    }

    public static decimal ConvertToDecimalOrDefault(this string? value, IFormatProvider provider, decimal defaultValue = default)
    {
        bool isDecimal = TryConvertToDecimal(value, provider, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static decimal SafeConvertToDecimal(this string? value, IFormatProvider provider)
    {
        bool isDecimal = TryConvertToDecimal(value, provider, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDecimal(this string? value, IFormatProvider? provider, out decimal result)
    {
        try
        {
            result = Convert.ToDecimal(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
