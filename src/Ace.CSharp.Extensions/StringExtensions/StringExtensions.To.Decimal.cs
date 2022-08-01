namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal ToDecimal(this string? value, IFormatProvider? provider)
    {
        return Convert.ToDecimal(value, provider);
    }

    public static decimal ToDecimalOrDefault(this string? value, IFormatProvider? provider, decimal defaultValue = default)
    {
        bool isDecimal = TryConvertToDecimal(value, provider, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue
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

    public static decimal ToDecimalInvariant(this string? value)
    {
        return ToDecimal(value, CultureInfo.InvariantCulture);
    }

    public static decimal ToDecimalOrDefaultInvariant(this string? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDecimalInvariant(this string? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.InvariantCulture, out result);
    }

    public static decimal ToDecimalLocal(this string? value)
    {
        return ToDecimal(value, CultureInfo.CurrentCulture);
    }

    public static decimal ToDecimalOrDefaultLocal(this string? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDecimalLocal(this string? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.CurrentCulture, out result);
    }
}
