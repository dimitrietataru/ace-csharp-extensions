namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint ToUInt32Invariant(this object? value)
    {
        return ToUInt32(value, CultureInfo.InvariantCulture);
    }

    public static uint ToUInt32OrDefaultInvariant(this object? value, uint defaultValue = default)
    {
        return ToUInt32OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToUInt32Invariant(this object? value, out uint result)
    {
        return TryConvertToUInt32(value, CultureInfo.InvariantCulture, out result);
    }

    public static uint ToUIntInvariant(this object? value)
    {
        return ToUInt32Invariant(value);
    }

    public static uint ToUIntOrDefaultInvariant(this object? value, uint defaultValue = default)
    {
        return ToUInt32OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToUIntInvariant(this object? value, out uint result)
    {
        return TryConvertToUInt32Invariant(value, out result);
    }
}
