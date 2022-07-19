namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ToBoolean(this string? value, IFormatProvider? provider)
    {
        return Convert.ToBoolean(value, provider);
    }

    public static bool ToBooleanOrDefault(this string? value, IFormatProvider? provider, bool defaultValue = default)
    {
        bool isBoolean = TryConvertToBoolean(value, provider, out bool result);

        return isBoolean switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToBoolean(this string? value, IFormatProvider? provider, out bool result)
    {
        try
        {
            result = Convert.ToBoolean(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
