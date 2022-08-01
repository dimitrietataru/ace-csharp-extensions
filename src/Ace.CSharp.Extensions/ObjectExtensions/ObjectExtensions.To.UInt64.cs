namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64(this object? value, IFormatProvider? provider)
    {
        return Convert.ToUInt64(value, provider);
    }

    public static ulong ToUInt64OrDefault(this object? value, IFormatProvider? provider, ulong defaultValue = default)
    {
        bool isUInt64 = TryConvertToUInt64(value, provider, out ulong result);

        return isUInt64 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToUInt64(this object? value, IFormatProvider? provider, out ulong result)
    {
        try
        {
            result = Convert.ToUInt64(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static ulong ToULong(this object? value, IFormatProvider? provider)
    {
        return ToUInt64(value, provider);
    }

    public static ulong ToULongOrDefault(this object? value, IFormatProvider? provider, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToULong(this object? value, IFormatProvider? provider, out ulong result)
    {
        return TryConvertToUInt64(value, provider, out result);
    }

    public static ulong ToUInt64Invariant(this object? value)
    {
        return ToUInt64(value, CultureInfo.InvariantCulture);
    }

    public static ulong ToUInt64OrDefaultInvariant(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt64Invariant(this object? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static ulong ToULongInvariant(this object? value)
    {
        return ToUInt64Invariant(value);
    }

    public static ulong ToULongOrDefaultInvariant(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToULongInvariant(this object? value, out ulong result)
    {
        return TryConvertToUInt64Invariant(value, out result);
    }

    public static ulong ToUInt64Local(this object? value)
    {
        return ToUInt64(value, CultureInfo.CurrentCulture);
    }

    public static ulong ToUInt64OrDefaultLocal(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToUInt64Local(this object? value, out ulong result)
    {
        return TryConvertToUInt64(value, CultureInfo.CurrentCulture, out result);
    }

    public static ulong ToULongLocal(this object? value)
    {
        return ToUInt64Local(value);
    }

    public static ulong ToULongOrDefaultLocal(this object? value, ulong defaultValue = default)
    {
        return ToUInt64OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToULongLocal(this object? value, out ulong result)
    {
        return TryConvertToUInt64Local(value, out result);
    }
}
