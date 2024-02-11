namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static long? ToNullableInt64Invariant(this string? value)
    {
        return value.ToNullableInt64(CultureInfo.InvariantCulture);
    }
}
