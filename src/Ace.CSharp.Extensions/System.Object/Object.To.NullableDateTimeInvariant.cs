namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime? ToNullableDateTimeInvariant(this object? value)
    {
        return value.ToNullableDateTime(CultureInfo.InvariantCulture);
    }
}
