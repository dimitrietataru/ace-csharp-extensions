namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime? ToNullableDateTimeLocal(this object? value)
    {
        return value.ToNullableDateTime(CultureInfo.CurrentCulture);
    }
}
