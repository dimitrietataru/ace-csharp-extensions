namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime ToDateTimeInvariant(this object? value)
    {
        return ToDateTime(value, CultureInfo.InvariantCulture);
    }

    public static DateTime ToDateTimeOrDefaultInvariant(this object? value, DateTime defaultValue = default)
    {
        return ToDateTimeOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDateTimeInvariant(this object? value, out DateTime result)
    {
        return TryConvertToDateTime(value, CultureInfo.InvariantCulture, out result);
    }
}
