namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte ConvertToSByteInvariant(this object? value)
    {
        return ToSByte(value, CultureInfo.InvariantCulture);
    }

    public static sbyte ConvertToSByteOrDefaultInvariant(this object? value, sbyte defaultValue = default)
    {
        return ToSByteOrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToSByteInvariant(this object? value, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.InvariantCulture, out result);
    }
}
