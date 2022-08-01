namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort ToUInt16(this string? value, IFormatProvider? provider)
    {
        return Convert.ToUInt16(value, provider);
    }

    public static ushort ToUInt16OrDefault(this string? value, IFormatProvider? provider, ushort defaultValue = default)
    {
        bool isUInt16 = TryConvertToUInt16(value, provider, out ushort result);

        return isUInt16 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToUInt16(this string? value, IFormatProvider? provider, out ushort result)
    {
        try
        {
            result = Convert.ToUInt16(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static ushort ToUInt16Invariant(this string? value)
    {
        return ToUInt16(value, CultureInfo.InvariantCulture);
    }

    public static ushort ToUInt16OrDefaultInvariant(this string? value, ushort defaultValue = default)
    {
        return ToUInt16OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt16Invariant(this string? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.InvariantCulture, out result);
    }

    public static ushort ToUInt16Local(this string? value)
    {
        return ToUInt16(value, CultureInfo.CurrentCulture);
    }

    public static ushort ToUInt16OrDefaultLocal(this string? value, ushort defaultValue = default)
    {
        return ToUInt16OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt16Local(this string? value, out ushort result)
    {
        return TryConvertToUInt16(value, CultureInfo.CurrentCulture, out result);
    }
}
