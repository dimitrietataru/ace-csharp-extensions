namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double ToDouble(this object? value, IFormatProvider? provider)
    {
        return Convert.ToDouble(value, provider);
    }

    public static double ToDoubleOrDefault(this object? value, IFormatProvider? provider, double defaultValue = default)
    {
        bool isDouble = TryConvertToDouble(value, provider, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToDouble(this object? value, IFormatProvider? provider, out double result)
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
