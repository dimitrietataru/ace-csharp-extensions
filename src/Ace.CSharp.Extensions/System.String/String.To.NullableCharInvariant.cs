namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char? ToNullableCharInvariant(this string? value)
    {
        return value.ToNullableChar(CultureInfo.InvariantCulture);
    }
}
