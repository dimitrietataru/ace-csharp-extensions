namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static int ToInt32(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToInt32(@this, provider);
    }

    public static int ToInt32OrDefault(this object? @this, IFormatProvider? provider, int @default = default)
    {
        bool isInt32 = TryConvertToInt32(@this, provider, out int result);

        return isInt32 ? result : @default;
    }

    public static bool TryConvertToInt32(this object? @this, IFormatProvider? provider, out int result)
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

    public static int ToInt(this object? @this, IFormatProvider? provider)
    {
        return ToInt32(@this, provider);
    }

    public static int ToIntOrDefault(this object? @this, IFormatProvider? provider, int @default = default)
    {
        return ToInt32OrDefault(@this, provider, @default);
    }

    public static bool TryConvertToInt(this object? @this, IFormatProvider? provider, out int result)
    {
        return TryConvertToInt32(@this, provider, out result);
    }
}
