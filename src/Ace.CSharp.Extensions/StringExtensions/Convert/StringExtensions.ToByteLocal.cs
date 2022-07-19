namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte ConvertToByteLocal(this string? value)
    {
        return Convert.ToByte(value, CultureInfo.CurrentCulture);
    }

    public static byte ConvertToByteOrDefaultLocal(this string? value, byte defaultValue = default)
    {
        bool isByte = TryConvertToByteLocal(value, out byte result);

        return isByte switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static byte SafeConvertToByteLocal(this string? value)
    {
        bool isByte = TryConvertToByteLocal(value, out byte result);

        return isByte switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToByteLocal(this string? value, out byte result)
    {
        try
        {
            result = Convert.ToByte(value, CultureInfo.CurrentCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
