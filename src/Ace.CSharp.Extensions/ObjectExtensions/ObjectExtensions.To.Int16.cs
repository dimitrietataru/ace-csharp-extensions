namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short ToInt16(this object? value, IFormatProvider? provider)
    {
        return Convert.ToInt16(value, provider);
    }

    public static short ToInt16OrDefault(this object? value, IFormatProvider? provider, short defaultValue = default)
    {
        bool isInt16 = TryConvertToInt16(value, provider, out short result);

        return isInt16 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToInt16(this object? value, IFormatProvider? provider, out short result)
    {
        try
        {
            result = Convert.ToInt16(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static short ToInt16Invariant(this object? value)
    {
        return ToInt16(value, CultureInfo.InvariantCulture);
    }

    public static short ToInt16OrDefaultInvariant(this object? value, short defaultValue = default)
    {
        return ToInt16OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt16Invariant(this object? value, out short result)
    {
        return TryConvertToInt16(value, CultureInfo.InvariantCulture, out result);
    }

    public static short ToInt16Local(this object? value)
    {
        return ToInt16(value, CultureInfo.CurrentCulture);
    }

    public static short ToInt16OrDefaultLocal(this object? value, short defaultValue = default)
    {
        return ToInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt16Local(this object? value, out short result)
    {
        return TryConvertToInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
