namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static int ToInt32Local(this object? value)
    {
        return ToInt32(value, CultureInfo.CurrentCulture);
    }

    public static int ToInt32OrDefaultLocal(this object? value, int defaultValue = default)
    {
        return ToInt32OrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToInt32Local(this object? value, out int result)
    {
        return TryConvertToInt32(value, CultureInfo.CurrentCulture, out result);
    }

    public static int ToIntLocal(this object? value)
    {
        return ToInt32Local(value);
    }

    public static int ToIntOrDefaultLocal(this object? value, int defaultValue = default)
    {
        return ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static bool TryConvertToIntLocal(this object? value, out int result)
    {
        return TryConvertToInt32Local(value, out result);
    }
}
