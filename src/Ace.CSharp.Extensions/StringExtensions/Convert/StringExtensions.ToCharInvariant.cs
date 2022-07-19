namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char ConvertToCharInvariant(this string value)
    {
        return Convert.ToChar(value, CultureInfo.InvariantCulture);
    }

    public static char ConvertToCharOrDefaultInvariant(this string value, char defaultValue = default)
    {
        bool isChar = TryConvertToCharInvariant(value, out char result);

        return isChar switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static char SafeConvertToCharInvariant(this string value)
    {
        bool isChar = TryConvertToCharInvariant(value, out char result);

        return isChar switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToCharInvariant(this string value, out char result)
    {
        try
        {
            result = Convert.ToChar(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
