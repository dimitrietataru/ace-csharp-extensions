namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte ToSByteLocal(this object? value)
    {
        return ToSByte(value, CultureInfo.CurrentCulture);
    }

    public static sbyte ToSByteOrDefaultLocal(this object? value, sbyte defaultValue = default)
    {
        return ToSByteOrDefault(value, CultureInfo.CurrentCulture, defaultValue);
    }

    public static bool TryConvertToSByteLocal(this object? value, out sbyte result)
    {
        return TryConvertToSByte(value, CultureInfo.CurrentCulture, out result);
    }
}
