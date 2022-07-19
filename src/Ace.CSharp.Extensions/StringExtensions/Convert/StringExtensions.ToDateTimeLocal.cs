namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ConvertToDateTimeLocal(this string? value)
    {
        return Convert.ToDateTime(value, CultureInfo.CurrentCulture);
    }

    public static DateTime ConvertToDateTimeOrDefaultLocal(this string? value, DateTime defaultValue = default)
    {
        bool isDateTime = TryConvertToDateTimeLocal(value, out var result);

        return isDateTime switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static DateTime SafeConvertToDateTimeLocal(this string? value)
    {
        bool isDateTime = TryConvertToDateTimeLocal(value, out var result);

        return isDateTime switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDateTimeLocal(this string? value, out DateTime result)
    {
        try
        {
            result = Convert.ToDateTime(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
