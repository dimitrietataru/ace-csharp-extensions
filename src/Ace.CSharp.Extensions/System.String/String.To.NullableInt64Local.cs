namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long? ToNullableInt64Local(this string? value)
    {
        return value.ToNullableInt64(CultureInfo.CurrentCulture);
    }
}
