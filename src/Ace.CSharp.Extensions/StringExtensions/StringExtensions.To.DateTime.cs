namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ToDateTime(this string? value, IFormatProvider? provider)
    {
        return Convert.ToDateTime(value, provider);
    }

    public static DateTime ToDateTimeOrDefault(this string? value, IFormatProvider? provider, DateTime defaultValue = default)
    {
        bool isDateTime = TryConvertToDateTime(value, provider, out var result);

        return isDateTime switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToDateTime(this string? value, IFormatProvider? provider, out DateTime result)
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

    public static DateTime ToDateTimeInvariant(this string? value)
    {
        return ToDateTime(value, CultureInfo.InvariantCulture);
    }

    public static DateTime ToDateTimeOrDefaultInvariant(this string? value, DateTime defaultValue = default)
    {
        return ToDateTimeOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDateTimeInvariant(this string? value, out DateTime result)
    {
        return TryConvertToDateTime(value, CultureInfo.InvariantCulture, out result);
    }

    public static DateTime ToDateTimeLocal(this string? value)
    {
        return ToDateTime(value, CultureInfo.CurrentCulture);
    }

    public static DateTime ToDateTimeOrDefaultLocal(this string? value, DateTime defaultValue = default)
    {
        return ToDateTimeOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDateTimeLocal(this string? value, out DateTime result)
    {
        return TryConvertToDateTime(value, CultureInfo.CurrentCulture, out result);
    }
}
