namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static int ToInt32(this object? value, IFormatProvider? provider)
    {
        return Convert.ToInt32(value, provider);
    }

    public static int ToInt32OrDefault(this object? value, IFormatProvider? provider, int defaultValue = default)
    {
        bool isInt32 = TryConvertToInt32(value, provider, out int result);

        return isInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToInt32(this object? value, IFormatProvider? provider, out int result)
    {
        try
        {
            result = Convert.ToInt32(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static int ToInt(this object? value, IFormatProvider? provider)
    {
        return ToInt32(value, provider);
    }

    public static int ToIntOrDefault(this object? value, IFormatProvider? provider, int defaultValue = default)
    {
        return ToInt32OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToInt(this object? value, IFormatProvider? provider, out int result)
    {
        return TryConvertToInt32(value, provider, out result);
    }
}
