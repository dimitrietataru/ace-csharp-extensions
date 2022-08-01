namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static sbyte ToSByte(this string value, IFormatProvider? provider)
    {
        return Convert.ToSByte(value, provider);
    }

    public static sbyte ToSByteOrDefault(this string value, IFormatProvider? provider, sbyte defaultValue = default)
    {
        bool isSByte = TryConvertToSByte(value, provider, out sbyte result);

        return isSByte switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToSByte(this string value, IFormatProvider? provider, out sbyte result)
    {
        try
        {
            result = Convert.ToSByte(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static sbyte ToSByteInvariant(this string value)
    {
        return ToSByte(value, CultureInfo.InvariantCulture);
    }

    public static sbyte ToSByteOrDefaultInvariant(this string value, sbyte defaultValue = default)
    {
        return ToSByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToSByteInvariant(this string value, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.InvariantCulture, out result);
    }

    public static sbyte ToSByteLocal(this string value)
    {
        return ToSByte(value, CultureInfo.CurrentCulture);
    }

    public static sbyte ToSByteOrDefaultLocal(this string value, sbyte defaultValue = default)
    {
        return ToSByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToSByteLocal(this string value, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.CurrentCulture, out result);
    }
}
