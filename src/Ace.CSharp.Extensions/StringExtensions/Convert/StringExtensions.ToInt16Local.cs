namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short ConvertToInt16Local(this string? value)
    {
        return Convert.ToInt16(value, CultureInfo.CurrentCulture);
    }

    public static short ConvertToInt16OrDefaultLocal(this string? value, short defaultValue = default)
    {
        bool isInt16 = TryConvertToInt16Local(value, out short result);

        return isInt16 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static short SafeConvertToInt16Local(this string? value)
    {
        bool isInt16 = TryConvertToInt16Local(value, out short result);

        return isInt16 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt16Local(this string? value, out short result)
    {
        try
        {
            result = Convert.ToInt16(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
