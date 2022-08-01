namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool ToBoolean(this object? value, IFormatProvider? provider)
    {
        return Convert.ToBoolean(value, provider);
    }

    public static bool ToBooleanOrDefault(this object? value, IFormatProvider? provider, bool defaultValue = default)
    {
        bool isBoolean = TryConvertToBoolean(value, provider, out bool result);

        return isBoolean switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToBoolean(this object? value, IFormatProvider? provider, out bool result)
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

    public static bool ToBooleanInvariant(this object? value)
    {
        return ToBoolean(value, CultureInfo.InvariantCulture);
    }

    public static bool ToBooleanOrDefaultInvariant(this object? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToBooleanInvariant(this object? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.InvariantCulture, out result);
    }

    public static bool ToBooleanLocal(this object? value)
    {
        return ToBoolean(value, CultureInfo.CurrentCulture);
    }

    public static bool ToBooleanOrDefaultLocal(this object? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToBooleanLocal(this object? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.CurrentCulture, out result);
    }
}
