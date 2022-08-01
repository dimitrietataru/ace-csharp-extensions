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

    public static byte ToByteInvariant(this object? value)
    {
        return ToByte(value, CultureInfo.InvariantCulture);
    }

    public static byte ToByteOrDefaultInvariant(this object? value, byte defaultValue = default)
    {
        return ToByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToByteInvariant(this object? value, out byte result)
    {
        return TryConvertToByte(value, CultureInfo.InvariantCulture, out result);
    }

    public static byte ToByteLocal(this object? value)
    {
        return ToByte(value, CultureInfo.CurrentCulture);
    }

    public static byte ToByteOrDefaultLocal(this object? value, byte defaultValue = default)
    {
        return ToByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToByteLocal(this object? value, out byte result)
    {
        return TryConvertToByte(value, CultureInfo.CurrentCulture, out result);
    }
}
