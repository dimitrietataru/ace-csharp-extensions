namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ulong? ToNullableUInt64Local(this string? value)
    {
        return value.ToNullableUInt64(CultureInfo.CurrentCulture);
    }
}
