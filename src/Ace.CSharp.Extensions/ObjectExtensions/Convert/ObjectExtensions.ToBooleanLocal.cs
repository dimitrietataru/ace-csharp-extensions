namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool ToBooleanLocal(this object? value)
    {
        return ToBoolean(value, CultureInfo.CurrentCulture);
    }

    public static bool ToBooleanOrDefaultLocal(this object? value, bool defaultValue = default)
    {
        return ToBooleanOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToBooleanLocal(this object? value, out bool result)
    {
        return TryConvertToBoolean(value, CultureInfo.CurrentCulture, out result);
    }
}
