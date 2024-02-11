namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime? ToNullableDateTimeInvariant(this string? value)
    {
        return value.ToNullableDateTime(CultureInfo.InvariantCulture);
    }
}
