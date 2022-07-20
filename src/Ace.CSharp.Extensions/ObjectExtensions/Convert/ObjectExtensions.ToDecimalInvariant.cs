namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static decimal ToDecimalInvariant(this object? value)
    {
        return ToDecimal(value, CultureInfo.InvariantCulture);
    }

    public static decimal ToDecimalOrDefaultInvariant(this object? value, decimal defaultValue = default)
    {
        return ToDecimalOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToDecimalInvariant(this object? value, out decimal result)
    {
        return TryConvertToDecimal(value, CultureInfo.InvariantCulture, out result);
    }
}
