namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ConvertToInt32Invariant(this string? value)
    {
        return Convert.ToInt32(value, CultureInfo.InvariantCulture);
    }

    public static int ConvertToInt32OrDefaultInvariant(this string? value, int defaultValue = default)
    {
        bool isInt32 = TryConvertToInt32Invariant(value, out int result);

        return isInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static int SafeConvertToInt32Invariant(this string? value)
    {
        bool isInt32 = TryConvertToInt32Invariant(value, out int result);

        return isInt32 switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToInt32Invariant(this string? value, out int result)
    {
        try
        {
            result = Convert.ToInt32(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static int ConvertToIntInvariant(this string? value)
    {
        return ConvertToInt32Invariant(value);
    }

    public static int ConvertToIntOrDefaultInvariant(this string? value, int defaultValue = default)
    {
        return ConvertToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static int SafeConvertToIntInvariant(this string? value)
    {
        return SafeConvertToInt32Invariant(value);
    }

    public static bool TryConvertToIntInvariant(this string? value, out int result)
    {
        return TryConvertToInt32Invariant(value, out result);
    }
}
