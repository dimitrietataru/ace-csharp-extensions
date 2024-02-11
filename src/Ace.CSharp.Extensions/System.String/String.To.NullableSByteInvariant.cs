namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte? ToNullableSByteInvariant(this string? value)
    {
        return value.ToNullableSByte(CultureInfo.InvariantCulture);
    }
}
