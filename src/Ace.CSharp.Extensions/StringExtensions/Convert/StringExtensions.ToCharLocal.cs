namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char ConvertToCharLocal(this string value)
    {
        return Convert.ToChar(value, CultureInfo.CurrentCulture);
    }

    public static char ConvertToCharOrDefaultLocal(this string value, char defaultValue = default)
    {
        bool isChar = TryConvertToCharLocal(value, out char result);

        return isChar switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static char SafeConvertToCharLocal(this string value)
    {
        bool isChar = TryConvertToCharLocal(value, out char result);

        return isChar switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToCharLocal(this string value, out char result)
    {
        try
        {
            result = Convert.ToChar(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
