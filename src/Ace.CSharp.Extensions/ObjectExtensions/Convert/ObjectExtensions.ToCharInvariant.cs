namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char ToCharInvariant(this object? value)
    {
        return ToChar(value, CultureInfo.InvariantCulture);
    }

    public static char ToCharOrDefaultInvariant(this object? value, char defaultValue = default)
    {
        return ToCharOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToCharInvariant(this object? value, out char result)
    {
        return TryConvertToChar(value, CultureInfo.InvariantCulture, out result);
    }
}
