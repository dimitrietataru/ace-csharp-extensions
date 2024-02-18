namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint ToUInt32(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToUInt32(@this, provider);
    }

    public static uint ToUInt32OrDefault(this object? @this, IFormatProvider? provider, uint @default = default)
    {
        bool isUInt32 = TryConvertToUInt32(@this, provider, out uint result);

        return isUInt32 ? result : @default;
    }

    public static uint? ToUInt32OrNull(this object? @this, IFormatProvider? provider)
    {
        if (@this is null)
        {
            return null;
        }

        bool isUInt32 = TryConvertToUInt32(@this, provider, out uint result);

        return isUInt32 ? result : null;
    }

    public static bool TryConvertToUInt32(this object? @this, IFormatProvider? provider, out uint result)
    {
        try
        {
            result = Convert.ToUInt32(@this, provider);

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

    public static uint ToUInt(this object? @this, IFormatProvider? provider)
    {
        return ToUInt32(@this, provider);
    }

    public static uint ToUIntOrDefault(this object? @this, IFormatProvider? provider, uint @default = default)
    {
        return ToUInt32OrDefault(@this, provider, @default);
    }

    public static uint? ToUIntOrNull(this object? @this, IFormatProvider? provider)
    {
        return ToUInt32OrNull(@this, provider);
    }

    public static bool TryConvertToUInt(this object? @this, IFormatProvider? provider, out uint result)
    {
        return TryConvertToUInt32(@this, provider, out result);
    }
}
