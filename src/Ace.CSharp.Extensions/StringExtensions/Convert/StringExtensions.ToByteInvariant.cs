namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static byte ConvertToByteInvariant(this string? value)
    {
        return Convert.ToByte(value, CultureInfo.InvariantCulture);
    }

    public static byte ConvertToByteOrDefaultInvariant(this string? value, byte defaultValue = default)
    {
        bool isByte = TryConvertToByteInvariant(value, out byte result);

        return isByte switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static byte SafeConvertToByteInvariant(this string? value)
    {
        bool isByte = TryConvertToByteInvariant(value, out byte result);

        return isByte switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToByteInvariant(this string? value, out byte result)
    {
        try
        {
            result = Convert.ToByte(value, CultureInfo.InvariantCulture);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
