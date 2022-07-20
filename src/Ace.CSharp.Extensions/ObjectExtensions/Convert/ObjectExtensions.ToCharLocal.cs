namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char ToCharLocal(this object? value)
    {
        return ToChar(value, CultureInfo.CurrentCulture);
    }

    public static char ToCharOrDefaultLocal(this object? value, char defaultValue = default)
    {
        return ToCharOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToCharLocal(this object? value, out char result)
    {
        return TryConvertToChar(value, CultureInfo.CurrentCulture, out result);
    }
}
