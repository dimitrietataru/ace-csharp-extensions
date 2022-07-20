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
}
