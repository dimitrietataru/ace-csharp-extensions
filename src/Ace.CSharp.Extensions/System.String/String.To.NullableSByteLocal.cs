namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte? ToNullableSByteLocal(this string? value)
    {
        return value.ToNullableSByte(CultureInfo.CurrentCulture);
    }
}
