namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ConvertToDecimalInvariant(this string? value)
    {
        return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
    }

    public static decimal ConvertToDecimalOrDefaultInvariant(this string? value, decimal defaultValue = default)
    {
        bool isDecimal = TryConvertToDecimalInvariant(value, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static decimal SafeConvertToDecimalInvariant(this string? value)
    {
        bool isDecimal = TryConvertToDecimalInvariant(value, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDecimalInvariant(this string? value, out decimal result)
    {
        try
        {
            result = Convert.ToDecimal(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
