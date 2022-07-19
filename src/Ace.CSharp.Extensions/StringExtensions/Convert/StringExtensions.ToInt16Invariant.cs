namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short ConvertToInt16Invariant(this string? value)
    {
        return Convert.ToInt16(value, CultureInfo.InvariantCulture);
    }

    public static short ConvertToInt16OrDefaultInvariant(this string? value, short defaultValue = default)
    {
        bool isInt16 = TryConvertToInt16Invariant(value, out short result);

        return isInt16 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static short SafeConvertToInt16Invariant(this string? value)
    {
        bool isInt16 = TryConvertToInt16Invariant(value, out short result);

        return isInt16 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt16Invariant(this string? value, out short result)
    {
        try
        {
            result = Convert.ToInt16(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
