namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ConvertToDateTimeInvariant(this string? value)
    {
        return Convert.ToDateTime(value, CultureInfo.InvariantCulture);
    }

    public static DateTime ConvertToDateTimeOrDefaultInvariant(this string? value, DateTime defaultValue = default)
    {
        bool isDateTime = TryConvertToDateTimeInvariant(value, out var result);

        return isDateTime switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static DateTime SafeConvertToDateTimeInvariant(this string? value)
    {
        bool isDateTime = TryConvertToDateTimeInvariant(value, out var result);

        return isDateTime switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDateTimeInvariant(this string? value, out DateTime result)
    {
        try
        {
            result = Convert.ToDateTime(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
