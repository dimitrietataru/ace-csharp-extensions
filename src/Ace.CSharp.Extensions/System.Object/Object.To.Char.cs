namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char ToChar(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToChar(@this, provider);
    }

    public static char ToCharOrDefault(this object? @this, IFormatProvider? provider, char @default = default)
    {
        bool isChar = TryConvertToChar(@this, provider, out char result);

        return isChar ? result : @default;
    }

    public static bool TryConvertToChar(this object? @this, IFormatProvider? provider, out char result)
    {
        try
        {
            result = Convert.ToChar(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
        catch (ArgumentNullException)
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
}
