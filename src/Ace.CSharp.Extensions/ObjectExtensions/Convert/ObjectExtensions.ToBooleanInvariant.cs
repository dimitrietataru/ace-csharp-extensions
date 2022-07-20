namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool ToBooleanInvariant(this object? value)
    {
        return ToBoolean(value, CultureInfo.InvariantCulture);
    }

    public static bool ToBooleanOrDefaultInvariant(this object? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToBooleanInvariant(this object? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.InvariantCulture, out result);
    }
}
