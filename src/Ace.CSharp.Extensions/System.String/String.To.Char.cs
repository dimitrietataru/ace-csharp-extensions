namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char ToChar(this string @this, IFormatProvider? provider)
    {
        return Convert.ToChar(@this, provider);
    }

    public static char ToCharOrDefault(this string @this, IFormatProvider? provider, char @default = default)
    {
        bool isChar = TryConvertToChar(@this, provider, out char result);

        return isChar ? result : @default;
    }

    public static char? ToCharOrNull(this string? @this, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(@this))
        {
            return null;
        }

        bool isChar = TryConvertToChar(@this, provider, out char result);

        return isChar ? result : null;
    }

    public static bool TryConvertToChar(this string @this, IFormatProvider? provider, out char result)
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
    }
}
