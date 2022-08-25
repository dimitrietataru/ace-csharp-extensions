namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte ToSByteLocal(this object? @this)
    {
        return ToSByte(@this, CultureInfo.CurrentCulture);
    }

    public static sbyte ToSByteOrDefaultLocal(this object? @this, sbyte @default = default)
    {
        return ToSByteOrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static bool TryConvertToSByteLocal(this object? @this, out sbyte result)
    {
        return TryConvertToSByte(@this, CultureInfo.CurrentCulture, out result);
    }
}
