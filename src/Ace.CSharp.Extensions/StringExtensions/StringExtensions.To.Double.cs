namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ToDouble(this string? value, IFormatProvider? provider)
    {
        return Convert.ToDouble(value, provider);
    }

    public static double ToDoubleOrDefault(this string? value, IFormatProvider? provider, double defaultValue = default)
    {
        bool isDouble = TryConvertToDouble(value, provider, out double result);

        return isDouble switch
        {
            true => result,
            false => defaultValue
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

    public static double ToDoubleInvariant(this string? value)
    {
        return ToDouble(value, CultureInfo.InvariantCulture);
    }

    public static double ToDoubleOrDefaultInvariant(this string? value, double defaultValue = default)
    {
        return ToDoubleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDoubleInvariant(this string? value, out double result)
    {
        return TryConvertToDouble(value, CultureInfo.InvariantCulture, out result);
    }

    public static double ToDoubleLocal(this string? value)
    {
        return ToDouble(value, CultureInfo.CurrentCulture);
    }

    public static double ToDoubleOrDefaultLocal(this string? value, double defaultValue = default)
    {
        return ToDoubleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDoubleLocal(this string? value, out double result)
    {
        return TryConvertToDouble(value, CultureInfo.CurrentCulture, out result);
    }
}
