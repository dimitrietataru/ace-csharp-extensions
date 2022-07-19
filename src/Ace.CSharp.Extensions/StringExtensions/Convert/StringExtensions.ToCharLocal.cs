namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
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
