namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte ToByte(this object? value, IFormatProvider? provider)
    {
        return Convert.ToByte(value, provider);
    }

    public static byte ToByteOrDefault(this object? value, IFormatProvider? provider, byte defaultValue = default)
    {
        bool isByte = TryConvertToByte(value, provider, out byte result);

        return isByte switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToByte(this object? value, IFormatProvider? provider, out byte result)
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
