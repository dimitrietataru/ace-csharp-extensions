namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint ToUInt32(this string? @this, IFormatProvider? provider)
    {
        return Convert.ToUInt32(@this, provider);
    }

    public static uint ToUInt32OrDefault(this string? @this, IFormatProvider? provider, uint @default = default)
    {
        bool isUInt32 = TryConvertToUInt32(@this, provider, out uint result);

        return isUInt32 ? result : @default;
    }

    public static uint? ToUInt32OrNull(this string? @this, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(@this))
        {
            return null;
        }

        bool isUInt32 = TryConvertToUInt32(@this, provider, out uint result);

        return isUInt32 ? result : null;
    }

    public static bool TryConvertToUInt32(this string? @this, IFormatProvider? provider, out uint result)
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
        catch (OverflowException)
        {
            result = default;

            return false;
        }
    }

    public static uint ToUInt(this string? @this, IFormatProvider? provider)
    {
        return ToUInt32(@this, provider);
    }

    public static uint ToUIntOrDefault(this string? @this, IFormatProvider? provider, uint @default = default)
    {
        return ToUInt32OrDefault(@this, provider, @default);
    }

    public static bool TryConvertToUInt(this string? @this, IFormatProvider? provider, out uint result)
    {
        return TryConvertToUInt32(@this, provider, out result);
    }
}
