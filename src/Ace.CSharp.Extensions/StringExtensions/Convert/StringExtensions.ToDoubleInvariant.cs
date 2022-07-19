namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ConvertToDoubleInvariant(this string? value)
    {
        return Convert.ToDouble(value, CultureInfo.InvariantCulture);
    }

    public static double ConvertToDoubleOrDefaultInvariant(this string? value, double defaultValue = default)
    {
        bool isDouble = TryConvertToDoubleInvariant(value, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static double SafeConvertToDoubleInvariant(this string? value)
    {
        bool isDouble = TryConvertToDoubleInvariant(value, out double result);

        return isDouble switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDoubleInvariant(this string? value, out double result)
    {
        try
        {
            result = Convert.ToDouble(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
