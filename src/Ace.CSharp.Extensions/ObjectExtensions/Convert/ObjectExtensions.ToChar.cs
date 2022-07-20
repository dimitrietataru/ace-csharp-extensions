namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char ToChar(this object? value, IFormatProvider? provider)
    {
        return Convert.ToChar(value, provider);
    }

    public static char ToCharOrDefault(this object? value, IFormatProvider? provider, char defaultValue = default)
    {
        bool isChar = TryConvertToChar(value, provider, out char result);

        return isChar switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToChar(this object? value, IFormatProvider? provider, out char result)
    {
        try
        {
            result = Convert.ToChar(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
