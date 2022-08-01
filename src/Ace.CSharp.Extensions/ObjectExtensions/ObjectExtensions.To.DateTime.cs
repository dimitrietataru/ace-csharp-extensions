namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime ToDateTime(this object? value, IFormatProvider? provider)
    {
        return Convert.ToDateTime(value, provider);
    }

    public static DateTime ToDateTimeOrDefault(this object? value, IFormatProvider? provider, DateTime defaultValue = default)
    {
        bool isDateTime = TryConvertToDateTime(value, provider, out var result);

        return isDateTime switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToDateTime(this object? value, IFormatProvider? provider, out DateTime result)
    {
        try
        {
            result = Convert.ToDateTime(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

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
