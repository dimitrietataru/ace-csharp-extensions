namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ConvertToBooleanLocal(this string? value)
    {
        return Convert.ToBoolean(value, CultureInfo.CurrentCulture);
    }

    public static bool ConvertToBooleanOrDefaultLocal(this string? value, bool defaultValue = default)
    {
        bool isBoolean = TryConvertToBooleanLocal(value, out bool result);

        return isBoolean switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool SafeConvertToBooleanLocal(this string? value)
    {
        bool isBoolean = TryConvertToBooleanLocal(value, out bool result);

        return isBoolean switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToBooleanLocal(this string? value, out bool result)
    {
        try
        {
            result = Convert.ToBoolean(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
