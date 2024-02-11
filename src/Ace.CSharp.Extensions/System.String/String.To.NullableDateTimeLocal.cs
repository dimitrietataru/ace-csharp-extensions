namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime? ToNullableDateTimeLocal(this string? value)
    {
        return value.ToNullableDateTime(CultureInfo.CurrentCulture);
    }
}
