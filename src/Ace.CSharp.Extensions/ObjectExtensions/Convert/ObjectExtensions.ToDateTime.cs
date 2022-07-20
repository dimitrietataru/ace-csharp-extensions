namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static DateTime ToDateTime(this object? value, IFormatProvider? provider)
    {
        return Convert.ToDateTime(value, provider);
    }

    public static DateTime ToDateTimeOrDefault(this object? value, IFormatProvider? provider, DateTime defaultValue = default)
    {
        bool isDateTime = TryConvertToDateTime(value, provider, out var result);

        return isDateTime switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static bool TryConvertToDateTime(this object? value, IFormatProvider? provider, out DateTime result)
    {
        try
        {
            result = Convert.ToDateTime(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
