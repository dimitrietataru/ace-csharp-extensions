namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ConvertToInt32Local(this string? value)
    {
        return Convert.ToInt32(value, CultureInfo.CurrentCulture);
    }

    public static int ConvertToInt32OrDefaultLocal(this string? value, int defaultValue = default)
    {
        bool isInt32 = TryConvertToInt32Local(value, out int result);

        return isInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static int SafeConvertToInt32Local(this string? value)
    {
        bool isInt32 = TryConvertToInt32Local(value, out int result);

        return isInt32 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt32Local(this string? value, out int result)
    {
        try
        {
            result = Convert.ToInt32(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static int ConvertToIntLocal(this string? value)
    {
        return ConvertToInt32Local(value);
    }

    public static int ConvertToIntOrDefaultLocal(this string? value, int defaultValue = default)
    {
        return ConvertToInt32OrDefaultLocal(value, defaultValue);
    }

    public static int SafeConvertToIntLocal(this string? value)
    {
        return SafeConvertToInt32Local(value);
    }

    public static bool TryConvertToIntLocal(this string? value, out int result)
    {
        return TryConvertToInt32Local(value, out result);
    }
}
