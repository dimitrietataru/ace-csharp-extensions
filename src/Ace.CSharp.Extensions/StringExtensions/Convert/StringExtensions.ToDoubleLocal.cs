namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ConvertToDoubleLocal(this string? value)
    {
        return Convert.ToDouble(value, CultureInfo.CurrentCulture);
    }

    public static double ConvertToDoubleOrDefaultLocal(this string? value, double defaultValue = default)
    {
        bool isDouble = TryConvertToDoubleLocal(value, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static double SafeConvertToDoubleLocal(this string? value)
    {
        bool isDouble = TryConvertToDoubleLocal(value, out double result);

        return isDouble switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDoubleLocal(this string? value, out double result)
    {
        try
        {
            result = Convert.ToDouble(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
