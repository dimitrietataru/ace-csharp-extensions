namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double ToDouble(this string? @this, IFormatProvider? provider)
    {
        return Convert.ToDouble(@this, provider);
    }

    public static double ToDoubleOrDefault(this string? @this, IFormatProvider? provider, double @default = default)
    {
        bool isDouble = TryConvertToDouble(@this, provider, out double result);

        return isDouble ? result : @default;
    }

    public static bool TryConvertToDouble(this string? @this, IFormatProvider? provider, out double result)
    {
        try
        {
            result = Convert.ToDouble(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
        catch (OverflowException)
        {
            result = default;

            return false;
        }
    }
}
