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

    public static float ToSingleInvariant(this object? value)
    {
        return ToSingle(value, CultureInfo.InvariantCulture);
    }

    public static float ToSingleOrDefaultInvariant(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToSingleInvariant(this object? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.InvariantCulture, out result);
    }

    public static float ToFloatInvariant(this object? value)
    {
        return ToSingleInvariant(value);
    }

    public static float ToFloatOrDefaultInvariant(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToFloatInvariant(this object? value, out float result)
    {
        return TryConvertToSingleInvariant(value, out result);
    }

    public static float ToSingleLocal(this object? value)
    {
        return ToSingle(value, CultureInfo.CurrentCulture);
    }

    public static float ToSingleOrDefaultLocal(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToSingleLocal(this object? value, out float result)
    {
        return TryConvertToSingle(value, CultureInfo.CurrentCulture, out result);
    }

    public static float ToFloatLocal(this object? value)
    {
        return ToSingleLocal(value);
    }

    public static float ToFloatOrDefaultLocal(this object? value, float defaultValue = default)
    {
        return ToSingleOrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToFloatLocal(this object? value, out float result)
    {
        return TryConvertToSingleLocal(value, out result);
    }
}
