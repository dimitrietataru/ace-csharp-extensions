namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint? ToNullableUInt32Invariant(this string? value)
    {
        return value.ToNullableUInt32(CultureInfo.InvariantCulture);
    }

    public static uint? ToNullableUIntInvariant(this string? value)
    {
        return value.ToNullableUInt32Invariant();
    }
}
