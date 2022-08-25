namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ToInt32(this string? @this, IFormatProvider? provider)
    {
        return Convert.ToInt32(@this, provider);
    }

    public static int ToInt32OrDefault(this string? @this, IFormatProvider? provider, int @default = default)
    {
        bool isInt32 = TryConvertToInt32(@this, provider, out int result);

        return isInt32 ? result : @default;
    }

    public static bool TryConvertToInt32(this string? @this, IFormatProvider? provider, out int result)
    {
        try
        {
            result = Convert.ToInt32(@this, provider);

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

    public static int ToInt(this string? @this, IFormatProvider? provider)
    {
        return ToInt32(@this, provider);
    }

    public static int ToIntOrDefault(this string? @this, IFormatProvider? provider, int @default = default)
    {
        return ToInt32OrDefault(@this, provider, @default);
    }

    public static bool TryConvertToInt(this string? @this, IFormatProvider? provider, out int result)
    {
        return TryConvertToInt32(@this, provider, out result);
    }
}
