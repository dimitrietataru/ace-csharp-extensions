namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
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
}
