namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ushort ToUInt16(this object? value, IFormatProvider? provider)
    {
        return Convert.ToUInt16(value, provider);
    }

    public static ushort ToUInt16OrDefault(this object? value, IFormatProvider? provider, ushort defaultValue = default)
    {
        bool isUInt16 = TryConvertToUInt16(value, provider, out ushort result);

        return isUInt16 switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToUInt16(this object? value, IFormatProvider? provider, out ushort result)
    {
        try
        {
            result = Convert.ToUInt16(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
