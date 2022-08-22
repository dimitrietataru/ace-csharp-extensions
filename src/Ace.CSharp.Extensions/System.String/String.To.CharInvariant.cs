namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char ToCharInvariant(this string @this)
    {
        return ToChar(@this, CultureInfo.InvariantCulture);
    }

    public static char ToCharOrDefaultInvariant(this string @this, char @default = default)
    {
        return ToCharOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static bool TryConvertToCharInvariant(this string @this, out char result)
    {
        return TryConvertToChar(@this, CultureInfo.InvariantCulture, out result);
    }
}
