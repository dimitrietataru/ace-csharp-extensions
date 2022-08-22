namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool ToBoolean(this object? @this, IFormatProvider? provider)
    {
        return Convert.ToBoolean(@this, provider);
    }

    public static bool ToBooleanOrDefault(this object? @this, IFormatProvider? provider, bool @default = default)
    {
        bool isBoolean = TryConvertToBoolean(@this, provider, out bool result);

        return isBoolean ? result : @default;
    }

    public static bool TryConvertToBoolean(this object? @this, IFormatProvider? provider, out bool result)
    {
        try
        {
            result = Convert.ToBoolean(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
