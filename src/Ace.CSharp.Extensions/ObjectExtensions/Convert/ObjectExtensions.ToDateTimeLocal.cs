namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime ToDateTimeLocal(this object? value)
    {
        return ToDateTime(value, CultureInfo.CurrentCulture);
    }

    public static DateTime ToDateTimeOrDefaultLocal(this object? value, DateTime defaultValue = default)
    {
        return ToDateTimeOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDateTimeLocal(this object? value, out DateTime result)
    {
        return TryConvertToDateTime(value, CultureInfo.CurrentCulture, out result);
    }
}
