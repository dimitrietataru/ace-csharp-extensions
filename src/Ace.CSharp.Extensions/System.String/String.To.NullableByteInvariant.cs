namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte? ToNullableByteInvariant(this string? value)
    {
        return value.ToNullableByte(CultureInfo.InvariantCulture);
    }
}
