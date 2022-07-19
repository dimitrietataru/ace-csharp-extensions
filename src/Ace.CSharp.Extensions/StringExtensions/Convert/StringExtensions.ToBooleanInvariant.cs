namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ConvertToBooleanInvariant(this string? value)
    {
        return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
    }

    public static bool ConvertToBooleanOrDefaultInvariant(this string? value, bool defaultValue = default)
    {
        bool isBoolean = TryConvertToBooleanInvariant(value, out bool result);

        return isBoolean switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool SafeConvertToBooleanInvariant(this string? value)
    {
        bool isBoolean = TryConvertToBooleanInvariant(value, out bool result);

        return isBoolean switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToBooleanInvariant(this string? value, out bool result)
    {
        try
        {
            result = Convert.ToBoolean(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
