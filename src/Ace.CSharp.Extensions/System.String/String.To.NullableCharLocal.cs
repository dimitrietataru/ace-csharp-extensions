namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static char? ToNullableCharLocal(this string? value)
    {
        return value.ToNullableChar(CultureInfo.CurrentCulture);
    }
}
