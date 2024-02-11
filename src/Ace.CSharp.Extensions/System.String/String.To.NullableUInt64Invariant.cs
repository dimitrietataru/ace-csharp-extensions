namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong? ToNullableUInt64Invariant(this string? value)
    {
        return value.ToNullableUInt64(CultureInfo.InvariantCulture);
    }
}
