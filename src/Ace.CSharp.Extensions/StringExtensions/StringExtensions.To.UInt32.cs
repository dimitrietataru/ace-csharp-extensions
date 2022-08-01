namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ToUInt32(this string? value, IFormatProvider? provider)
    {
        return Convert.ToUInt32(value, provider);
    }

    public static uint ToUInt32OrDefault(this string? value, IFormatProvider? provider, uint defaultValue = default)
    {
        bool isUInt32 = TryConvertToUInt32(value, provider, out uint result);

        return isUInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToUInt32(this string? value, IFormatProvider? provider, out uint result)
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

    public static uint ToUInt(this string? value, IFormatProvider? provider)
    {
        return ToUInt32(value, provider);
    }

    public static uint ToUIntOrDefault(this string? value, IFormatProvider? provider, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToUInt(this string? value, IFormatProvider? provider, out uint result)
    {
        return TryConvertToUInt32(value, provider, out result);
    }

    public static uint ToUInt32Invariant(this string? value)
    {
        return ToUInt32(value, CultureInfo.InvariantCulture);
    }

    public static uint ToUInt32OrDefaultInvariant(this string? value, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt32Invariant(this string? value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static uint ToUIntInvariant(this string? value)
    {
        return ToUInt32Invariant(value);
    }

    public static uint ToUIntOrDefaultInvariant(this string? value, uint defaultValue = default)
    {
        return ToUInt32OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToUIntInvariant(this string? value, out uint result)
    {
        return TryConvertToUInt32Invariant(value, out result);
    }

    public static uint ToUInt32Local(this string? value)
    {
        return ToUInt32(value, CultureInfo.CurrentCulture);
    }

    public static uint ToUInt32OrDefaultLocal(this string? value, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt32Local(this string? value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static uint ToUIntLocal(this string? value)
    {
        return ToUInt32Local(value);
    }

    public static uint ToUIntOrDefaultLocal(this string? value, uint defaultValue = default)
    {
        return ToUInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToUIntLocal(this string? value, out uint result)
    {
        return TryConvertToUInt32Local(value, out result);
    }
}
