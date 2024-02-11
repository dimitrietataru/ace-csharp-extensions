namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte? ToNullableSByteLocal(this object? value)
    {
        return value.ToNullableSByte(CultureInfo.CurrentCulture);
    }
}
