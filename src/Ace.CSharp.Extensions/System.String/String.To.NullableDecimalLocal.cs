namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static decimal? ToNullableDecimalLocal(this string? value)
    {
        return value.ToNullableDecimal(CultureInfo.CurrentCulture);
    }
}
