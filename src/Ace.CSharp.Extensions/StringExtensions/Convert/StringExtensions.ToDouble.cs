namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ConvertToDouble(this string? value, IFormatProvider? provider)
    {
        return Convert.ToDouble(value, provider);
    }

    public static double ConvertToDoubleOrDefault(this string? value, IFormatProvider provider, double defaultValue = default)
    {
        bool isDouble = TryConvertToDouble(value, provider, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static double SafeConvertToDouble(this string? value, IFormatProvider provider)
    {
        bool isDouble = TryConvertToDouble(value, provider, out double result);

        return isDouble switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDouble(this string? value, IFormatProvider? provider, out double result)
    {
        try
        {
            result = Convert.ToDouble(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
