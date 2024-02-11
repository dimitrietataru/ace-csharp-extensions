namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char? ToNullableCharInvariant(this object? value)
    {
        return value.ToNullableChar(CultureInfo.InvariantCulture);
    }
}
