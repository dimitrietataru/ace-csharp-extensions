namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int? ToNullableInt32Invariant(this string? value)
    {
        return value.ToNullableInt32(CultureInfo.InvariantCulture);
    }

    public static int? ToNullableIntInvariant(this string? value)
    {
        return value.ToNullableInt32Invariant();
    }
}
