namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte ToSByte(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToSByte(@this, provider);
    }

    public static sbyte ToSByteOrDefault(this object? @this, IFormatProvider? provider, sbyte @default = default)
    {
        bool isSByte = TryConvertToSByte(@this, provider, out sbyte result);

        return isSByte ? result : @default;
    }

    public static sbyte? ToSByteOrNull(this object? @this, IFormatProvider? provider)
    {
        if (@this == null)
        {
            return null;
        }

        bool isSByte = TryConvertToSByte(@this, provider, out sbyte result);

        return isSByte ? result : null;
    }

    public static bool TryConvertToSByte(this object? @this, IFormatProvider? provider, out sbyte result)
    {
        try
        {
            result = Convert.ToSByte(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
        catch (InvalidCastException)
        {
            result = default;

            return false;
        }
        catch (OverflowException)
        {
            result = default;

            return false;
        }
    }
}
