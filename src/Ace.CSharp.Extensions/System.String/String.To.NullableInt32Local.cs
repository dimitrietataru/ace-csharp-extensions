namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int? ToNullableInt32Local(this string? value)
    {
        return value.ToNullableInt32(CultureInfo.CurrentCulture);
    }

    public static int? ToNullableIntLocal(this string? value)
    {
        return value.ToNullableInt32Local();
    }
}
