namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte ConvertToByte(this string? value, IFormatProvider? provider)
    {
        return Convert.ToByte(value, provider);
    }

    public static byte ConvertToByteOrDefault(this string? value, IFormatProvider provider, byte defaultValue = default)
    {
        bool isByte = TryConvertToByte(value, provider, out byte result);

        return isByte switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static byte SafeConvertToByte(this string? value, IFormatProvider provider)
    {
        bool isByte = TryConvertToByte(value, provider, out byte result);

        return isByte switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToByte(this string? value, IFormatProvider? provider, out byte result)
    {
        try
        {
            result = Convert.ToByte(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
