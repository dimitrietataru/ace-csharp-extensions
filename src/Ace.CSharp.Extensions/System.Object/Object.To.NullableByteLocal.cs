namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte? ToNullableByteLocal(this object? value)
    {
        return value.ToNullableByte(CultureInfo.CurrentCulture);
    }
}
