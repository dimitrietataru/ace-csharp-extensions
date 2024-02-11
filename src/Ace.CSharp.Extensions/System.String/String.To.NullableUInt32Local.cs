namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static uint? ToNullableUInt32Local(this string? value)
    {
        return value.ToNullableUInt32(CultureInfo.CurrentCulture);
    }

    public static uint? ToNullableUIntLocal(this string? value)
    {
        return value.ToNullableUInt32Local();
    }
}
