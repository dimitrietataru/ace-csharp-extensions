namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float ToSingle(this object? value, IFormatProvider? provider)
    {
        return Convert.ToSingle(value, provider);
    }

    public static float ToSingleOrDefault(this object? value, IFormatProvider? provider, float defaultValue = default)
    {
        bool isSingle = TryConvertToSingle(value, provider, out float result);

        return isSingle switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToSingle(this object? value, IFormatProvider? provider, out float result)
    {
        try
        {
            result = Convert.ToSingle(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }

    public static float ToFloat(this object? value, IFormatProvider? provider)
    {
        return ToSingle(value, provider);
    }

    public static float ToFloatOrDefault(this object? value, IFormatProvider? provider, float defaultValue = default)
    {
        return ToSingleOrDefault(value, provider, defaultValue);
    }

    public static bool TryConvertToFloat(this object? value, IFormatProvider? provider, out float result)
    {
        return TryConvertToSingle(value, provider, out result);
    }
}
