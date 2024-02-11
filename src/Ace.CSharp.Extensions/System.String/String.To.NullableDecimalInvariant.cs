namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal? ToNullableDecimalInvariant(this string? value)
    {
        return value.ToNullableDecimal(CultureInfo.InvariantCulture);
    }
}
