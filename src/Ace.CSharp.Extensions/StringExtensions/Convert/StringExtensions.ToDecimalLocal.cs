namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ConvertToDecimal(this string? value)
    {
        return Convert.ToDecimal(value, CultureInfo.CurrentCulture);
    }

    public static decimal ConvertToDecimalOrDefaultLocal(this string? value, decimal defaultValue = default)
    {
        bool isDecimal = TryConvertToDecimalLocal(value, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static decimal SafeConvertToDecimalLocal(this string? value)
    {
        bool isDecimal = TryConvertToDecimalLocal(value, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDecimalLocal(this string? value, out decimal result)
    {
        try
        {
            result = Convert.ToDecimal(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
