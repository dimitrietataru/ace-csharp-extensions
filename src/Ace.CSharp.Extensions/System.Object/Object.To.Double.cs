namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double ToDouble(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToDouble(@this, provider);
    }

    public static double ToDoubleOrDefault(this object? @this, IFormatProvider? provider, double @default = default)
    {
        bool isDouble = TryConvertToDouble(@this, provider, out double result);

        return isDouble ? result : @default;
    }

    public static double? ToDoubleOrNull(this object? @this, IFormatProvider? provider)
    {
        if (@this is null)
        {
            return null;
        }

        bool isDouble = TryConvertToDouble(@this, provider, out double result);

        return isDouble ? result : null;
    }

    public static bool TryConvertToDouble(this object? @this, IFormatProvider? provider, out double result)
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
        catch (InvalidCastException)
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
