namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong ToUInt64(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToUInt64(@this, provider);
    }

    public static ulong ToUInt64OrDefault(this object? @this, IFormatProvider? provider, ulong @default = default)
    {
        bool isUInt64 = TryConvertToUInt64(@this, provider, out ulong result);

        return isUInt64 ? result : @default;
    }

    public static bool TryConvertToUInt64(this object? @this, IFormatProvider? provider, out ulong result)
    {
        try
        {
            result = Convert.ToUInt64(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
        catch (InvalidCastException)
        {
            result = default;

            return false;
        }
        catch (OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static ulong ToULong(this object? @this, IFormatProvider? provider)
    {
        return ToUInt64(@this, provider);
    }

    public static ulong ToULongOrDefault(this object? @this, IFormatProvider? provider, ulong @default = default)
    {
        return ToUInt64OrDefault(@this, provider, @default);
    }

    public static bool TryConvertToULong(this object? @this, IFormatProvider? provider, out ulong result)
    {
        return TryConvertToUInt64(@this, provider, out result);
    }
}
