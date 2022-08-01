namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int ToInt32(this string? value, IFormatProvider? provider)
    {
        return Convert.ToInt32(value, provider);
    }

    public static int ToInt32OrDefault(this string? value, IFormatProvider? provider, int defaultValue = default)
    {
        bool isInt32 = TryConvertToInt32(value, provider, out int result);

        return isInt32 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToInt32(this string? value, IFormatProvider? provider, out int result)
    {
        try
        {
            result = Convert.ToInt32(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static int ToInt(this string? value, IFormatProvider? provider)
    {
        return ToInt32(value, provider);
    }

    public static int ToIntOrDefault(this string? value, IFormatProvider? provider, int defaultValue = default)
    {
        return ToInt32OrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToInt(this string? value, IFormatProvider? provider, out int result)
    {
        return TryConvertToInt32(value, provider, out result);
    }

    public static int ToInt32Invariant(this string? value)
    {
        return ToInt32(value, CultureInfo.InvariantCulture);
    }

    public static int ToInt32OrDefaultInvariant(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt32Invariant(this string? value, out int result)
    {
        return TryConvertToInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static int ToIntInvariant(this string? value)
    {
        return ToInt32Invariant(value);
    }

    public static int ToIntOrDefaultInvariant(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToIntInvariant(this string? value, out int result)
    {
        return TryConvertToInt32Invariant(value, out result);
    }

    public static int ToInt32Local(this string? value)
    {
        return ToInt32(value, CultureInfo.CurrentCulture);
    }

    public static int ToInt32OrDefaultLocal(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt32Local(this string? value, out int result)
    {
        return TryConvertToInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static int ToIntLocal(this string? value)
    {
        return ToInt32Local(value);
    }

    public static int ToIntOrDefaultLocal(this string? value, int defaultValue = default)
    {
        return ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToIntLocal(this string? value, out int result)
    {
        return TryConvertToInt32Local(value, out result);
    }
}
