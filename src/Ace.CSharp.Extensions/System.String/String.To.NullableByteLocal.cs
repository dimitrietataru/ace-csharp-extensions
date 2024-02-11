namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte? ToNullableByteLocal(this string? value)
    {
        return value.ToNullableByte(CultureInfo.CurrentCulture);
    }
}
