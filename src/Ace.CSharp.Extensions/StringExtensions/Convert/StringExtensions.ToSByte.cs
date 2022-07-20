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
}
