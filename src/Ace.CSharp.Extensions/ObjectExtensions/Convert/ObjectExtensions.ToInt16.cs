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
}
