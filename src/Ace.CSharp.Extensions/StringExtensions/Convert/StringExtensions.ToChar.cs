namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char ConvertToChar(this string value, IFormatProvider? provider)
    {
        return Convert.ToChar(value, provider);
    }

    public static char ConvertToCharOrDefault(this string value, IFormatProvider provider, char defaultValue = default)
    {
        bool isChar = TryConvertToChar(value, provider, out char result);

        return isChar switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static char SafeConvertToChar(this string value, IFormatProvider provider)
    {
        bool isChar = TryConvertToChar(value, provider, out char result);

        return isChar switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToChar(this string value, IFormatProvider? provider, out char result)
    {
        try
        {
            result = Convert.ToChar(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
