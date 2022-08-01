namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char ToChar(this string value, IFormatProvider? provider)
    {
        return Convert.ToChar(value, provider);
    }

    public static char ToCharOrDefault(this string value, IFormatProvider? provider, char defaultValue = default)
    {
        bool isChar = TryConvertToChar(value, provider, out char result);

        return isChar switch
        {
            true => result,
            false => defaultValue
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

    public static char ToCharInvariant(this string value)
    {
        return ToChar(value, CultureInfo.InvariantCulture);
    }

    public static char ToCharOrDefaultInvariant(this string value, char defaultValue = default)
    {
        return ToCharOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToCharInvariant(this string value, out char result)
    {
        return TryConvertToChar(value, CultureInfo.InvariantCulture, out result);
    }

    public static char ToCharLocal(this string value)
    {
        return ToChar(value, CultureInfo.CurrentCulture);
    }

    public static char ToCharOrDefaultLocal(this string value, char defaultValue = default)
    {
        return ToCharOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToCharLocal(this string value, out char result)
    {
        return TryConvertToChar(value, CultureInfo.CurrentCulture, out result);
    }
}
