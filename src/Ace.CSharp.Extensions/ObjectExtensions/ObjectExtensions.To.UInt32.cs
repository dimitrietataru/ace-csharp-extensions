namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint ToUInt32(this object?value, IFormatProvider? provider)
    {
        return Convert.ToUInt32(value, provider);
    }

    public static uint ToUInt32OrDefault(this object?value, IFormatProvider? provider, uint defaultValue = default)
    {
        bool isUInt32 = TryConvertToUInt32(value, provider, out uint result);

        return isUInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToUInt32(this object?value, IFormatProvider? provider, out uint result)
    {
        try
        {
            result = Convert.ToUInt32(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static uint ToUInt(this object?value, IFormatProvider? provider)
    {
        return ToUInt32(value, provider);
    }

    public static uint ToUIntOrDefault(this object?value, IFormatProvider? provider, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToUInt(this object?value, IFormatProvider? provider, out uint result)
    {
        return TryConvertToUInt32(value, provider, out result);
    }

    public static uint ToUInt32Invariant(this object?value)
    {
        return ToUInt32(value, CultureInfo.InvariantCulture);
    }

    public static uint ToUInt32OrDefaultInvariant(this object?value, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt32Invariant(this object?value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static uint ToUIntInvariant(this object?value)
    {
        return ToUInt32Invariant(value);
    }

    public static uint ToUIntOrDefaultInvariant(this object?value, uint defaultValue = default)
    {
        return ToUInt32OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToUIntInvariant(this object?value, out uint result)
    {
        return TryConvertToUInt32Invariant(value, out result);
    }

    public static uint ToUInt32Local(this object?value)
    {
        return ToUInt32(value, CultureInfo.CurrentCulture);
    }

    public static uint ToUInt32OrDefaultLocal(this object?value, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt32Local(this object?value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static uint ToUIntLocal(this object?value)
    {
        return ToUInt32Local(value);
    }

    public static uint ToUIntOrDefaultLocal(this object?value, uint defaultValue = default)
    {
        return ToUInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToUIntLocal(this object?value, out uint result)
    {
        return TryConvertToUInt32Local(value, out result);
    }
}
