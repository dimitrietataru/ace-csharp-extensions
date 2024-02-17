namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char ToCharInvariant(this object? @this)
    {
        return ToChar(@this, CultureInfo.InvariantCulture);
    }

    public static char ToCharOrDefaultInvariant(this object? @this, char @default = default)
    {
        return ToCharOrDefault(@this, CultureInfo.InvariantCulture, @default);
    }

    public static char? ToCharOrNullInvariant(this object? @this)
    {
        return ToCharOrNull(@this, CultureInfo.InvariantCulture);
    }

    public static bool TryConvertToCharInvariant(this object? @this, out char result)
    {
        return TryConvertToChar(@this, CultureInfo.InvariantCulture, out result);
    }
}
