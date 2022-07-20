namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static decimal ToDecimal(this object? value)
    {
        return ToDecimal(value, CultureInfo.CurrentCulture);
    }

    public static decimal ToDecimalOrDefaultLocal(this object? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToDecimalLocal(this object? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.CurrentCulture, out result);
    }
}
