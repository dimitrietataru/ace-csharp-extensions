namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static decimal ToDecimal(this object? value, IFormatProvider? provider)
    {
        return Convert.ToDecimal(value, provider);
    }

    public static decimal ToDecimalOrDefault(this object? value, IFormatProvider? provider, decimal defaultValue = default)
    {
        bool isDecimal = TryConvertToDecimal(value, provider, out decimal result);

        return isDecimal switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToDecimal(this object? value, IFormatProvider? provider, out decimal result)
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

    public static decimal ToDecimalInvariant(this object? value)
    {
        return ToDecimal(value, CultureInfo.InvariantCulture);
    }

    public static decimal ToDecimalOrDefaultInvariant(this object? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDecimalInvariant(this object? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.InvariantCulture, out result);
    }

    public static decimal ToDecimalLocal(this object? value)
    {
        return ToDecimal(value, CultureInfo.CurrentCulture);
    }

    public static decimal ToDecimalOrDefaultLocal(this object? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDecimalLocal(this object? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.CurrentCulture, out result);
    }
}
