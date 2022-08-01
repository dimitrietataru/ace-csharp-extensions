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

    public static bool ToBooleanInvariant(this string? value)
    {
        return ToBoolean(value, CultureInfo.InvariantCulture);
    }

    public static bool ToBooleanOrDefaultInvariant(this string? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToBooleanInvariant(this string? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.InvariantCulture, out result);
    }

    public static bool ToBooleanLocal(this string? value)
    {
        return ToBoolean(value, CultureInfo.CurrentCulture);
    }

    public static bool ToBooleanOrDefaultLocal(this string? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToBooleanLocal(this string? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.CurrentCulture, out result);
    }
}
